namespace RRHHRecruitment.Forms.Screens
{
    partial class CreateEmployeeForm
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
            this.txtIdentification = new MetroFramework.Controls.MetroTextBox();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.txtDeparment = new MetroFramework.Controls.MetroTextBox();
            this.txtSalary = new MetroFramework.Controls.MetroTextBox();
            this.cbJob = new MetroFramework.Controls.MetroComboBox();
            this.btnCreate = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.jobsErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.entryDate = new MetroFramework.Controls.MetroDateTime();
            ((System.ComponentModel.ISupportInitialize)(this.jobsErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.Coral;
            this.metroLabel1.Location = new System.Drawing.Point(55, 84);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Cedula:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.Color.Coral;
            this.metroLabel2.Location = new System.Drawing.Point(44, 119);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(62, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Nombre:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.ForeColor = System.Drawing.Color.Coral;
            this.metroLabel3.Location = new System.Drawing.Point(14, 154);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(94, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Departamento";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.ForeColor = System.Drawing.Color.Coral;
            this.metroLabel4.Location = new System.Drawing.Point(57, 186);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(51, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Puesto:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.ForeColor = System.Drawing.Color.Coral;
            this.metroLabel5.Location = new System.Drawing.Point(52, 245);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(49, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Salario";
            // 
            // txtIdentification
            // 
            // 
            // 
            // 
            this.txtIdentification.CustomButton.Image = null;
            this.txtIdentification.CustomButton.Location = new System.Drawing.Point(152, 1);
            this.txtIdentification.CustomButton.Name = "";
            this.txtIdentification.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIdentification.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIdentification.CustomButton.TabIndex = 1;
            this.txtIdentification.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIdentification.CustomButton.UseSelectable = true;
            this.txtIdentification.CustomButton.Visible = false;
            this.txtIdentification.Lines = new string[0];
            this.txtIdentification.Location = new System.Drawing.Point(142, 84);
            this.txtIdentification.MaxLength = 32767;
            this.txtIdentification.Name = "txtIdentification";
            this.txtIdentification.PasswordChar = '\0';
            this.txtIdentification.ReadOnly = true;
            this.txtIdentification.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIdentification.SelectedText = "";
            this.txtIdentification.SelectionLength = 0;
            this.txtIdentification.SelectionStart = 0;
            this.txtIdentification.ShortcutsEnabled = true;
            this.txtIdentification.Size = new System.Drawing.Size(174, 23);
            this.txtIdentification.TabIndex = 5;
            this.txtIdentification.UseSelectable = true;
            this.txtIdentification.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIdentification.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(152, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(142, 119);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ReadOnly = true;
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(174, 23);
            this.txtName.TabIndex = 6;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDeparment
            // 
            // 
            // 
            // 
            this.txtDeparment.CustomButton.Image = null;
            this.txtDeparment.CustomButton.Location = new System.Drawing.Point(152, 1);
            this.txtDeparment.CustomButton.Name = "";
            this.txtDeparment.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDeparment.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDeparment.CustomButton.TabIndex = 1;
            this.txtDeparment.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDeparment.CustomButton.UseSelectable = true;
            this.txtDeparment.CustomButton.Visible = false;
            this.txtDeparment.Lines = new string[0];
            this.txtDeparment.Location = new System.Drawing.Point(142, 148);
            this.txtDeparment.MaxLength = 32767;
            this.txtDeparment.Name = "txtDeparment";
            this.txtDeparment.PasswordChar = '\0';
            this.txtDeparment.ReadOnly = true;
            this.txtDeparment.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDeparment.SelectedText = "";
            this.txtDeparment.SelectionLength = 0;
            this.txtDeparment.SelectionStart = 0;
            this.txtDeparment.ShortcutsEnabled = true;
            this.txtDeparment.Size = new System.Drawing.Size(174, 23);
            this.txtDeparment.TabIndex = 7;
            this.txtDeparment.UseSelectable = true;
            this.txtDeparment.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDeparment.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSalary
            // 
            // 
            // 
            // 
            this.txtSalary.CustomButton.Image = null;
            this.txtSalary.CustomButton.Location = new System.Drawing.Point(152, 1);
            this.txtSalary.CustomButton.Name = "";
            this.txtSalary.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSalary.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSalary.CustomButton.TabIndex = 1;
            this.txtSalary.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSalary.CustomButton.UseSelectable = true;
            this.txtSalary.CustomButton.Visible = false;
            this.txtSalary.Lines = new string[0];
            this.txtSalary.Location = new System.Drawing.Point(142, 241);
            this.txtSalary.MaxLength = 32767;
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.PasswordChar = '\0';
            this.txtSalary.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSalary.SelectedText = "";
            this.txtSalary.SelectionLength = 0;
            this.txtSalary.SelectionStart = 0;
            this.txtSalary.ShortcutsEnabled = true;
            this.txtSalary.Size = new System.Drawing.Size(174, 23);
            this.txtSalary.TabIndex = 8;
            this.txtSalary.UseSelectable = true;
            this.txtSalary.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSalary.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalary_KeyPress);
            this.txtSalary.Leave += new System.EventHandler(this.txtSalary_Leave);
            // 
            // cbJob
            // 
            this.cbJob.FormattingEnabled = true;
            this.cbJob.ItemHeight = 23;
            this.cbJob.Location = new System.Drawing.Point(142, 177);
            this.cbJob.Name = "cbJob";
            this.cbJob.Size = new System.Drawing.Size(174, 29);
            this.cbJob.TabIndex = 9;
            this.cbJob.UseSelectable = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(241, 279);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 10;
            this.btnCreate.Text = "Guardar";
            this.btnCreate.UseSelectable = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(137, 279);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // jobsErrorProvider
            // 
            this.jobsErrorProvider.ContainerControl = this;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.ForeColor = System.Drawing.Color.Coral;
            this.metroLabel6.Location = new System.Drawing.Point(-6, 215);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(114, 19);
            this.metroLabel6.TabIndex = 12;
            this.metroLabel6.Text = "Fecha de entrada:";
            // 
            // entryDate
            // 
            this.entryDate.Location = new System.Drawing.Point(142, 206);
            this.entryDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.entryDate.Name = "entryDate";
            this.entryDate.Size = new System.Drawing.Size(174, 29);
            this.entryDate.TabIndex = 13;
            // 
            // CreateEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 344);
            this.Controls.Add(this.entryDate);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.cbJob);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtDeparment);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtIdentification);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Name = "CreateEmployeeForm";
            this.Text = "Creación de empleados";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.CreateEmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jobsErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtIdentification;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroTextBox txtDeparment;
        private MetroFramework.Controls.MetroTextBox txtSalary;
        private MetroFramework.Controls.MetroComboBox cbJob;
        private MetroFramework.Controls.MetroButton btnCreate;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private System.Windows.Forms.ErrorProvider jobsErrorProvider;
        private MetroFramework.Controls.MetroDateTime entryDate;
        private MetroFramework.Controls.MetroLabel metroLabel6;
    }
}