namespace Course_project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitNotes = new MetroFramework.Controls.MetroButton();
            this.DeleteNote = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.metroScrollBar1 = new MetroFramework.Controls.MetroScrollBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SaveNote = new MetroFramework.Controls.MetroButton();
            this.SaveAll = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SaveAll);
            this.panel1.Controls.Add(this.ExitNotes);
            this.panel1.Controls.Add(this.DeleteNote);
            this.panel1.Controls.Add(this.metroButton1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(20, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 380);
            this.panel1.TabIndex = 13;
            // 
            // ExitNotes
            // 
            this.ExitNotes.Location = new System.Drawing.Point(51, 238);
            this.ExitNotes.Name = "ExitNotes";
            this.ExitNotes.Size = new System.Drawing.Size(140, 40);
            this.ExitNotes.Style = MetroFramework.MetroColorStyle.Orange;
            this.ExitNotes.TabIndex = 15;
            this.ExitNotes.Text = "Выход";
            this.ExitNotes.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ExitNotes.Click += new System.EventHandler(this.ExitNotes_Click);
            // 
            // DeleteNote
            // 
            this.DeleteNote.Location = new System.Drawing.Point(51, 146);
            this.DeleteNote.Name = "DeleteNote";
            this.DeleteNote.Size = new System.Drawing.Size(140, 40);
            this.DeleteNote.Style = MetroFramework.MetroColorStyle.Orange;
            this.DeleteNote.TabIndex = 14;
            this.DeleteNote.Text = "Удалить заметку";
            this.DeleteNote.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.DeleteNote.Click += new System.EventHandler(this.DeleteNote_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(51, 100);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(140, 40);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButton1.TabIndex = 13;
            this.metroButton1.Text = "Добавить заметку";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(285, 380);
            this.flowLayoutPanel1.TabIndex = 14;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // metroScrollBar1
            // 
            this.metroScrollBar1.HighlightOnWheel = true;
            this.metroScrollBar1.Location = new System.Drawing.Point(3, 3);
            this.metroScrollBar1.Name = "metroScrollBar1";
            this.metroScrollBar1.Orientation = MetroFramework.Controls.MetroScrollOrientation.Vertical;
            this.metroScrollBar1.Size = new System.Drawing.Size(10, 380);
            this.metroScrollBar1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroScrollBar1.TabIndex = 0;
            this.metroScrollBar1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroScrollBar1.UseBarColor = true;
            this.metroScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.metroScrollBar1_Scroll);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(264, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 380);
            this.panel2.TabIndex = 15;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.textBox1);
            this.metroPanel1.Controls.Add(this.SaveNote);
            this.metroPanel1.Controls.Add(this.metroScrollBar1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(539, 30);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(395, 380);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroPanel1.TabIndex = 16;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.textBox1.Location = new System.Drawing.Point(32, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "хуй";
            // 
            // SaveNote
            // 
            this.SaveNote.Location = new System.Drawing.Point(32, 315);
            this.SaveNote.Name = "SaveNote";
            this.SaveNote.Size = new System.Drawing.Size(343, 43);
            this.SaveNote.Style = MetroFramework.MetroColorStyle.Orange;
            this.SaveNote.TabIndex = 3;
            this.SaveNote.Text = "Сохранить";
            this.SaveNote.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SaveNote.Click += new System.EventHandler(this.SaveNote_Click);
            // 
            // SaveAll
            // 
            this.SaveAll.Location = new System.Drawing.Point(51, 192);
            this.SaveAll.Name = "SaveAll";
            this.SaveAll.Size = new System.Drawing.Size(140, 40);
            this.SaveAll.TabIndex = 16;
            this.SaveAll.Text = "Сохранить все";
            this.SaveAll.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SaveAll.Click += new System.EventHandler(this.SaveAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(954, 430);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DisplayHeader = false;
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(840, 430);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Заметки";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroScrollBar metroScrollBar1;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroButton DeleteNote;
        private MetroFramework.Controls.MetroButton ExitNotes;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton SaveNote;
        private System.Windows.Forms.TextBox textBox1;
        private MetroFramework.Controls.MetroButton SaveAll;
    }
}

