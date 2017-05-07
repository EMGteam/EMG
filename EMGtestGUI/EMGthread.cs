using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace EMG
{
  class EMGthread
  {
    public Int32 error = 0;
    public Int32 read = 0, totalRead = 0;
    public char[] errBuff = new char[2048];
    public int counter = 0;
    public double[] data = new double[16];

    public const int startChannel = 0;
    public const int channelCount = 32;

    public Multimedia.Timer readDataTimer = new Multimedia.Timer();

    public EMGthread()
    {
      this.readDataTimer.Resolution = 1;
      this.readDataTimer.Period = 1;
      this.readDataTimer.Start();
      this.readDataTimer.Mode = Multimedia.TimerMode.Periodic;
      this.readDataTimer.Tick += new System.EventHandler(this.read_data);
    }

    public void read_data(object sender, EventArgs e)
    {
      for (int i = 0; i < 16/*ilosc_danych*16*/; i++)
      {
        this.data[i] = this.counter;
      }
      this.counter++;
      //qDebug() << ilosc_danych;
    }
  }
}
