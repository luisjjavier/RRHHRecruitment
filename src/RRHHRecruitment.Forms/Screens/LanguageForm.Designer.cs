namespace RRHHRecruitment.Forms.Screens
{
    partial class LanguageForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.languageGrid = new MetroFramework.Controls.MetroGrid();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.languageName = new MetroFramework.Controls.MetroTextBox();
            this.chkIsActive = new MetroFramework.Controls.MetroCheckBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.languageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.languageGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.languageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // languageGrid
            // 
            this.languageGrid.AllowUserToAddRows = false;
            this.languageGrid.AllowUserToDeleteRows = false;
            this.languageGrid.AllowUserToResizeRows = false;
            this.languageGrid.AutoGenerateColumns = false;
            this.languageGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.languageGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.languageGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.languageGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.languageGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.languageGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn});
            this.languageGrid.DataSource = this.languageBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.languageGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.languageGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.languageGrid.EnableHeadersVisualStyles = false;
            this.languageGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.languageGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.languageGrid.Location = new System.Drawing.Point(20, 219);
            this.languageGrid.MultiSelect = false;
            this.languageGrid.Name = "languageGrid";
            this.languageGrid.ReadOnly = true;
            this.languageGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.languageGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.languageGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.languageGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.languageGrid.Size = new System.Drawing.Size(407, 312);
            this.languageGrid.TabIndex = 0;
            this.languageGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.languageGrid_CellClick);
            this.languageGrid.SelectionChanged += new System.EventHandler(this.languageGrid_SelectionChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(149, 158);
            this.btnSave.MaximumSize = new System.Drawing.Size(124, 23);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(303, 158);
            this.btnClear.MaximumSize = new System.Drawing.Size(124, 23);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(124, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(22, 84);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(137, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Nombre del lenguaje:";
            // 
            // languageName
            // 
            // 
            // 
            // 
            this.languageName.CustomButton.Image = null;
            this.languageName.CustomButton.Location = new System.Drawing.Point(130, 1);
            this.languageName.CustomButton.Name = "";
            this.languageName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.languageName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.languageName.CustomButton.TabIndex = 1;
            this.languageName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.languageName.CustomButton.UseSelectable = true;
            this.languageName.CustomButton.Visible = false;
            this.languageName.Lines = new string[0];
            this.languageName.Location = new System.Drawing.Point(162, 84);
            this.languageName.MaxLength = 32767;
            this.languageName.Name = "languageName";
            this.languageName.PasswordChar = '\0';
            this.languageName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.languageName.SelectedText = "";
            this.languageName.SelectionLength = 0;
            this.languageName.SelectionStart = 0;
            this.languageName.ShortcutsEnabled = true;
            this.languageName.Size = new System.Drawing.Size(152, 23);
            this.languageName.TabIndex = 4;
            this.languageName.UseSelectable = true;
            this.languageName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.languageName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Location = new System.Drawing.Point(340, 88);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(84, 15);
            this.chkIsActive.TabIndex = 5;
            this.chkIsActive.Text = "Está activo?";
            this.chkIsActive.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkIsActive.UseSelectable = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Identificador";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "Activo";
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            this.isActiveDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // languageBindingSource
            // 
            this.languageBindingSource.DataSource = typeof(RRHHRecruitment.Core.Models.Language);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(3, 158);
            this.metroButton1.MaximumSize = new System.Drawing.Size(124, 23);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(124, 23);
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "Nuevo";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // LanguageForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 551);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.chkIsActive);
            this.Controls.Add(this.languageName);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.languageGrid);
            this.Name = "LanguageForm";
            this.Text = "Gestión de idiomas";
            ((System.ComponentModel.ISupportInitialize)(this.languageGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.languageBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource languageBindingSource;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox languageName;
        private MetroFramework.Controls.MetroCheckBox chkIsActive;
        private MetroFramework.Controls.MetroGrid languageGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}