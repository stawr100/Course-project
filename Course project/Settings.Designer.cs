namespace Course_project
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.BottomUpRadio = new MetroFramework.Controls.MetroRadioButton();
            this.TopDownRadio = new MetroFramework.Controls.MetroRadioButton();
            this.DeleteAllTrackBar = new MetroFramework.Controls.MetroTrackBar();
            this.apply_settings = new MetroFramework.Controls.MetroButton();
            this.ok_button = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.RU_radio = new MetroFramework.Controls.MetroRadioButton();
            this.EN_radio = new MetroFramework.Controls.MetroRadioButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(23, 30);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(96, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Настройки";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 69);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(118, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Порядок заметок:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // BottomUpRadio
            // 
            this.BottomUpRadio.AutoSize = true;
            this.BottomUpRadio.Checked = true;
            this.BottomUpRadio.Location = new System.Drawing.Point(3, 3);
            this.BottomUpRadio.Name = "BottomUpRadio";
            this.BottomUpRadio.Size = new System.Drawing.Size(111, 15);
            this.BottomUpRadio.Style = MetroFramework.MetroColorStyle.Yellow;
            this.BottomUpRadio.TabIndex = 2;
            this.BottomUpRadio.TabStop = true;
            this.BottomUpRadio.Text = "Новые в начале";
            this.BottomUpRadio.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BottomUpRadio.UseStyleColors = true;
            this.BottomUpRadio.UseVisualStyleBackColor = true;
            // 
            // TopDownRadio
            // 
            this.TopDownRadio.AutoSize = true;
            this.TopDownRadio.Location = new System.Drawing.Point(132, 3);
            this.TopDownRadio.Name = "TopDownRadio";
            this.TopDownRadio.Size = new System.Drawing.Size(105, 15);
            this.TopDownRadio.Style = MetroFramework.MetroColorStyle.Yellow;
            this.TopDownRadio.TabIndex = 3;
            this.TopDownRadio.Text = "Новые в конце";
            this.TopDownRadio.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopDownRadio.UseStyleColors = true;
            this.TopDownRadio.UseVisualStyleBackColor = true;
            // 
            // DeleteAllTrackBar
            // 
            this.DeleteAllTrackBar.BackColor = System.Drawing.Color.Transparent;
            this.DeleteAllTrackBar.Location = new System.Drawing.Point(30, 290);
            this.DeleteAllTrackBar.Maximum = 50;
            this.DeleteAllTrackBar.Name = "DeleteAllTrackBar";
            this.DeleteAllTrackBar.Size = new System.Drawing.Size(176, 23);
            this.DeleteAllTrackBar.Style = MetroFramework.MetroColorStyle.Yellow;
            this.DeleteAllTrackBar.TabIndex = 4;
            this.DeleteAllTrackBar.Text = "metroTrackBar1";
            this.DeleteAllTrackBar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroToolTip1.SetToolTip(this.DeleteAllTrackBar, "Для удаления всех заметок, переместите ползунок в конец\r\n");
            this.DeleteAllTrackBar.Value = 0;
            
            // 
            // apply_settings
            // 
            this.apply_settings.Location = new System.Drawing.Point(242, 327);
            this.apply_settings.Name = "apply_settings";
            this.apply_settings.Size = new System.Drawing.Size(83, 23);
            this.apply_settings.Style = MetroFramework.MetroColorStyle.Yellow;
            this.apply_settings.TabIndex = 5;
            this.apply_settings.Text = "Применить";
            this.apply_settings.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.apply_settings.Click += new System.EventHandler(this.apply_settings_Click);
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(175, 327);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(61, 23);
            this.ok_button.Style = MetroFramework.MetroColorStyle.Yellow;
            this.ok_button.TabIndex = 6;
            this.ok_button.Text = "Ок";
            this.ok_button.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 266);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(136, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Удалить все заметки:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroToolTip1.SetToolTip(this.metroLabel3, "Для удаления всех заметок, переместите ползунок в конец\r\n");
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 126);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(118, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Язык интерфейса:";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // RU_radio
            // 
            this.RU_radio.AutoSize = true;
            this.RU_radio.Checked = true;
            this.RU_radio.Location = new System.Drawing.Point(30, 148);
            this.RU_radio.Name = "RU_radio";
            this.RU_radio.Size = new System.Drawing.Size(68, 15);
            this.RU_radio.Style = MetroFramework.MetroColorStyle.Yellow;
            this.RU_radio.TabIndex = 9;
            this.RU_radio.TabStop = true;
            this.RU_radio.Text = "Русский";
            this.RU_radio.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.RU_radio.UseStyleColors = true;
            this.RU_radio.UseVisualStyleBackColor = true;
            // 
            // EN_radio
            // 
            this.EN_radio.AutoSize = true;
            this.EN_radio.Location = new System.Drawing.Point(154, 148);
            this.EN_radio.Name = "EN_radio";
            this.EN_radio.Size = new System.Drawing.Size(61, 15);
            this.EN_radio.Style = MetroFramework.MetroColorStyle.Yellow;
            this.EN_radio.TabIndex = 10;
            this.EN_radio.Text = "English";
            this.EN_radio.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.EN_radio.UseStyleColors = true;
            this.EN_radio.UseVisualStyleBackColor = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(26, 91);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(267, 32);
            this.metroPanel1.TabIndex = 11;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 363);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.RU_radio);
            this.Controls.Add(this.EN_radio);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.apply_settings);
            this.Controls.Add(this.DeleteAllTrackBar);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "Settings";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroRadioButton BottomUpRadio;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroRadioButton TopDownRadio;
        private MetroFramework.Controls.MetroTrackBar DeleteAllTrackBar;
        private MetroFramework.Controls.MetroButton ok_button;
        private MetroFramework.Controls.MetroButton apply_settings;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MetroFramework.Controls.MetroRadioButton EN_radio;
        private MetroFramework.Controls.MetroRadioButton RU_radio;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        public MetroFramework.Controls.MetroPanel metroPanel1;
    }
}