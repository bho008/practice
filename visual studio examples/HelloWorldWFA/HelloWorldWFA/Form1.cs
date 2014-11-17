using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.PowerPacks;
using System.Drawing.Drawing2D;

namespace HelloWorldWFA
{
    public partial class Form1 : Form
    {
        Form3_DrawArrow shinyForm = null;  // This form is shiny and for drawing arrow


        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //int selected = checkedListBox1.CheckedIndices;
            var selected = checkedListBox1.CheckedItems;
            if (selected.Count == 0)
            {
                this.Text = "Ain't nothing checked";
            }
            else
            {
                string titleText = "";
                foreach (object o in selected)
                {
                    titleText += (" " + o.ToString());
                }
                this.Text = titleText;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //string titleText1 = "";

            this.Text = checkBox1.Text;
            var window_2 = new Form2();
            window_2.Show();
        }

        // wind checkbox
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = checkBox2.Text;

            if (shinyForm == null)
            {
                shinyForm = new Form3_DrawArrow(); //Form2()
                shinyForm.Show();
            }

            // switch arrow direction
            if (shinyForm.arrowDirection == 0) shinyForm.arrowDirection = 1;
            else shinyForm.arrowDirection = 0;

            /*
            
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 255), 8);
            pen.StartCap = LineCap.ArrowAnchor;
            pen.EndCap = LineCap.RoundAnchor;
            e.Graphics.DrawLine(pen, 20, 175, 300, 175);
            */
            
            
            
            //newArrowWindow.Show();

            
        }



        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = checkBox4.Text;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = checkBox3.Text;
            var maWindow = new Form2();
            maWindow.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int ArrowDirectionValue;
            if(int.TryParse(textBox1.Text, out ArrowDirectionValue)) {
                ArrowDirectionValue = Convert.ToInt32(textBox1.Text);
                ArrowDirectionValue = int.Parse(textBox1.Text);
                shinyForm.arrowDirection = ArrowDirectionValue;
            }
            
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
