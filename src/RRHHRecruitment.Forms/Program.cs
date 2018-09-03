using RRHHRecruitment.Forms.Screens;
using RRHHRecruitment.Persistence;
using System;
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
            IUnityContainer container = new UnityContainer();
            container.RegisterType<RecruitmentContext>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<MainForm>());
        }
    }
}
