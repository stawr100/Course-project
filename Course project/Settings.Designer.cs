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
            this.metroTrackBar1 = new MetroFramework.Controls.MetroTrackBar();
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
            this.BottomUpRadio.Location = new System.Drawing.Point(30, 97);
            this.BottomUpRadio.Name = "BottomUpRadio";
            this.BottomUpRadio.Size = new System.Drawing.Size(111, 15);
            this.BottomUpRadio.Style = MetroFramework.MetroColorStyle.Yellow;
            this.BottomUpRadio.TabIndex = 2;
            this.BottomUpRadio.TabStop = true;
            this.BottomUpRadio.Text = "Новые в начале";
            this.BottomUpRadio.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BottomUpRadio.UseStyleColors = true;
            this.BottomUpRadio.UseVisualStyleBackColor = true;
            this.BottomUpRadio.CheckedChanged += new System.EventHandler(this.BottomUpRadio_CheckedChanged);
            // 
            // TopDownRadio
            // 
            this.TopDownRadio.AutoSize = true;
            this.TopDownRadio.Location = new System.Drawing.Point(175, 97);
            this.TopDownRadio.Name = "TopDownRadio";
            this.TopDownRadio.Size = new System.Drawing.Size(105, 15);
            this.TopDownRadio.Style = MetroFramework.MetroColorStyle.Yellow;
            this.TopDownRadio.TabIndex = 3;
            this.TopDownRadio.Text = "Новые в конце";
            this.TopDownRadio.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopDownRadio.UseStyleColors = true;
            this.TopDownRadio.UseVisualStyleBackColor = true;
            this.TopDownRadio.CheckedChanged += new System.EventHandler(this.TopDownRadio_CheckedChanged);
            // 
            // metroTrackBar1
            // 
            this.metroTrackBar1.BackColor = System.Drawing.Color.Transparent;
            this.metroTrackBar1.Location = new System.Drawing.Point(74, 259);
            this.metroTrackBar1.Maximum = 50;
            this.metroTrackBar1.Name = "metroTrackBar1";
            this.metroTrackBar1.Size = new System.Drawing.Size(75, 23);
            this.metroTrackBar1.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTrackBar1.TabIndex = 4;
            this.metroTrackBar1.Text = "metroTrackBar1";
            this.metroTrackBar1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTrackBar1.Value = 0;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 363);
            this.Controls.Add(this.metroTrackBar1);
            this.Controls.Add(this.TopDownRadio);
            this.Controls.Add(this.BottomUpRadio);
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
        private MetroFramework.Controls.MetroTrackBar metroTrackBar1;
    }
}