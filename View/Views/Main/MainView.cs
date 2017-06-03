using Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace View.Views.Main
{
    public class MainView : IMainView
    {
        Window1 view = new Window1();

        public void Run(object Model)
        {
            view.Show();
        }
    }
}
