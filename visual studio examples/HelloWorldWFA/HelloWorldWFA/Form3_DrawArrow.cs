using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldWFA
{
    public partial class Form3_DrawArrow : Form
    {
        private int _arrowDirection = 0;

        public int arrowDirection
        {
            get { return _arrowDirection; }
            set {
                _arrowDirection = value;
                this.Invalidate(true);
            }
        }
        
        public Form3_DrawArrow()
        {
            InitializeComponent();
            this.Paint += form_Paint;
        }

        // this is actually the eventhandler for the other form. It's just here because lazy and messy
        void form_Paint(object sender, PaintEventArgs e)
        {
            //throw new NotImplementedException();
            Pen pen = new Pen(Color.FromArgb(255, 255, 0, 255), 8);

            if (_arrowDirection == 1)
            {
                pen.StartCap = LineCap.ArrowAnchor;
                pen.EndCap = LineCap.RoundAnchor;
            }
            else
            {
                pen.StartCap = LineCap.RoundAnchor;
                pen.EndCap = LineCap.ArrowAnchor;
            }
            e.Graphics.DrawLine(pen, 20, 175, 300, _arrowDirection);
        }

        private void Form3_DrawArrow_Load(object sender, EventArgs e)
        {

        }
    }
}
