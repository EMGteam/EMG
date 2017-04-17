using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Diagnostics;

namespace EMG
{
  /// <summary>
  /// Pojedyncza kontrolka służąca rysowaniu wykresu
  /// </summary>
  public partial class EMGchart : UserControl
  {
    /// <summary>
    /// Klasa zawierająca wspólne parametry wzystkich wykresów (Kolory etc.)
    /// </summary>
    public static class EMGchartSettings
    {
      /// <summary>
      /// Ilość próbek na wykres
      /// </summary>
      public static int MAX_VALUE_COUNT { get; } = 128;
      /// <summary>
      /// Odstęp rysowania linii siatki w pixelach
      /// </summary>
      public static int GRID_SPACING { get; } = 16;
      /// <summary>
      /// Przełącznik do rysowania, bądź nie, linii o średniej wartości punktów na wykresie
      /// </summary>
      public static bool DRAW_AVERAGE_LINE { get; } = false;
      /// <summary>
      /// Przełącznik służacy załączeniu/wyłączeniu rysowania siatki
      /// </summary>
      public static bool SHOW_GRID_LINE { get; } = false;
      /// <summary>
      /// Zdefiniowany mazak z kolorem dla linii przebiegu
      /// </summary>
      public static Pen linePen { get; } = new Pen(Color.Tomato);
      /// <summary>
      /// Mazak definiujący kolor siatki
      /// </summary>
      public static Pen gridPen { get; } = new Pen(Color.Black);
      /// <summary>
      /// Kolor dla napisów na wykresach
      /// </summary>
      public static Color lineColor { get; } = Color.Black;
      /// <summary>
      /// Kolor tła wykresu
      /// </summary>
      public static Color backgroundColor { get; } = Color.WhiteSmoke;
      /// <summary>
      /// Kolor dla linii y = 0, ale chyba jej nie potrzebujemy
      /// </summary>
      public static Pen lineZeroPen { get; } = new Pen(Color.Tomato);
      /// <summary>
      /// Zmiana trybu rysowania - z timerem (aktualizacja co X ms) lub bez (aktualizacja co próbkę)
      /// </summary>
      public static TimerMode timerMode { get; set; } = TimerMode.Disabled;
    }

    public int chartID = 0;
    private int visibleValues = 0;
    private int valueSpacing = 2;
    private float currentMaxValue = 4.0f;
    // private float currentMinValue = 4.0f;
    private int gridScrollOffset = 0;
    // private float averageValue = 0;

    private Border3DStyle borderStyle = Border3DStyle.Flat;
    private List<float> drawValues = new List<float>(EMGchartSettings.MAX_VALUE_COUNT);
    private Queue<float> waitinValues = new Queue<float>();

    /// <summary>
    /// Konstruktor
    /// </summary>
    public EMGchart()
    {
      InitializeComponent();

      this.redrawTimer.Interval = 50;
      this.redrawTimer.Stop();

      this.SetStyle(ControlStyles.UserPaint, true);
      this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
      this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

      this.SetStyle(ControlStyles.ResizeRedraw, true);

      this.Font = SystemInformation.MenuFont;
    }

    [DefaultValue(typeof(Border3DStyle), "Flat")]
    new public Border3DStyle BorderStyle
    {
      get
      {
        return this.borderStyle;
      }
      set
      {
        this.borderStyle = value;
        this.Invalidate();
      }
    }

    /// <summary>
    /// Metoda służąca ewentualnemu czyszczeniu zawartości wykresu
    /// </summary>
    public void Clear()
    {
      this.drawValues.Clear();
      this.Invalidate();
    }

    /// <summary>
    /// Metoda służąca dodawaniu kolejnych wartości do wykresu
    /// </summary>
    /// <param name="value">Wrzucana wartość</param>
    public void AddValue(float value)
    {
      // this.waitinValues.Enqueue(value);
      this.ChartAppend(value);

      // Dla trybu bez timera odświeżanie wykresu co nową probkę
      if (EMGchartSettings.timerMode == TimerMode.Disabled)
      {
        this.Invalidate();
      }
    }

    /// <summary>
    /// Metoda dodająca wartość na początek listy rysowanych punktów
    /// </summary>
    /// <param name="value">Przekazywana wartość</param>
    private void ChartAppend(float value)
    {
      this.drawValues.Insert(0, value);

      if (this.drawValues.Count > EMGchartSettings.MAX_VALUE_COUNT)
      {
        this.drawValues.RemoveAt(EMGchartSettings.MAX_VALUE_COUNT);
      }

      this.gridScrollOffset += this.valueSpacing;
      if (this.gridScrollOffset > EMGchartSettings.GRID_SPACING)
      {
        this.gridScrollOffset = this.gridScrollOffset % EMGchartSettings.GRID_SPACING;
      }
    }

    /* Unused
    private void ChartAppendFromQueue()
    {
      if (this.waitinValues.Count > 0)
      {
        while (this.waitinValues.Count > 0)
        {
          this.ChartAppend(this.waitinValues.Dequeue());
        }
      }
      else
      {
        ChartAppend(0f);
      }

      this.Invalidate();
    }
    */

    /// <summary>
    /// Metoda obliczająca położenie punktu 
    /// </summary>
    /// <param name="value">Przekazywana wartość</param>
    /// <returns>Położenie punktu na wyrkesie w pixelach</returns>
    private int CalcVerticalPosition(float value)
    {
      value += this.currentMaxValue;
      value *= 8;
      value = 64 - value;
      return Convert.ToInt32(Math.Round(value));
    }

    /* Unused
    private float GetHighestValue()
    {
      float maxVal = 0;

      for (int i = 0; i < this.visibleValues; i++)
      {
        if (this.drawValues[i] > maxVal)
        {
          maxVal = this.drawValues[i];
        }
      }

      return maxVal;
    }
    */

    /// <summary>
    /// Metoda rysująca zawartość wykresu
    /// </summary>
    /// <param name="grs">Klasa rysująca</param>
    private void DrawChart(Graphics grs)
    {
      this.visibleValues = Math.Min(this.Width / this.valueSpacing, this.drawValues.Count);

      // this.currentMaxValue = this.GetHighestValue();

      Point prevPoint = new Point(this.Width + this.valueSpacing, this.Height);
      Point currPoint = new Point();

      /* 
      if (this.visibleValues > 0 && EMGchartSettings.DRAW_AVERAGE_LINE)
      {
        this.averageValue = 0;
        this.DrawAverageLine(grs);
      } 
      */

      for (int i = 0; i < this.visibleValues; i++)
      {
        currPoint.X = prevPoint.X - this.valueSpacing;
        currPoint.Y = this.CalcVerticalPosition(this.drawValues[i]);

        grs.DrawLine(EMGchartSettings.linePen, prevPoint, currPoint);

        prevPoint = currPoint;
      }

      SolidBrush sb = new SolidBrush(EMGchartSettings.lineColor);
      grs.DrawString(this.chartID.ToString(), this.Font, sb, 4.0f, 2.0f);

      ControlPaint.DrawBorder3D(grs, 0, 0, this.Width, this.Height, this.borderStyle);
    }

    /* Unused
    private void DrawAverageLine(Graphics grs)
    {
      Debug.WriteLine("DrawAverageLine()");
      for (int i = 0; i < this.visibleValues; i++)
      {
        this.averageValue += this.drawValues[i];
      }

      this.averageValue = this.averageValue / this.visibleValues;

      int vertPosition = this.CalcVerticalPosition(this.averageValue);
      grs.DrawLine(EMGchartSettings.linePen, 0, vertPosition, this.Width, vertPosition);
    } 
    */

    /// <summary>
    /// Metoda rysująca siatkę oraz tło wykresu
    /// </summary>
    /// <param name="grs">Obiekt rysujący</param>
    private void DrawBackgroundAndGrid(Graphics grs)
    {
      Debug.WriteLine("DrawBackgroundAndGrid()");
      Rectangle baseRectangle = new Rectangle(0, 0, this.Width, this.Height);
      using (Brush gradientBrush = new LinearGradientBrush(baseRectangle, EMGchartSettings.backgroundColor, EMGchartSettings.backgroundColor, LinearGradientMode.Vertical))
      {
        grs.FillRectangle(gradientBrush, baseRectangle);
      }

      if (EMGchartSettings.SHOW_GRID_LINE)
      {
        for (int i = this.Width - this.gridScrollOffset; i >= 0; i -= EMGchartSettings.GRID_SPACING)
        // for (int i = 0; i >= this.Width; i += EMGchartSettings.GRID_SPACING)
        {
          grs.DrawLine(EMGchartSettings.gridPen, i, 0, i, this.Height);
        }
        for (int i = 0; i < this.Height; i += EMGchartSettings.GRID_SPACING)
        {
          grs.DrawLine(EMGchartSettings.gridPen, 0, i, this.Width, i);
        }
        grs.DrawLine(EMGchartSettings.lineZeroPen, 0, this.Height / 2, this.Width, this.Height / 2);
      }
    }

    /// <summary>
    /// Przeciążenie metody rysującej zawartość kontrolki
    /// </summary>
    /// <param name="e">Obiekt zawierający informacje o zdarzeniu</param>
    protected override void OnPaint(PaintEventArgs e)
    {
      Debug.WriteLine("OnPaint()");
      base.OnPaint(e);

      this.DrawBackgroundAndGrid(e.Graphics);
      this.DrawChart(e.Graphics);
    }

    /// <summary>
    /// Przeciążenie metoy wywoływanej w przypadku zmiany rozmiaru kontrolki
    /// </summary>
    /// <param name="e">Obiekt zawierający informacje o zdarzeniu</param>
    protected override void OnResize(EventArgs e)
    {
      Debug.WriteLine("OnResize()");
      base.OnResize(e);
      this.Invalidate();
    }

    /// <summary>
    /// Metoda wymuszająca przerysowanie zawartości kontrolki
    /// </summary>
    /// <param name="sender">Obiekt wywołujący</param>
    /// <param name="e">Argumenty zdarzenia</param>
    private void redrawTimer_Tick(object sender, EventArgs e) => this.Invalidate();

    /// <summary>
    /// Prosty enum do zarządzania sposobem odświeżania wykresu
    /// </summary>
    public enum TimerMode
    {
      Enabled,
      Disabled
    }
  }
}
