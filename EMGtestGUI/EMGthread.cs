using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace EMG
{
  class EMGthread
  {
    public Multimedia.Timer readDataTimer = new Multimedia.Timer();
    public delegate Automation.BDaq.ErrorCode delegejt(int chStart, int chCount, double[] dataScaled);
    public delegate void SaveDelgejt(object sender, EventArgs e);
    public event SaveDelgejt ReadyToSave;
    public delegejt delGate;
    public double[] data = new double[64];
    public double[,] dataHistory = new double[2000, 64];
    public TimerMode measurmentMode = TimerMode.Free;

    public int dataIndMeas = 0;
    public int dataIndPause = 0;
    public int dataIndFree = 0;
    private Random rnd = new Random();

    public int dataPerMeasurment = 2000;
    public int dataPerPause = 3000;
    public const int startChannel = 0;
    public const int channelCount = 40;

    public EMGthread()
    {
      this.readDataTimer.Resolution = 1;
      this.readDataTimer.Period = 1;
      this.readDataTimer.Mode = Multimedia.TimerMode.Periodic;
    }

    public void ReadDataFromPCIE(object sender, EventArgs e)
    {
      try
      {
        this.delGate(EMGthread.startChannel, EMGthread.channelCount, this.data);
        for (int i = 0; i < EMGthread.channelCount; i++)
        {
          dataHistory[dataIndMeas, i] = this.data[i];
        }
        dataIndMeas++;
        if (dataIndMeas >= this.dataPerMeasurment)
        {
          dataIndMeas = 0;
          this.readDataTimer.Stop();
          this.ReadyToSave(sender, e);
          this.measurmentMode = TimerMode.Pause;
          this.readDataTimer.Tick -= new System.EventHandler(this.ReadDataFromPCIE);
          this.readDataTimer.Tick += new System.EventHandler(this.ReadDataPauseMode);
        }
      }
      catch (System.Exception err)
      {
        MessageBox.Show(err.Message);
      }
    }

    public void ReadDataPauseMode(object sender, EventArgs e)
    {
      try
      {
        this.delGate(EMGthread.startChannel, EMGthread.channelCount, this.data);
        dataIndPause++;
        if (dataIndPause >= this.dataPerPause)
        {
          dataIndPause = 0;
          this.readDataTimer.Stop();
          this.measurmentMode = TimerMode.Measure;
          this.readDataTimer.Tick -= new System.EventHandler(this.ReadDataPauseMode);
          this.readDataTimer.Tick += new System.EventHandler(this.ReadDataFromPCIE);
        }
      }
      catch (System.Exception err)
      {
        MessageBox.Show(err.Message);
      }
    }

    public void ReadDataContinouslyFromPCIE(object sender, EventArgs e)
    {
      try
      {
        this.delGate(EMGthread.startChannel, EMGthread.channelCount, this.data);
      }
      catch (System.Exception err)
      {
        MessageBox.Show(err.Message);
      }
    }

    public void ReadRandomData(object sender, EventArgs e)
    {
      try
      {
        for (int i = EMGthread.startChannel; i < EMGthread.channelCount; i++)
        {
          this.data[i] = 1.5 * Math.Sin((double)dataIndFree / 318.5) + Math.Sin((double)dataIndFree / 55) + Math.Sin((double)dataIndFree / 78);
        }
        /*for (int i = 0; i < EMGthread.channelCount; i++)
        {
          dataHistory[dataIndFree, i] = this.data[i];
        }*/
        dataIndFree++;
      }
      catch (System.Exception err)
      {
        MessageBox.Show(err.Message);
      }
    }
  }

  enum TimerMode
  {
    Pause,
    Measure,
    Free
  };
}
