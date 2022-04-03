using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap_6
{
    public partial class frmMultiThread : Form
    {

        public frmMultiThread()
        {
            InitializeComponent();
        }

        private void StartThread()
        {
            try
            {
                int xVal = 0;
                int yVal = 0;
                int width = 20;
                int height = 20;
                int directionY = 1;
                int directionX = 1;
                Graphics g;
                g = panel.CreateGraphics();
                while (true)
                {
                    Thread.Sleep(20);
                    g.FillEllipse(new SolidBrush(this.panel.BackColor), xVal, yVal, width, height);
                    lock (typeof(Thread))
                    {
                        xVal += directionX;
                        yVal += directionY;
                        if ((this.panel.Size.Height - 20 < yVal) || (yVal <= 0))
                            directionY = directionY * (-1);
                        if ((this.panel.Size.Width - 20 < xVal) || (xVal <= 0))
                            directionX = directionX * (-1);
                    }
                    g.FillEllipse(new SolidBrush(Color.Blue), xVal, yVal, width, height);

                }
            }
            catch (Exception ex) { }
        }

        private void MultiStartThread()
        {
            while (true)
            {
                Thread t = new Thread(new ThreadStart(StartThread));
                t.Start();
                t.IsBackground = true;
                Thread.Sleep(2000);
            }
        }

        private void frmMultiThread_Load(object sender, EventArgs e)
        {
            
            this.Invoke(new Action(() =>
            {
                Thread t1 = new Thread(new ThreadStart(MultiStartThread));
                t1.Start();
                t1.IsBackground = true;
            }));
        }
    }
}
