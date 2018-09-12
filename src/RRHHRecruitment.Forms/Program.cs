using RRHHRecruitment.Forms.Screens;
using RRHHRecruitment.Persistence;
using System;
using System.Windows.Forms;
using RRHHRecruitment.Core.Contracts.Repositories;
using RRHHRecruitment.Persistence.Repositories;
using Unity;
using RRHHRecruitment.Core.Models;

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

        public static  User CurrentUser { get; set; }

        private static IUnityContainer Bootstrap()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<RecruitmentContext>();
            container.RegisterType<IUsersRepository, UsersRepository>();
            container.RegisterType<ILanguagesRepository, LanguangesRepository>();

            return container;
        }
    }
}
