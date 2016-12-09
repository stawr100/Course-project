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



        public List<Button> btn = new List<Button>();
        int lan = 0;
        public List<string> NoteText = new List<string>();
        public List<string> date_create = new List<string>();


        private void metroButton1_Click(object sender, EventArgs e)
        {
            using (System.IO.StreamReader language_state = new System.IO.StreamReader("settings\\language_state.txt"))
            {
                string la_state;
                while ((la_state = language_state.ReadLine()) != null)
                {
                    if (la_state == "RU")
                    {
                        lan = 1;
                    }
                    if (la_state == "EN")
                    {
                        lan = 0;
                    }

                }
            }
            Button oldbutton = (Button)sender;
            flowLayoutPanel1.AutoScroll = true;
            Button newbtn = new Button();
            NoteText.Add("");
            date_create.Add("");
            btn.Add(newbtn);
            newbtn.Width = panel2.Width - 10;
            newbtn.Height = 40;
            newbtn.FlatStyle = FlatStyle.Flat;
            newbtn.BackColor = Color.FromArgb(34, 34, 34);
            newbtn.FlatAppearance.BorderColor = Color.FromArgb(68, 68, 68);
            if (lan == 1)
            {
                newbtn.Text = "Новая заметка";
            }
            if (lan == 0)
            {
                newbtn.Text = "New note";
            }
            newbtn.Click += new EventHandler(dynamic_button_click);
            Point pt = new Point(this.flowLayoutPanel1.AutoScrollPosition.X,
                     this.flowLayoutPanel1.AutoScrollPosition.Y);
            this.metroScrollBar1.Minimum = 0;
            this.metroScrollBar1.Maximum = this.flowLayoutPanel1.DisplayRectangle.Height;
            this.metroScrollBar1.LargeChange = metroScrollBar1.Maximum /
                         metroScrollBar1.Height + this.flowLayoutPanel1.Height;
            this.metroScrollBar1.SmallChange = 15;
            this.metroScrollBar1.Value = Math.Abs(this.flowLayoutPanel1.AutoScrollPosition.Y);


           
            flowLayoutPanel1.Controls.Add(newbtn);


           
        }

        int current_number = 0;
        object s;
        private void dynamic_button_click(object sender, EventArgs evArgs)
        {
            var pb = (Button)sender;
            var button = sender as Button;

            s = sender;
            current_number = btn.IndexOf(button);
            NoteTextBox.Text = NoteText[current_number];
            metroLabel1.Text = date_create[current_number];

            textBox1.Text = pb.Text;

        }



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
                if (current_number>0 && current_number < btn.Count)
                {
                    btn.RemoveAt(current_number);
                    flowLayoutPanel1.Controls.Remove(s as Button);
                    NoteText.RemoveAt(current_number);
                    date_create.RemoveAt(current_number);
                    metroLabel1.Text = "";
                    textBox1.Text = "";
                    NoteTextBox.Text = "";

                    
                }
                
            }

        }

        private void ExitNotes_Click(object sender, EventArgs e)
        {
            Exit exit = new Exit();
            exit.ShowDialog ();
        }



        private void SaveNote_Click(object sender, EventArgs e)
        {
            btn[current_number].Text = textBox1.Text;
            NoteText[current_number] = NoteTextBox.Text;
            metroLabel1.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            date_create[current_number] = metroLabel1.Text;
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
            string s = NoteText[h].Replace(Environment.NewLine, @" \n ");
            textFileNote.WriteLine(s);
            }
            textFileNote.Close();

            System.IO.StreamWriter textFileDate = new System.IO.StreamWriter("date.txt");
            for (int h = 0; h < btn.Count; h++)
            {
                
                textFileDate.WriteLine(date_create[h]);
            }
            textFileDate.Close();
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


                    
                    flowLayoutPanel1.Controls.Add(newbtn);


                    
                }
            }
            using (System.IO.StreamReader srnote = new System.IO.StreamReader("notes.txt"))
            {
                string note;
                while ((note = srnote.ReadLine()) != null)
                {
                    string s = note.Replace(@" \n ", Environment.NewLine);
                    NoteText.Add(s);
                }
            }

            using (System.IO.StreamReader datefile = new System.IO.StreamReader("date.txt"))
            {
                string datestr;
                while ((datestr = datefile.ReadLine()) != null)
                {
                    //string s = note.Replace(@" \n ", Environment.NewLine);
                    date_create.Add(datestr);
                }
            }

            using (System.IO.StreamReader settings_main = new System.IO.StreamReader("settings\\flowdirection.txt"))
            {
                string flowdir;
                while ((flowdir = settings_main.ReadLine()) != null)
                {
                    if (flowdir == "TopDown")
                    {
                        flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
                    }
                    if (flowdir == "BottomUp")
                    {
                        flowLayoutPanel1.FlowDirection = FlowDirection.BottomUp;
                    }

                }
            }

            
            using (System.IO.StreamReader language_state = new System.IO.StreamReader("settings\\language_state.txt"))
            {
                string la_state;
                while ((la_state = language_state.ReadLine()) != null)
                {
                    if (la_state == "RU")
                    {
                        lan = 1;
                    }
                    if (la_state == "EN")
                    {
                        lan = 0;
                    }

                }
            }

            if (lan == 1)
            {
                metroButton1.Text = "Добавить заметку";
                DeleteNote.Text = "Удалить заметку";
                SaveAll.Text = "Сохранить все";
                settings.Text = "Настройки";
                ExitNotes.Text = "Выход";
                if (textBox1.Text == "Create a note")
                {
                    textBox1.Text = "Cоздайте заметку";
                }
                SaveNote.Text = "Сохранить";
            }
            if (lan == 0)
            {
                metroButton1.Text = "Add note";
                DeleteNote.Text = "Delete the note";
                SaveAll.Text = "Save all";
                settings.Text = "Settings";
                ExitNotes.Text = "Exit";
                if (textBox1.Text == "Создайте заметку")
                {
                    textBox1.Text = "Create a note";
                }

                SaveNote.Text = "Save";
            }

            metroLabel1.Text = "";

            using (System.IO.StreamReader fontsize = new System.IO.StreamReader("settings\\fontsize.txt"))
            {
                string fontsizestr;
                while ((fontsizestr = fontsize.ReadLine()) != null)
                {
                    float tempsize = Convert.ToSingle(fontsizestr);
                    NoteTextBox.Font = new Font(FontFamily.GenericSansSerif, tempsize, FontStyle.Regular);
                }
            }


        }


        
        private void settings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Owner = this;
            settings.ShowDialog();
        }

    }
}

