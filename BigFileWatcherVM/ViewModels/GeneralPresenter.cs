using Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI;

namespace BigFileWatcherVM.ViewModels
{
   public class GeneralPresenter
    {
        IMainView mainview = new MainView();

        public void Run()
        {
            mainview.Run(null);

        }

    }
}
