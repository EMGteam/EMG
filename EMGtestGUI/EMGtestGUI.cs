using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMG
{
  /// <summary>
  /// Klasa zawierająca definicje okna głównego aplikacji.
  /// </summary>
  public partial class EMGtestGUI : Form
  {
    private readonly bool DEBUG = true;
    private EMGchart[] chartTab = new EMGchart[16];
    private EMGforceSensor[] forceSensors = new EMGforceSensor[5];
    private Random rnd = new Random();

    /// <summary>
    /// Konstruktor
    /// </summary>
    public EMGtestGUI()
    {
      InitializeComponent();
      this.timerTEST.Stop();

      //
      int tmp = 0;
      int tmp2 = 0;

      // Dodanie kontrolek do list
      foreach (Control ctr in this.panelCharts.Controls)
      {
        if (ctr is EMGchart)
        {
          this.chartTab[tmp] = (EMGchart)ctr;
          tmp++;
        }
      }
      foreach (Control ctr in this.panelSensors.Controls)
      { 
        if (ctr is EMGforceSensor)
        {
          this.forceSensors[4 - tmp2] = (EMGforceSensor)ctr;
          tmp2++;
        }
      }

      for (int i = 0; i < 16; i++)
      {
        this.chartTab[i].chartID = i + 1;
      }
      this.timerTEST.Interval = 25;
      this.timerTEST.Start();

      Graphics GRS = this.CreateGraphics();
      // Obraz ręki
      GRS.Dispose();
    }
    
    /// <summary>
    /// Metoda wywoływana w określonych przedziałach czasowych. 
    /// <para/>Chwilowo zapycha aplikację randomowymi danymi.
    /// </summary>
    /// <param name="sender">Obiekt wywołujący</param>
    /// <param name="e">Argumenty zdarzenia</param>
    private void timerTEST_Tick(object sender, EventArgs e)
    {
      foreach (EMGchart chart in this.chartTab)
      {
        chart.AddValue(Convert.ToSingle((this.rnd.NextDouble() * 8) - 4));
      }
      foreach (EMGforceSensor sensor in this.forceSensors)
      {
        sensor.setValue(Convert.ToSingle(this.rnd.NextDouble() * 100));
      }
      if (this.progressBarPomiar.Value == this.progressBarPomiar.Maximum)
      {
        this.progressBarPomiar.Value = 0;
      }
      if (this.progressBarPauza.Value == this.progressBarPauza.Maximum)
      {
        this.progressBarPauza.Value = 0;
      }
      this.progressBarPomiar.Value++;
      this.progressBarPauza.Value++;
    }

    /// <summary>
    /// Metoda odpowiadająca reakcji na naciśnięcie przycisku "Zrzut ekranu"
    /// </summary>
    /// <param name="sender">Obiekt wywołujący</param>
    /// <param name="e">argumenty zdarzenia</param>
    private void buttonScreenshot_Click(object sender, EventArgs e)
    {
      try
      {
        string dir = Directory.GetCurrentDirectory().ToString() + "\\Screenshots\\";
        Directory.CreateDirectory(dir);
        Bitmap bmp = new Bitmap(this.Width, this.Height);
        using (Graphics G = Graphics.FromImage(bmp))
        {
          G.Clear(Color.Black);
        }

        this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height));
        string tmp = DateTime.Now.ToString("yyyyMMdd_HHmmss_fff") + ".png";
        string tmp2 = dir + tmp;
        
        bmp.Save(tmp2);
        this.emgConsole.AddText("Zapisano jako " + tmp2.Replace(Directory.GetCurrentDirectory().ToString() + "\\", ""));
      }
      catch (Exception ex)
      {
        this.emgConsole.AddText("Nie udało się zapisać zrzutu");
        if (this.DEBUG)
        {
          this.emgConsole.AddText("Exception in " + System.Reflection.MethodBase.GetCurrentMethod().Name.ToString() + ": " + ex.Message, true);
        }
      }
    }

    private void stripItemWyczysc_Click(object sender, EventArgs e)
    {
      foreach (EMGchart chart in this.chartTab)
      {
        chart.Clear();
      }
    }

    private void stripItemSensory_CheckedChanged(object sender, EventArgs e) => EMGforceSensor.isDisabled = !this.stripItemSensory.Checked;
  }
}