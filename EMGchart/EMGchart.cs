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
  public partial class EMGchart : UserControl
  {
    public static class EMGchartSettings
    {
      public static int MAX_VALUE_COUNT { get; } = 128;
      public static int GRID_SPACING { get; } = 16;
      public static bool DRAW_AVERAGE_LINE { get; } = false;
      public static bool SHOW_GRID_LINE { get; } = false;
      public static Pen linePen { get; } = new Pen(Color.Tomato);
      public static Pen gridPen { get; } = new Pen(Color.Black);
      public static Color lineColor { get; } = Color.Black;
      public static Color backgroundColor { get; } = Color.WhiteSmoke;
      public static Pen lineZeroPen { get; } = new Pen(Color.Tomato);
      public static TimerMode timerMode { get; set; } = TimerMode.Disabled;
    }

    public int chartID = 0;
    private int visibleValues = 0;
    private int valueSpacing = 2;
    private float currentMaxValue = 4.0f;
    // private float currentMinValue = 4.0f;
    private int gridScrollOffset = 0;
    private float averageValue = 0;

    private Border3DStyle borderStyle = Border3DStyle.Flat;
    private List<float> drawValues = new List<float>(EMGchartSettings.MAX_VALUE_COUNT);
    private Queue<float> waitinValues = new Queue<float>();

    public EMGchart()
    {
      Debug.WriteLine("EMGchart()");
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

    public void Clear()
    {
      this.drawValues.Clear();
      this.Invalidate();
    }

    public void AddValue(float value)
    {
      // this.waitinValues.Enqueue(value);
      this.ChartAppend(value);
      if (EMGchartSettings.timerMode == TimerMode.Disabled)
      {
        this.Invalidate();
      }
    }

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

    private int CalcVerticalPosition(float value)
    {
      value += this.currentMaxValue;
      value *= 8;
      value = 64 - value;
      return Convert.ToInt32(Math.Round(value));
    }

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

    private void DrawChart(Graphics grs)
    {
      Debug.WriteLine("DrawCHart()");
      this.visibleValues = Math.Min(this.Width / this.valueSpacing, this.drawValues.Count);

      this.currentMaxValue = this.GetHighestValue();

      Point prevPoint = new Point(this.Width + this.valueSpacing, this.Height);
      Point currPoint = new Point();

      if (this.visibleValues > 0 && EMGchartSettings.DRAW_AVERAGE_LINE)
      {
        this.averageValue = 0;
        this.DrawAverageLine(grs);
      }

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

    protected override void OnPaint(PaintEventArgs e)
    {
      Debug.WriteLine("OnPaint()");
      base.OnPaint(e);

      this.DrawBackgroundAndGrid(e.Graphics);
      this.DrawChart(e.Graphics);
    }

    protected override void OnResize(EventArgs e)
    {
      Debug.WriteLine("OnResize()");
      base.OnResize(e);
      this.Invalidate();
    }

    private void redrawTimer_Tick(object sender, EventArgs e) => this.Invalidate();

    public enum TimerMode
    {
      Enabled,
      Disabled
    }
  }
}
