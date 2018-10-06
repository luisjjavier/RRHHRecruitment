using RRHHRecruitment.Core.Contracts.Repositories;
using RRHHRecruitment.Core.Models;
using RRHHRecruitment.Core.Models.Enums;
using RRHHRecruitment.Forms.Screens;
using RRHHRecruitment.Persistence;
using RRHHRecruitment.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace RRHHRecruitment.Forms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = Bootstrap();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var loginForm = container.Resolve<LoginForm>();

            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                CurrentUser = loginForm.GetActiveUser();
                Application.Run(container.Resolve<MainForm>());
            }
            else
            {
                Application.Exit();
            }
        }

        public static readonly Dictionary<RoleType, string> TranslateRoleType = new Dictionary<RoleType, string>()
        {
            [RoleType.Admin] = "Administrador",
            [RoleType.Candidates] = "Candidatos",
            [RoleType.HumanResources] = "Recursos Humanos"
        };

        public static readonly Dictionary<RiskLevel, string> TranslateRiskLevel = new Dictionary<RiskLevel, string>()
        {
            [RiskLevel.None] = "Ninguno",
            [RiskLevel.High] = "Alto",
            [RiskLevel.Medium] = "Medio",
            [RiskLevel.Low] = "Bajo"
        };


        public static readonly Dictionary<AcademicLevel, string> TranslateAcademicLevel = new Dictionary<AcademicLevel, string>()
        {
            [AcademicLevel.None] = "Ninguno",
            [AcademicLevel.Grade] = "Grado",
            [AcademicLevel.Management] = "Gestión",
            [AcademicLevel.Master] = "Maestria",
            [AcademicLevel.PostGrade] = "Post grado",
            [AcademicLevel.Tecno] = "Tecnico"
        };


        public static User CurrentUser { get; set; }

        private static IUnityContainer Bootstrap()
        {
            IUnityContainer container = new UnityContainer();
            RecruitmentContext recruitmentContext = new RecruitmentContext();
            container.RegisterInstance(recruitmentContext);
            container.RegisterType<IUsersRepository, UsersRepository>();
            container.RegisterType<ILanguagesRepository, LanguangesRepository>();
            container.RegisterType<IJobsRepository, JobsRepository>();
            container.RegisterType<ICompetitionRepository, CompetitionRepository>();
            container.RegisterType<ITrainingRepository, TrainingRepository>();
            return container;
        }
    }
}
