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



        List<Button> btn = new List<Button>();
        List<string> NoteText = new List<string>();
        int x = 0;
        // int y = 0;


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
            NoteText.Add("");
            btn.Add(newbtn);
            newbtn.Width = panel2.Width - 10;
            newbtn.Height = 40;
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


            x = x + 1;
        }

        public int xx;
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
            NoteTextBox.Text = NoteText[current_number];
            //num = s;

            textBox1.Text = pb.Text;
            xx = current_number;

            //pb.Text = textBox1.Text;
            //label1.Text = pb.Text;*/
        }



        /*  private void dynamic_button_hover(object sender, EventArgs evArgs)
          {
              var pb = (Button)sender;
              /*var tmp2 = (Button)sender;
              var tmptag = (Button)sender;
              var id = (Button)sender;
              var num = (Button)sender;
              var button = sender as Button;*/

        //pb.BackColor = Color.FromArgb(170, 170, 170);

        //s = sender;
        // current_number = (int)(num.Tag);
        //current_number = btn.IndexOf(button);
        //num = s;
        //metroLabel1.Text = pb.Text;
        //pb.Text = textBox1.Text;
        //label1.Text = pb.Text;
        //}

        /* private void dynamic_button_leave(object sender, EventArgs evArgs)
         {
             var pb = (Button)sender;


             pb.BackColor = Color.FromArgb(34, 34, 34);


         }*/

        private void metroScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            flowLayoutPanel1.AutoScrollPosition = new Point(0,
                        metroScrollBar1.Value);
            metroScrollBar1.Invalidate();
            Application.DoEvents();
        }

        private void DeleteNote_Click(object sender, EventArgs e)
        {
            if (btn.Count != 0)
            {
                btn.RemoveAt(current_number);
                flowLayoutPanel1.Controls.Remove(s as Button);
                textBox1.Text = "";
            }

        }

        private void ExitNotes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void SaveNote_Click(object sender, EventArgs e)
        {
            //metroTextBox1.Text = metroLabel1.Text;
            //if (btn[current_number].Text )
            btn[current_number].Text = textBox1.Text;
            NoteText[current_number] = NoteTextBox.Text;


        }

        private void SaveAll_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter textFile = new System.IO.StreamWriter("buttons.txt");
            for (int h = 0; h < btn.Count; h++)
            {

                textFile.WriteLine(btn[h].Text);
            }
            textFile.Close();

            System.IO.StreamWriter textFileNote = new System.IO.StreamWriter("notes.txt");
            for (int h = 0; h < btn.Count; h++)
            {

                textFileNote.WriteLine(NoteText[h]);
            }
            textFileNote.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (System.IO.StreamReader sr = new System.IO.StreamReader("buttons.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    flowLayoutPanel1.AutoScroll = true;
                    Button newbtn = new Button();
                    btn.Add(newbtn);
                    newbtn.Width = panel2.Width - 10;
                    newbtn.Height = 40;
                    newbtn.FlatStyle = FlatStyle.Flat;
                    newbtn.BackColor = Color.FromArgb(34, 34, 34);

                    newbtn.FlatAppearance.BorderColor = Color.FromArgb(68, 68, 68);
                    newbtn.Text = (line);
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


                    x = x + 1;
                }
            }
            using (System.IO.StreamReader srnote = new System.IO.StreamReader("notes.txt"))
            {
                string note;
                while ((note = srnote.ReadLine()) != null)
                {
                    NoteText.Add(note);
                }
            }
        }
    }
}

