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

        private void TopDownRadio_CheckedChanged(object sender, EventArgs e)
        {
            {
                //BottomUpRadio.Checked = false;
                Form1 main = this.Owner as Form1;
                if (main != null)
                {
                    main.flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
                }

            }
        }

        private void BottomUpRadio_CheckedChanged(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                main.flowLayoutPanel1.FlowDirection = FlowDirection.BottomUp;
            }
        }
    }
}
