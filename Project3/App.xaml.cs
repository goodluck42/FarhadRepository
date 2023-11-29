global using Microsoft.Extensions.DependencyInjection;

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Project3.ViewModels;
using Project3.Views;


namespace Project3
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        static App()
        {
            ServiceCollection = new ServiceCollection();
            
            {
                ServiceCollection.AddSingleton<MainVIew>();

                ServiceCollection.AddSingleton<MainViewModel>();
                ServiceCollection.AddTransient<CreateUserViewModel>();
                ServiceCollection.AddTransient<UpdateUserViewModel>();
                ServiceCollection.AddSingleton<UserListViewModel>();
                
            }
            
            ServiceProvider = ServiceCollection.BuildServiceProvider();
        }
        
        public static ServiceCollection ServiceCollection { get; }
        public static ServiceProvider ServiceProvider { get; }
        
        protected override void OnStartup(StartupEventArgs e)
        {
            var mainView = ServiceProvider.GetService<MainVIew>()!;
            
            mainView.Show();
        }
    }
}