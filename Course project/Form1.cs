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

        int colbutton = 0;
        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            //Получаем ссылку на кнопку, на которую нажали
            Button oldbutton = (Button)sender;
            //Создаем новую кнопку
            Button newbutton = new Button();
            //Меняем текст на новой кнопке
            newbutton.Text = "Кнопка №" + colbutton;
            newbutton.Height = 60;
            newbutton.Location = new Point(0, 60*colbutton);

            //oldbutton.Height * (colbutton) + 10
            newbutton.Width = 100;

            //Размещаем ее ниже (на 10px) кнопки, на которую мы нажали

            //Добавляем событие нажатия на новую кнопку 
            //(то же что и при нажатии на исходную)
            //newbutton.Click += new EventHandler(metroButton1_Click_1);
            //Добавляем элемент на форму
            this.Controls.Add(newbutton);
            colbutton++;
           
        }

        List<Button> btn = new List<Button>();
        int x = 0;
        int y = 0;
        private void metroButton1_Click(object sender, EventArgs e)
        {
            Button oldbutton = (Button)sender;
            flowLayoutPanel1.AutoScroll = true;
            Button newbtn = new Button();
            btn.Add(newbtn);
            newbtn.Width = flowLayoutPanel1.Width-25;
            newbtn.Height = 60;
            newbtn.FlatStyle = FlatStyle.Flat;
            newbtn.BackColor = Color.FromArgb(34, 34, 34);
            newbtn.FlatAppearance.BorderColor = Color.FromArgb(68, 68, 68);
            //newbtn.FlatAppearance.BorderSize = 1;
            //newbtn.Met
            newbtn.Text = "Button" + this.x.ToString();
            newbtn.Location = new Point(
            flowLayoutPanel1.AutoScrollPosition.X,
            flowLayoutPanel1.AutoScrollPosition.Y + (y + 6));
            y += 35;
            newbtn.Click += new EventHandler(dynamic_button_click);

            newbtn.Tag = x;
            flowLayoutPanel1.Controls.Add(newbtn);

            
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
    }
}
