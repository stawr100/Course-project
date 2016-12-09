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
    public partial class Exit : MetroFramework.Forms.MetroForm
    {
        public Exit()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void No_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Exit_Load(object sender, EventArgs e)
        {
            //Form1 main = this.Owner as Form1;
            int lan = 0;
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
                metroLabel1.Text = "Вы действительно хотите выйти?";
                Yes.Text = "Да";
                No.Text = "Нет";
                this.Text = "Выход";

            }
            if (lan == 0)
            {
                metroLabel1.Text = "Are you sure?";
                Yes.Text = "Yes";
                No.Text = "No";
                this.Text = "Exit";

            }

        }

        private void Yes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
