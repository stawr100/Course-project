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
    public partial class About : MetroFramework.Forms.MetroForm
    {
        public About()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
        }

        private void About_Load(object sender, EventArgs e)
        {
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
                metroLabel1.Text = "Разработал Глушко Евгений";
                metroLabel2.Text = "БГУИР 2016";
                this.Text = "О программе";

            }
            if (lan == 0)
            {
                metroLabel1.Text = "Developed by Evgeni Glushko";
                metroLabel2.Text = "BSUIR 2016";
                this.Text = "About";
            }
        }
    }
}
