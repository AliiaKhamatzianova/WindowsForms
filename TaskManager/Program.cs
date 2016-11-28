using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManager.Presenters;
using TaskManager.Models;

namespace TaskManager
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainView());

            var view = new MainView();
            var model = new MainModel();
            var presenter = new MainPresenter() { View = view , Model = model};
            view.Presenter = presenter;
            presenter.Run();
        }
    }
}
