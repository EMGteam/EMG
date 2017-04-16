using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMG
{
  public partial class EMGtestGUI : Form
  {
    private EMGchart[] chartTab = new EMGchart[16];
    private EMGforceSensor[] forceSensors = new EMGforceSensor[5];
    private Random rnd = new Random();

    public EMGtestGUI()
    {
      InitializeComponent();

      //
      int tmp = 0;
      int tmp2 = 0;
      foreach (Control ctr in this.Controls)
      {
        if (ctr is EMGchart)
        {
          this.chartTab[15 - tmp] = (EMGchart)ctr;
          tmp++;
        }
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
    }
  }
}