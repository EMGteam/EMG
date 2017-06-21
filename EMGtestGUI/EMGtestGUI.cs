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
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace EMG
{
  /// <summary>
  /// Klasa zawierająca definicje okna głównego aplikacji.
  /// </summary>
  public partial class EMGtestGUI : Form
  {
    private EMGthread emgThread = new EMGthread();
    private readonly bool DEBUG = true;
    private EMGchart[] chartTab = new EMGchart[16];
    private EMGforceSensor[] forceSensors = new EMGforceSensor[24];
    private Random rnd = new Random();
    private int fileIndex = 1;

    /// <summary>
    /// Konstruktor
    /// </summary>
    public EMGtestGUI()
    {
      InitializeComponent();
      this.timerTEST.Interval = 25;

      int tmp = 0;
      foreach (Control ctr in this.panelCharts.Controls)
      {
        if (ctr is EMGchart)
        {
          this.chartTab[tmp] = (EMGchart)ctr;
          tmp++;
        }
      }
      tmp = 0;
      foreach (Control ctr in this.panelSensors.Controls)
      { 
        if (ctr is EMGforceSensor)
        {
          this.forceSensors[tmp] = (EMGforceSensor)ctr;
          this.forceSensors[tmp].sensorID = ((EMGforceSensor)ctr).TabIndex;
          tmp++;
        }
      }

      for (int i = 0; i < this.forceSensors.Count()/2; i++)
      {
        var tmpSensor = this.forceSensors[i];
        this.forceSensors[i].TabIndex += 2;
        this.forceSensors[i] = this.forceSensors[this.forceSensors.Count() - i - 1];
        this.forceSensors[this.forceSensors.Count() - i - 1] = tmpSensor;
      }

      // Pierwszy wykres jest kijowy
      // this.chartTab[0].CurrentMaxValue = 10.0f;

      for (int i = 0; i < this.chartTab.Count(); i++)
      {
        this.chartTab[i].chartID = i + 1;
      }
      for (int i = 0; i < this.forceSensors.Count(); i++)
      {
        this.forceSensors[i].sensorID = i + 1;
      }

      if (!this.instantAiCtrl1.Initialized)
      {
        this.emgConsole.AddText("Nie udało się połączyć z karta pomiarową", true);
        this.emgConsole.AddText("RANDOM", true);
        this.emgThread.ReadyToSave += new EMGthread.SaveDelgejt(this.SaveToFile);
        this.emgThread.readDataTimer.Tick += new System.EventHandler(this.emgThread.ReadRandomData);
      }
      else
      {
        this.emgConsole.AddText("Połączono z kartą pomiarową", true);
        this.emgThread.ReadyToSave += new EMGthread.SaveDelgejt(this.SaveToFile);
        this.emgThread.readDataTimer.Tick += new System.EventHandler(this.emgThread.ReadDataContinouslyFromPCIE);
        emgThread.delGate = this.instantAiCtrl1.Read;
      }

      this.folderNameTextBox.Text = "dane\\osoba_X\\ruch_Y\\";
      this.PauseTimeTextBox.Text = 3000.ToString();
      this.dataPerMeasurmentTextBox.Text = 2000.ToString();
      this.progressBarPomiar.Maximum = this.emgThread.dataPerMeasurment;
      this.progressBarPauza.Maximum = this.emgThread.dataPerPause;
      this.timerTEST.Start();
      this.emgThread.readDataTimer.Start();
    }
    
    /// <summary>
    /// Metoda wywoływana w określonych przedziałach czasowych. 
    /// <para/>Chwilowo zapycha aplikację randomowymi danymi.
    /// </summary>
    /// <param name="sender">Obiekt wywołujący</param>
    /// <param name="e">Argumenty zdarzenia</param>
    private void timerTEST_Tick(object sender, EventArgs e)
    {
      for (int i = 0; i < this.chartTab.Count(); i++)
      {
        this.chartTab[i].AddValue(Convert.ToSingle(this.emgThread.data[i]));
      }

      for (int i = 0; i < this.forceSensors.Count(); i++)
      {
        this.forceSensors[i].setValue(Convert.ToSingle(this.emgThread.data[i]));
      }

      /* this.sensorPinky.setValue(Convert.ToSingle(this.emgThread.data[18]));
      this.sensorThumb.setValue(Convert.ToSingle(this.emgThread.data[19]));
      this.sensorRing.setValue(Convert.ToSingle(this.emgThread.data[20]));
      this.sensorMiddle.setValue(Convert.ToSingle(this.emgThread.data[21]));
      this.sensorIndex.setValue(Convert.ToSingle(this.emgThread.data[22])); */
      this.progressBarPomiar.Value = this.emgThread.dataIndMeas;
      this.progressBarPauza.Value = this.emgThread.dataIndPause;
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

    private void SaveToFile(object sender, EventArgs e)
    {
      try
      {
        this.emgConsole.AddText(Directory.GetCurrentDirectory().ToString() + "\\" + this.folderNameTextBox.Text);
        Directory.CreateDirectory(Directory.GetCurrentDirectory().ToString() + "\\" + this.folderNameTextBox.Text);
        string tmpName = this.fileIndex.ToString() + ".txt";
        tmpName = Path.GetFullPath(tmpName).Replace(tmpName, "") + this.folderNameTextBox.Text + tmpName;

        using (FileStream fs = new FileStream(tmpName, FileMode.Create, FileAccess.Write))
        using (StreamWriter outFile = new StreamWriter(fs, Encoding.ASCII))
        {
          try
          {
            this.emgConsole.AddText("Rozpoczęto zapis danych do pliku", true);
            for (int i = 0; i < this.emgThread.dataPerMeasurment; i++)
            {
              outFile.Write((i + 1).ToString() + ": ");
              for (int j = 0; j < EMGthread.channelCount - 1; j++)
              {
                outFile.Write(this.emgThread.dataHistory[i, j].ToString() + ", ");
              }
              outFile.Write(this.emgThread.dataHistory[i, EMGthread.channelCount - 1] + Environment.NewLine);
            }
            this.emgConsole.AddText("Zapisano dane do pliku: " + tmpName, true);
          }
          catch (Exception ex)
          {
            this.emgConsole.AddText(ex.Message, true);
          }
        }
      }
      catch (Exception ex)
      {
        this.emgConsole.AddText(ex.Message, true);
      }
      finally
      {
        this.fileIndex++;
        this.emgThread.readDataTimer.Start();
      }
    }

    private void stripItemWyczysc_Click(object sender, EventArgs e)
    {
      foreach (EMGchart chart in this.chartTab)
      {
        chart.Clear();
      }
    }

    private void EMGtestGUI_KeyDown(object sender, KeyEventArgs e)
    {
      MessageBox.Show(e.KeyCode.ToString());
      if (e.KeyCode == Keys.Space && this.emgThread.measurmentMode == TimerMode.Pause)
      {
        this.fileIndex--;
        this.progressBarPauza.ForeColor = Color.SeaShell;
      }
    }

    private void StartButton_Click(object sender, EventArgs e)
    {
      if (this.StartButton.Text == "Start")
      {
        this.emgThread.readDataTimer.Stop();
        this.emgThread.dataPerMeasurment = int.Parse(this.dataPerMeasurmentTextBox.Text);
        this.emgThread.dataPerPause = int.Parse(this.PauseTimeTextBox.Text);
        this.progressBarPomiar.Maximum = this.emgThread.dataPerMeasurment;
        this.progressBarPauza.Maximum = this.emgThread.dataPerPause;
        this.StartButton.Text = "Stop";
        this.emgThread.measurmentMode = TimerMode.Pause;
        this.emgThread.readDataTimer.Tick -= new System.EventHandler(this.emgThread.ReadDataContinouslyFromPCIE);
        this.emgThread.readDataTimer.Tick += new System.EventHandler(this.emgThread.ReadDataPauseMode);
        this.emgThread.readDataTimer.Start();
      }
      else
      {
        this.emgThread.readDataTimer.Stop();
        this.StartButton.Text = "Start";
        this.emgThread.measurmentMode = TimerMode.Free;
        this.emgThread.readDataTimer.Tick -= new System.EventHandler(this.emgThread.ReadDataPauseMode);
        this.emgThread.readDataTimer.Tick -= new System.EventHandler(this.emgThread.ReadDataFromPCIE);
        this.emgThread.readDataTimer.Tick += new System.EventHandler(this.emgThread.ReadDataContinouslyFromPCIE);
        this.emgThread.readDataTimer.Start();
      }
    }
    // private void stripItemSensory_CheckedChanged(object sender, EventArgs e) => EMGforceSensor.isDisabled = !this.stripItemSensory.Checked;
  }
}