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
            metroPanel1.Controls.Add(BottomUpRadio);
            metroPanel1.Controls.Add(TopDownRadio);

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
                if (EN_radio.Checked == true)
                {
                    metroLabel1.Text = "Settings";
                    metroLabel2.Text = "Direction notes:";
                    BottomUpRadio.Text = "New first";
                    TopDownRadio.Text = "New last";
                    metroLabel4.Text = "Interface language:";
                    metroLabel3.Text = "Delete all notes";
                    apply_settings.Text = "Apply";
                    ok_button.Text = "Ok";
                    main.metroButton1.Text = "Add note";
                    main.DeleteNote.Text = "Delete the note";
                    main.SaveAll.Text = "Save all";
                    main.settings.Text = "Settings";
                    main.ExitNotes.Text = "Exit";
                    if (main.textBox1.Text == "Создайте заметку")
                    {
                        main.textBox1.Text = "Create a note";
                    }
                    
                    main.SaveNote.Text = "Save";
                    
                }
                if(RU_radio.Checked == true)
                {
                    metroLabel1.Text = "Настройки";
                    metroLabel2.Text = "Порядок заметок:";
                    BottomUpRadio.Text = "Новые в начале";
                    TopDownRadio.Text = "Новые в конце";
                    metroLabel4.Text = "Язык интерфейса:";
                    metroLabel3.Text = "Удалить все заметки";
                    apply_settings.Text = "Применить";
                    ok_button.Text = "Ок";
                    main.metroButton1.Text = "Добавить заметку";
                    main.DeleteNote.Text = "Удалить заметку";
                    main.SaveAll.Text = "Сохранить все";
                    main.settings.Text = "Настройки";
                    main.ExitNotes.Text = "Выход";
                    if (main.textBox1.Text == "Create a note")
                    {
                        main.textBox1.Text = "Cоздайте заметку";
                    }                    
                    main.SaveNote.Text = "Сохранить";
                }

                System.IO.StreamWriter settings = new System.IO.StreamWriter("settings\\flowdirection.txt");
                settings.WriteLine(main.flowLayoutPanel1.FlowDirection);
                settings.Close();

                System.IO.StreamWriter language_state = new System.IO.StreamWriter("settings\\language_state.txt");
                if (EN_radio.Checked == true)
                {
                    language_state.WriteLine("EN");
                }
                if (RU_radio.Checked == true)
                {
                    language_state.WriteLine("RU");
                }
                language_state.Close();

                
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            using (System.IO.StreamReader fd_radio_settings = new System.IO.StreamReader("settings\\flowdirection.txt"))
            {
                string fd_radio;
                while ((fd_radio = fd_radio_settings.ReadLine()) != null)
                {
                    if (fd_radio == "TopDown")
                    {
                        TopDownRadio.Checked = true;
                    }
                    if (fd_radio == "BottomUp")
                    {
                        BottomUpRadio.Checked = true;
                    }

                }
            }

            int lan = 0;
            using (System.IO.StreamReader language_state = new System.IO.StreamReader("settings\\language_state.txt"))
            {
                string la_state;
                while ((la_state = language_state.ReadLine()) != null)
                {
                    if (la_state == "RU")
                    {
                        RU_radio.Checked = true;
                        lan = 1;
                    }
                    if (la_state == "EN")
                    {
                        EN_radio.Checked = true;
                        lan = 0;
                    }

                }
            }

            if (lan == 1)
            {
                metroLabel1.Text = "Настройки";
                metroLabel2.Text = "Порядок заметок:";
                BottomUpRadio.Text = "Новые в начале";
                TopDownRadio.Text = "Новые в конце";
                metroLabel4.Text = "Язык интерфейса:";
                metroLabel3.Text = "Удалить все заметки";
                apply_settings.Text = "Применить";
                ok_button.Text = "Ок";
            }
            if (lan == 0)
            {
                metroLabel1.Text = "Settings";
                metroLabel2.Text = "Direction notes:";
                BottomUpRadio.Text = "New first";
                TopDownRadio.Text = "New last";
                metroLabel4.Text = "Interface language:";
                metroLabel3.Text = "Delete all notes";
                apply_settings.Text = "Apply";
                ok_button.Text = "Ok";
            }
        }

        
        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            float i = Int32.Parse(metroComboBox1.Text);
            //textBox1.Font = new Font(FontFamily.GenericSansSerif, i, FontStyle.Bold, FontStyle.Italic);

        }

        

    }
}
