namespace RRHHRecruitment.Forms.Screens
{
    partial class CreateJobsForm
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.nameTxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.cbRiskLevel = new MetroFramework.Controls.MetroComboBox();
            this.txtMinSalary = new MetroFramework.Controls.MetroTextBox();
            this.txtMaxSalary = new MetroFramework.Controls.MetroTextBox();
            this.jobsErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.jobsErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(62, 100);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Nombre:";
            // 
            // nameTxt
            // 
            // 
            // 
            // 
            this.nameTxt.CustomButton.Image = null;
            this.nameTxt.CustomButton.Location = new System.Drawing.Point(160, 1);
            this.nameTxt.CustomButton.Name = "";
            this.nameTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nameTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nameTxt.CustomButton.TabIndex = 1;
            this.nameTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nameTxt.CustomButton.UseSelectable = true;
            this.nameTxt.CustomButton.Visible = false;
            this.nameTxt.Lines = new string[0];
            this.nameTxt.Location = new System.Drawing.Point(146, 96);
            this.nameTxt.MaxLength = 32767;
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.PasswordChar = '\0';
            this.nameTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameTxt.SelectedText = "";
            this.nameTxt.SelectionLength = 0;
            this.nameTxt.SelectionStart = 0;
            this.nameTxt.ShortcutsEnabled = true;
            this.nameTxt.Size = new System.Drawing.Size(182, 23);
            this.nameTxt.TabIndex = 1;
            this.nameTxt.UseSelectable = true;
            this.nameTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nameTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(27, 125);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(100, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Nivel de riesgo:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(26, 160);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(101, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Salario minimo:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 187);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(104, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Salario maximo:";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(219, 222);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(109, 62);
            this.metroButton1.TabIndex = 8;
            this.metroButton1.Text = "Guardar";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(82, 222);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(109, 62);
            this.metroButton2.TabIndex = 9;
            this.metroButton2.Text = "Cancelar";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // cbRiskLevel
            // 
            this.cbRiskLevel.FormattingEnabled = true;
            this.cbRiskLevel.ItemHeight = 23;
            this.cbRiskLevel.Location = new System.Drawing.Point(146, 125);
            this.cbRiskLevel.Name = "cbRiskLevel";
            this.cbRiskLevel.Size = new System.Drawing.Size(181, 29);
            this.cbRiskLevel.TabIndex = 10;
            this.cbRiskLevel.UseSelectable = true;
            // 
            // txtMinSalary
            // 
            // 
            // 
            // 
            this.txtMinSalary.CustomButton.Image = null;
            this.txtMinSalary.CustomButton.Location = new System.Drawing.Point(160, 1);
            this.txtMinSalary.CustomButton.Name = "";
            this.txtMinSalary.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMinSalary.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMinSalary.CustomButton.TabIndex = 1;
            this.txtMinSalary.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMinSalary.CustomButton.UseSelectable = true;
            this.txtMinSalary.CustomButton.Visible = false;
            this.txtMinSalary.Lines = new string[0];
            this.txtMinSalary.Location = new System.Drawing.Point(146, 160);
            this.txtMinSalary.MaxLength = 32767;
            this.txtMinSalary.Name = "txtMinSalary";
            this.txtMinSalary.PasswordChar = '\0';
            this.txtMinSalary.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMinSalary.SelectedText = "";
            this.txtMinSalary.SelectionLength = 0;
            this.txtMinSalary.SelectionStart = 0;
            this.txtMinSalary.ShortcutsEnabled = true;
            this.txtMinSalary.Size = new System.Drawing.Size(182, 23);
            this.txtMinSalary.TabIndex = 11;
            this.txtMinSalary.UseSelectable = true;
            this.txtMinSalary.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMinSalary.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtMinSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox2_KeyPress);
            this.txtMinSalary.Leave += new System.EventHandler(this.metroTextBox2_Leave);
            // 
            // txtMaxSalary
            // 
            // 
            // 
            // 
            this.txtMaxSalary.CustomButton.Image = null;
            this.txtMaxSalary.CustomButton.Location = new System.Drawing.Point(160, 1);
            this.txtMaxSalary.CustomButton.Name = "";
            this.txtMaxSalary.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMaxSalary.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMaxSalary.CustomButton.TabIndex = 1;
            this.txtMaxSalary.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMaxSalary.CustomButton.UseSelectable = true;
            this.txtMaxSalary.CustomButton.Visible = false;
            this.txtMaxSalary.Lines = new string[0];
            this.txtMaxSalary.Location = new System.Drawing.Point(146, 189);
            this.txtMaxSalary.MaxLength = 32767;
            this.txtMaxSalary.Name = "txtMaxSalary";
            this.txtMaxSalary.PasswordChar = '\0';
            this.txtMaxSalary.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMaxSalary.SelectedText = "";
            this.txtMaxSalary.SelectionLength = 0;
            this.txtMaxSalary.SelectionStart = 0;
            this.txtMaxSalary.ShortcutsEnabled = true;
            this.txtMaxSalary.Size = new System.Drawing.Size(182, 23);
            this.txtMaxSalary.TabIndex = 12;
            this.txtMaxSalary.UseSelectable = true;
            this.txtMaxSalary.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMaxSalary.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtMaxSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox2_KeyPress);
            this.txtMaxSalary.Leave += new System.EventHandler(this.metroTextBox3_Leave);
            // 
            // jobsErrorProvider
            // 
            this.jobsErrorProvider.ContainerControl = this;
            // 
            // CreateJobsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 307);
            this.Controls.Add(this.txtMaxSalary);
            this.Controls.Add(this.txtMinSalary);
            this.Controls.Add(this.cbRiskLevel);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.metroLabel1);
            this.Name = "CreateJobsForm";
            this.Text = "Creacion de puestos";
            this.Load += new System.EventHandler(this.CreateJobsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jobsErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox nameTxt;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroComboBox cbRiskLevel;
        private MetroFramework.Controls.MetroTextBox txtMinSalary;
        private MetroFramework.Controls.MetroTextBox txtMaxSalary;
        private System.Windows.Forms.ErrorProvider jobsErrorProvider;
    }
}