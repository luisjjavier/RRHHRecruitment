﻿using MetroFramework;
using MetroFramework.Forms;
using RRHHRecruitment.Core.Contracts;
using RRHHRecruitment.Core.Models;
using RRHHRecruitment.Core.Services;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace RRHHRecruitment.Forms.Screens
{
    public partial class WorkExperienceForm : MetroForm
    {
        private readonly WorkExperiencesService _workExperiencesService;
        private readonly IUnityContainer _container;

        public bool IsSelectionMode { get; internal set; }
        public List<WorkExperience> WorkExperiences { get; internal set; } = new List<WorkExperience>();

        public WorkExperienceForm(WorkExperiencesService workExperiencesService, IUnityContainer container)
        {
            InitializeComponent();
            _workExperiencesService = workExperiencesService;
            _container = container;

            workExperienceBindingSource.DataSource = _workExperiencesService.GetWorkExperience(Program.CurrentUser.Id);
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            var workExperience = workExperienceBindingSource.Current as WorkExperience;
            if (MetroMessageBox.Show(this, $"Desea borrar esta experiencia de trabajo {workExperience.Company}?", "Borrar experiencia de trabajo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                IOperationResult<WorkExperience> basicOperationResult = _workExperiencesService.DeleteExperience(workExperience);
                if (basicOperationResult.Success)
                {
                    workExperienceBindingSource.DataSource = _workExperiencesService.GetWorkExperience(Program.CurrentUser.Id);
                }
            }
        }

        private void btnCreate_Click(object sender, System.EventArgs e)
        {
            CreateWorkExperience form = _container.Resolve<CreateWorkExperience>();

            if (form.ShowDialog() == DialogResult.OK)
            {
                MetroMessageBox.Show(this, "La experiencia de trabajo se ha creado correctamente!", "Creacion de experiencia de trabajo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                workExperienceBindingSource.DataSource = _workExperiencesService.GetWorkExperience(Program.CurrentUser.Id);
            }
        }

        private void metroGrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var workExperience = workExperienceBindingSource.Current as WorkExperience;
            var form = _container.Resolve<CreateWorkExperience>();

            form.CurrentWorkExperience = workExperience;

            if (form.ShowDialog() == DialogResult.OK)
            {
                MetroMessageBox.Show(this, "La Experiencia de trabajo se ha editado correctamente!", "Edición de Experiencia de trabajo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                workExperienceBindingSource.DataSource = _workExperiencesService.GetWorkExperience(Program.CurrentUser.Id);
            }
        }

        private void WorkExperienceForm_Load(object sender, System.EventArgs e)
        {
            if (IsSelectionMode)
            {
                metroGrid1.MultiSelect = true;
                metroGrid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                btnDelete.Hide();
                btnCreate.Hide();
                metroButton1.Show();
            }
        }

        private void metroButton1_Click(object sender, System.EventArgs e)
        {
            for (int i = 0; i < metroGrid1.SelectedRows.Count; i++)
            {
                WorkExperiences.Add((WorkExperience)metroGrid1.SelectedRows[i].DataBoundItem);
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
