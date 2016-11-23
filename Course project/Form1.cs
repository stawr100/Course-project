using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Course_project
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();

            this.StyleManager = metroStyleManager1;
            panel2.Width = 265;
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void myClickFunction(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        
        
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }

        

        List<Button> btn = new List<Button>();
        int x = 0;
        int y = 0;

        
        private void metroButton1_Click(object sender, EventArgs e)
        {
            Button oldbutton = (Button)sender;
            flowLayoutPanel1.AutoScroll = true;
            //flowLayoutPanel1.VerticalScroll.Enabled = true;
            

            //flowLayoutPanel1.VerticalScroll.Visible = false;
            //flowLayoutPanel1.HorizontalScroll.Enabled = false;
            //flowLayoutPanel1.HorizontalScroll.Visible = false;
            //flowLayoutPanel1.VerticalScroll.Value = flowLayoutPanel1.VerticalScroll.Maximum;
            
            //metroScrollBar1.
            Button newbtn = new Button();
            btn.Add(newbtn);
            newbtn.Width = panel2.Width-10;
            newbtn.Height = 60;
            newbtn.FlatStyle = FlatStyle.Flat;
            newbtn.BackColor = Color.FromArgb(34, 34, 34);
            newbtn.FlatAppearance.BorderColor = Color.FromArgb(68, 68, 68);
            //newbtn.FlatAppearance.BorderSize = 1;
            //newbtn.Met
            newbtn.Text = "Button" + this.x.ToString();
            //newbtn.Location = new Point(
            //flowLayoutPanel1.AutoScrollPosition.X,
            //flowLayoutPanel1.AutoScrollPosition.Y + (y + 6));
            //y += 35;
            newbtn.Click += new EventHandler(dynamic_button_click);

            Point pt = new Point(this.flowLayoutPanel1.AutoScrollPosition.X,
                     this.flowLayoutPanel1.AutoScrollPosition.Y);
            this.metroScrollBar1.Minimum = 0;
            this.metroScrollBar1.Maximum = this.flowLayoutPanel1.DisplayRectangle.Height;
            this.metroScrollBar1.LargeChange = metroScrollBar1.Maximum /
                         metroScrollBar1.Height + this.flowLayoutPanel1.Height;
            this.metroScrollBar1.SmallChange = 15;
            this.metroScrollBar1.Value = Math.Abs(this.flowLayoutPanel1.AutoScrollPosition.Y);


                        newbtn.Tag = x;
            flowLayoutPanel1.Controls.Add(newbtn);
            //flowLayoutPanel1.Controls.Add(metroScrollBar1);
            

            x = x + 1;
        }


        int current_number = 0;
        object s;
        private void dynamic_button_click(object sender, EventArgs evArgs)
        {
            var pb = (Button)sender;
            var tmp2 = (Button)sender;
            var tmptag = (Button)sender;
            var id = (Button)sender;
            var num = (Button)sender;
            var button = sender as Button;

            s = sender;
            // current_number = (int)(num.Tag);
            current_number = btn.IndexOf(button);
            //num = s;
            /*textBox1.Text = pb.Text;
            pb.Text = textBox1.Text;
            label1.Text = pb.Text;*/
        }

        private void metroScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            flowLayoutPanel1.AutoScrollPosition = new Point(0,
                        metroScrollBar1.Value);
            metroScrollBar1.Invalidate();
            Application.DoEvents();
        }
    }
}
