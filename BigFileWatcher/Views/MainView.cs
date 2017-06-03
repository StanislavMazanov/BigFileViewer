using Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Views
{
    public class MainView : IMainView
    {
        MainWindow view;

        public void Run(object Model)
        {
            view = new MainWindow();
            view.Show();

        }
    }
}
