using RRHHRecruitment.Forms.Screens;
using RRHHRecruitment.Persistence;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RRHHRecruitment.Core.Contracts.Repositories;
using RRHHRecruitment.Persistence.Repositories;
using Unity;
using RRHHRecruitment.Core.Models;
using RRHHRecruitment.Core.Models.Enums;

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

        public static  User CurrentUser { get; set; }

        private static IUnityContainer Bootstrap()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<RecruitmentContext>();
            container.RegisterType<IUsersRepository, UsersRepository>();
            container.RegisterType<ILanguagesRepository, LanguangesRepository>();
            container.RegisterType<IJobsRepository, JobsRepository>();

            return container;
        }
    }
}
