using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfApplication.LogicFolder;
using WpfApplication.Migrations;

namespace WpfApplication
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<AppContext,Configuration>());
            base.OnStartup(e);
        }
    }
}
