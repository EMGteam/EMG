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
    public delegejt delGate;
    public double[] data = new double[32];
    public double[,] dataHistory = new double[2000, 64];
    
    private int dataInd = 0;
    private Random rnd = new Random();

    public const int dataPerMeasurment = 2000;
    public const int startChannel = 0;
    public const int channelCount = 32;

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
          dataHistory[dataInd, i] = this.data[i];
        }
        dataInd++;
        if (dataInd >= EMGthread.dataPerMeasurment)
        {
          dataInd = 0;
          this.readDataTimer.Stop();
        }
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
          this.data[i] = 1.5 * Math.Sin((double)dataInd / 318.5) + Math.Sin((double)dataInd / 55) + Math.Sin((double)dataInd/78);
        }
        for (int i = 0; i < EMGthread.channelCount; i++)
        {
          dataHistory[dataInd, i] = this.data[i];
        }
        dataInd++;
        if (dataInd >= EMGthread.dataPerMeasurment)
        {
          dataInd = 0;
          this.readDataTimer.Stop();
        }
      }
      catch (System.Exception err)
      {
        MessageBox.Show(err.Message);
      }
    }
  }
}
