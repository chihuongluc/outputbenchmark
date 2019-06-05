using OBM.App.Common;
using OBM.App.Views;
using OBM.Data;
using OBM.Data.Infrastructure;
using OBM.Data.Repositories;
using OBM.Service;
using SimpleInjector;
using SimpleInjector.Diagnostics;
using SimpleInjector.Extensions.ExecutionContextScoping;
using System;
using System.Windows.Forms;

namespace OBM.App
{
    internal static class Program
    {
        //private static Container container;

        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Bootstrap();
            //Extentions.container = container;
            //Application.Run(container.GetInstance<Welcome>());
            Application.Run(new Welcome());
        }

        //private static void Bootstrap()
        //{
        //    // Create the container as usual.
        //    container = new Container();
        //    container.Options.DefaultScopedLifestyle = new ExecutionContextScopeLifestyle();

        //    // Register your types, for instance:
        //    container.Register<IDbFactory, DbFactory>(Lifestyle.Scoped);
        //    container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Scoped);
        //    container.Register<OBMDbContext>(Lifestyle.Scoped);

        //    // Repositories
        //    container.Register<IAccountRepository, AccountRepository>(Lifestyle.Scoped);
        //    container.Register<IChineseScoreRepository, ChineseScoreRepository>();
        //    container.Register<IFinalTestRepository, FinalTestRepository>();
        //    container.Register<IITScoreRepository, ITScoreRepository>();
        //    container.Register<IJoinFinalTestRepository, JoinFinalTestRepository>();
        //    container.Register<IRoleRepository, RoleRepository>();
        //    container.Register<IRoomRepository, RoomRepository>();
        //    container.Register<IScheduleRepository, ScheduleRepository>();
        //    container.Register<IScoreRepository, ScoreRepository>();
        //    container.Register<IStudentRepository, StudentRepository>();
        //    container.Register<ISubjectRepository, SubjectRepository>();
        //    container.Register<IToeicScoreRepository, ToeicScoreRepository>();

        //    // Service
        //    container.Register<IAccountService, AccountService>(Lifestyle.Scoped);
        //    container.Register<IChineseScoreService, ChineseScoreService>();
        //    container.Register<IFinalTestService, FinalTestService>();
        //    container.Register<IITScoreService, ITScoreService>();
        //    container.Register<IJoinFinalTestService, JoinFinalTestService>();
        //    container.Register<IRoleService, RoleService>();
        //    container.Register<IRoomService, RoomService>();
        //    container.Register<IScheduleService, ScheduleService>();
        //    container.Register<IScoreService, ScoreService>();
        //    container.Register<IStudentService, StudentService>();
        //    container.Register<ISubjectService, SubjectService>();
        //    container.Register<IToeicScoreService, ToeicScoreService>();

        //    //container.Register<Welcome>(Lifestyle.Scoped);
            
        //    // Optionally verify the container.
        //    container.Verify();
        //}
    }
}