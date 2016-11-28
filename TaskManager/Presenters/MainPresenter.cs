using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Presenters
{
   
    public class MainPresenter : IPresenter<string, string>
    {
        public IModel<string, string> Model { get; set; }

        public IView<string, string> View { get; set; }

        public string DataRequest(string source)
        {
            Model.Source = source;
            string data = Model.GetData();
            return data;
        }

        public void Run()
        {
            View.Start();
        }

        public void SaveRequest(string data)
        {
            Model.SaveData(data);
        }
    }
}
