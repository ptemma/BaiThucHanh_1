namespace BaiTap_5
{
    public partial class frmSingleThread : Form
    {
        protected int directionY = 1;
        protected int directionX = 1;
        protected int xVal;
        protected int yVal;
        private volatile Graphics g;
        public frmSingleThread()
        {
            InitializeComponent();
        }

        public void CheckCoordinates()
        {
            if((this.panel.Size.Height - 20 < this.yVal) || (this.yVal <= 0))
            {
                directionY = directionY * (-1);
            }
            if((this.panel.Size.Width - 20 < this.xVal) || (this.xVal <= 0))
            {
                directionX = directionX * (-1);
            }
        }

        private void StartThread()
        {
            try
            {
                this.xVal = 0;
                this.yVal = 0;
                int width = 20;
                int height = 20;
                g = panel.CreateGraphics();
                while (true)
                {
                    Thread.Sleep(20);
                    g.FillEllipse(new SolidBrush(this.panel.BackColor), this.xVal, this.yVal, width, height);
                    lock (typeof(Thread))
                    {
                        this.xVal += this.directionX;
                        this.yVal += this.directionY;
                        this.CheckCoordinates();
                    }
                    g.FillEllipse(new SolidBrush(Color.Blue), this.xVal, this.yVal, width, height);
                }
            }
            catch (Exception ex) { }
        }

        private void frmSingleThread_Load(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(StartThread));
            t.Start();
            t.IsBackground = true;
        }
    }
}