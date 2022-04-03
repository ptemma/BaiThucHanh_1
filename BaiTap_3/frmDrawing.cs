namespace BaiTap_3
{
    public partial class frmDrawing : Form
    {
        int x, y, w, h, step;

        public frmDrawing()
        {
            InitializeComponent();
        }

        private void frmDrawing_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                x = (e.X / step) * step;
                y = (e.Y / step) * step;
            }
            Invalidate();
        }

        private void frmDrawing_Load(object sender, EventArgs e)
        {
            x= 0;
            y= 0;
            step = 50;
            w = step;
            h = step;
            this.KeyDown += new KeyEventHandler(this.movecross);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            Brush b = new SolidBrush(Color.Blue);
            g.FillEllipse(b, x, y, w, h);
            Pen p = new Pen(Color.Blue);
            int x1=0, y1=step, x2=this.Width, y2=step, count=0;
            int r = this.Height/step;
            while(count < r)
            {
                g.DrawLine(p, x1, y1 + count * step, x2, y2 + count * step);
                count++;
            }
            count = 0;
            x1 = step;
            y1 = 0;
            x2 = step;
            y2 = this.Height;
            int c = this.Width/step;
            while (count < c)
            {
                g.DrawLine(p, x1 + count * step, y1, x2 + count * step, y2);
                count++;
            }
        }

        public void move(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    y = y - step < 0 ? 0 : y - step;
                    break;
                case Keys.S:
                    y = y + step > this.Height ? (this.Height / step) * step : y + step;
                    break ;
                case Keys.A:
                    x = x - step < 0 ? 0 : x - step;
                    break;
                case Keys.D:
                    x = x + step > this.Width ? (this.Width / step) * step : x + step;
                    break;
            }
            Invalidate();
        }

        private void movecross(object? sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    y = y - step < 0 ? (this.Height / step) * step : y - step;
                    break;
                case Keys.S:
                    y = y + step > this.Height ?0 : y + step;
                    break;
                case Keys.A:
                    x = x - step < 0 ? (this.Width / step) * step  : x - step;
                    break;
                case Keys.D:
                    x = x + step > this.Width ?0 : x + step;
                    break;
            }
            Invalidate();
        }
    }
}