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
    public partial class Settings : MetroFramework.Forms.MetroForm
    {
        public Settings()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;

        }



        private void ok_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void apply_settings_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {   
                if (BottomUpRadio.Checked == true)
                {
                    main.flowLayoutPanel1.FlowDirection = FlowDirection.BottomUp;
                }
                if (TopDownRadio.Checked == true)
                {
                    main.flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
                }
                if (DeleteAllTrackBar.Value == 50)
                {
                    if (main.btn.Count != 0)
                    {
                        for (int h = 0; h < main.btn.Count; h++)
                        {
                            main.btn.Clear();
                            main.flowLayoutPanel1.Controls.Clear();
                            main.textBox1.Text = "Создайте заметку";
                            main.NoteTextBox.Text = "";
                        }

                    }
                }

                System.IO.StreamWriter settings = new System.IO.StreamWriter("settings\\flowdirection.txt");
                settings.WriteLine(main.flowLayoutPanel1.FlowDirection);
                settings.Close();

                System.IO.StreamWriter fd_radio = new System.IO.StreamWriter("settings\\fd_radio.txt");
                if (BottomUpRadio.Checked == true)
                {
                    fd_radio.WriteLine("BottomUpRadio");
                }
                if (TopDownRadio.Checked == true)
                {
                    fd_radio.WriteLine("TopDownRadio");
                }
                fd_radio.Close();

            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            using (System.IO.StreamReader settings_main = new System.IO.StreamReader("settings\\fd_radio.txt"))
            {
                string fd_radio;
                while ((fd_radio = settings_main.ReadLine()) != null)
                {
                    if (fd_radio == "TopDownRadio")
                    {
                        TopDownRadio.Checked = true;
                    }
                    if (fd_radio == "BottomUpRadio")
                    {
                        BottomUpRadio.Checked = true;
                    }

                }
            }
        }
    }
}
