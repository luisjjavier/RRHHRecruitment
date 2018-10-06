namespace RRHHRecruitment.Forms.Screens
{
    partial class CreateTrainingForm
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
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.txtInstitution = new MetroFramework.Controls.MetroTextBox();
            this.txtDescription = new MetroFramework.Controls.MetroTextBox();
            this.cbAcademicLevel = new MetroFramework.Controls.MetroComboBox();
            this.fromDate = new MetroFramework.Controls.MetroDateTime();
            this.toDate = new MetroFramework.Controls.MetroDateTime();
            this.traningErrorProvaider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.traningErrorProvaider)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(81, 96);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(64, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Intitución:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(69, 128);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(76, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Descripción";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(39, 171);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(106, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Nivel acedemico";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(54, 218);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(95, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Desde cuando:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(54, 266);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(91, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Hasta cuando:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(302, 333);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(206, 333);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtInstitution
            // 
            // 
            // 
            // 
            this.txtInstitution.CustomButton.Image = null;
            this.txtInstitution.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtInstitution.CustomButton.Name = "";
            this.txtInstitution.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInstitution.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInstitution.CustomButton.TabIndex = 1;
            this.txtInstitution.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInstitution.CustomButton.UseSelectable = true;
            this.txtInstitution.CustomButton.Visible = false;
            this.txtInstitution.Lines = new string[0];
            this.txtInstitution.Location = new System.Drawing.Point(177, 92);
            this.txtInstitution.MaxLength = 32767;
            this.txtInstitution.Name = "txtInstitution";
            this.txtInstitution.PasswordChar = '\0';
            this.txtInstitution.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInstitution.SelectedText = "";
            this.txtInstitution.SelectionLength = 0;
            this.txtInstitution.SelectionStart = 0;
            this.txtInstitution.ShortcutsEnabled = true;
            this.txtInstitution.Size = new System.Drawing.Size(200, 23);
            this.txtInstitution.TabIndex = 7;
            this.txtInstitution.UseSelectable = true;
            this.txtInstitution.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInstitution.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDescription
            // 
            // 
            // 
            // 
            this.txtDescription.CustomButton.Image = null;
            this.txtDescription.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtDescription.CustomButton.Name = "";
            this.txtDescription.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescription.CustomButton.TabIndex = 1;
            this.txtDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescription.CustomButton.UseSelectable = true;
            this.txtDescription.CustomButton.Visible = false;
            this.txtDescription.Lines = new string[0];
            this.txtDescription.Location = new System.Drawing.Point(177, 128);
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescription.SelectedText = "";
            this.txtDescription.SelectionLength = 0;
            this.txtDescription.SelectionStart = 0;
            this.txtDescription.ShortcutsEnabled = true;
            this.txtDescription.Size = new System.Drawing.Size(200, 23);
            this.txtDescription.TabIndex = 8;
            this.txtDescription.UseSelectable = true;
            this.txtDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbAcademicLevel
            // 
            this.cbAcademicLevel.FormattingEnabled = true;
            this.cbAcademicLevel.ItemHeight = 23;
            this.cbAcademicLevel.Location = new System.Drawing.Point(177, 171);
            this.cbAcademicLevel.Name = "cbAcademicLevel";
            this.cbAcademicLevel.Size = new System.Drawing.Size(200, 29);
            this.cbAcademicLevel.TabIndex = 9;
            this.cbAcademicLevel.UseSelectable = true;
            // 
            // fromDate
            // 
            this.fromDate.Location = new System.Drawing.Point(177, 218);
            this.fromDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(200, 29);
            this.fromDate.TabIndex = 10;
            // 
            // toDate
            // 
            this.toDate.Location = new System.Drawing.Point(177, 264);
            this.toDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(200, 29);
            this.toDate.TabIndex = 11;
            // 
            // traningErrorProvaider
            // 
            this.traningErrorProvaider.ContainerControl = this;
            // 
            // CreateTrainingForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(414, 389);
            this.ControlBox = false;
            this.Controls.Add(this.toDate);
            this.Controls.Add(this.fromDate);
            this.Controls.Add(this.cbAcademicLevel);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtInstitution);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "CreateTrainingForm";
            this.Text = "Creación de capacitaciones";
            this.Load += new System.EventHandler(this.CreateTrainingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.traningErrorProvaider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroTextBox txtInstitution;
        private MetroFramework.Controls.MetroTextBox txtDescription;
        private MetroFramework.Controls.MetroComboBox cbAcademicLevel;
        private MetroFramework.Controls.MetroDateTime fromDate;
        private MetroFramework.Controls.MetroDateTime toDate;
        private System.Windows.Forms.ErrorProvider traningErrorProvaider;
    }
}