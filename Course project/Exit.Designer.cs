namespace Course_project
{
    partial class Exit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exit));
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.Yes = new MetroFramework.Controls.MetroButton();
            this.No = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Yes
            // 
            this.Yes.Location = new System.Drawing.Point(39, 73);
            this.Yes.Name = "Yes";
            this.Yes.Size = new System.Drawing.Size(75, 23);
            this.Yes.TabIndex = 0;
            this.Yes.Text = "Да";
            this.Yes.Click += new System.EventHandler(this.Yes_Click);
            // 
            // No
            // 
            this.No.Location = new System.Drawing.Point(141, 73);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(75, 23);
            this.No.TabIndex = 1;
            this.No.Text = "Нет";
            this.No.Click += new System.EventHandler(this.No_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 30);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(213, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Вы действительно хотите выйти? ";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseStyleColors = true;
            // 
            // Exit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 118);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.No);
            this.Controls.Add(this.Yes);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "Exit";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "Выход";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Exit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroButton No;
        private MetroFramework.Controls.MetroButton Yes;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}