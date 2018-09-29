namespace RRHHRecruitment.Forms.Screens
{
    partial class MainForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.gestionDeIdiomasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.UsernameToolStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.RoleToolStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.gestionDePuestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDeIdiomasToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.gestionDePuestosToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(20, 60);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1121, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // gestionDeIdiomasToolStripMenuItem
            // 
            this.gestionDeIdiomasToolStripMenuItem.Name = "gestionDeIdiomasToolStripMenuItem";
            this.gestionDeIdiomasToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.gestionDeIdiomasToolStripMenuItem.Text = "&Gestion de idiomas";
            this.gestionDeIdiomasToolStripMenuItem.Click += new System.EventHandler(this.gestionDeIdiomasToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UsernameToolStrip,
            this.RoleToolStrip});
            this.statusStrip.Location = new System.Drawing.Point(20, 676);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1121, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // UsernameToolStrip
            // 
            this.UsernameToolStrip.Name = "UsernameToolStrip";
            this.UsernameToolStrip.Size = new System.Drawing.Size(30, 17);
            this.UsernameToolStrip.Text = "Role";
            // 
            // RoleToolStrip
            // 
            this.RoleToolStrip.Name = "RoleToolStrip";
            this.RoleToolStrip.Size = new System.Drawing.Size(30, 17);
            this.RoleToolStrip.Text = "Role";
            // 
            // gestionDePuestosToolStripMenuItem
            // 
            this.gestionDePuestosToolStripMenuItem.Name = "gestionDePuestosToolStripMenuItem";
            this.gestionDePuestosToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.gestionDePuestosToolStripMenuItem.Text = "Gestion de puestos";
            this.gestionDePuestosToolStripMenuItem.Click += new System.EventHandler(this.gestionDePuestosToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 718);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Sistema de reclutamiento";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel UsernameToolStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem gestionDeIdiomasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel RoleToolStrip;
        private System.Windows.Forms.ToolStripMenuItem gestionDePuestosToolStripMenuItem;
    }
}



