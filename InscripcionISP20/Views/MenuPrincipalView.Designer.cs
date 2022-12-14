namespace Desktop
{
    partial class MenuPrincipalView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            this.añoCarreraToolStripMenuItem = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem5 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem6 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem7 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem4 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem8 = new FontAwesome.Sharp.IconMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconMenuItem1,
            this.iconMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconMenuItem2,
            this.añoCarreraToolStripMenuItem,
            this.iconMenuItem5,
            this.iconMenuItem6,
            this.iconMenuItem7,
            this.iconMenuItem8});
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.HouseChimney;
            this.iconMenuItem1.IconColor = System.Drawing.Color.Crimson;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.IconSize = 20;
            this.iconMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(85, 24);
            this.iconMenuItem1.Text = "Principal";
            // 
            // iconMenuItem2
            // 
            this.iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.GraduationCap;
            this.iconMenuItem2.IconColor = System.Drawing.Color.Brown;
            this.iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem2.IconSize = 20;
            this.iconMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem2.Name = "iconMenuItem2";
            this.iconMenuItem2.Size = new System.Drawing.Size(184, 26);
            this.iconMenuItem2.Text = "Carreras";
            this.iconMenuItem2.Click += new System.EventHandler(this.iconMenuItem2_Click);
            // 
            // añoCarreraToolStripMenuItem
            // 
            this.añoCarreraToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            this.añoCarreraToolStripMenuItem.IconColor = System.Drawing.Color.Black;
            this.añoCarreraToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.añoCarreraToolStripMenuItem.Name = "añoCarreraToolStripMenuItem";
            this.añoCarreraToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.añoCarreraToolStripMenuItem.Text = "Año Carrera";
            this.añoCarreraToolStripMenuItem.Click += new System.EventHandler(this.añoCarreraToolStripMenuItem_Click);
            // 
            // iconMenuItem5
            // 
            this.iconMenuItem5.IconChar = FontAwesome.Sharp.IconChar.School;
            this.iconMenuItem5.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem5.IconSize = 20;
            this.iconMenuItem5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem5.Name = "iconMenuItem5";
            this.iconMenuItem5.Size = new System.Drawing.Size(184, 26);
            this.iconMenuItem5.Text = "Materias";
            this.iconMenuItem5.Click += new System.EventHandler(this.iconMenuItem5_Click);
            // 
            // iconMenuItem6
            // 
            this.iconMenuItem6.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem6.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem6.Name = "iconMenuItem6";
            this.iconMenuItem6.Size = new System.Drawing.Size(184, 26);
            this.iconMenuItem6.Text = "Ciclo Lectivo";
            this.iconMenuItem6.Click += new System.EventHandler(this.iconMenuItem6_Click);
            // 
            // iconMenuItem7
            // 
            this.iconMenuItem7.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.iconMenuItem7.IconColor = System.Drawing.Color.IndianRed;
            this.iconMenuItem7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem7.IconSize = 20;
            this.iconMenuItem7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem7.Name = "iconMenuItem7";
            this.iconMenuItem7.Size = new System.Drawing.Size(184, 26);
            this.iconMenuItem7.Text = "Alumnos";
            this.iconMenuItem7.Click += new System.EventHandler(this.iconMenuItem7_Click);
            // 
            // iconMenuItem3
            // 
            this.iconMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconMenuItem4});
            this.iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            this.iconMenuItem3.IconColor = System.Drawing.Color.Crimson;
            this.iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem3.Name = "iconMenuItem3";
            this.iconMenuItem3.Size = new System.Drawing.Size(57, 24);
            this.iconMenuItem3.Text = "Salir";
            // 
            // iconMenuItem4
            // 
            this.iconMenuItem4.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.iconMenuItem4.IconColor = System.Drawing.Color.Brown;
            this.iconMenuItem4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem4.IconSize = 20;
            this.iconMenuItem4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem4.Name = "iconMenuItem4";
            this.iconMenuItem4.Size = new System.Drawing.Size(162, 26);
            this.iconMenuItem4.Text = "Salir del sistema";
            this.iconMenuItem4.Click += new System.EventHandler(this.iconMenuItem4_Click);
            // 
            // iconMenuItem8
            // 
            this.iconMenuItem8.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem8.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem8.Name = "iconMenuItem8";
            this.iconMenuItem8.Size = new System.Drawing.Size(184, 26);
            this.iconMenuItem8.Text = "Inscripcion";
            this.iconMenuItem8.Click += new System.EventHandler(this.iconMenuItem8_Click);
            // 
            // MenuPrincipalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipalView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscripción ISP20";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem4;
        private FontAwesome.Sharp.IconMenuItem añoCarreraToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem5;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem6;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem7;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem8;
    }
}
