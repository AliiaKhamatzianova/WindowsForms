using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Models
{
    public class MainModel : IModel<string, string>
    {
        public IPresenter<string, string> Presenter {get;set; }

        public string Source { get; set; }

        public string GetData()
        {
            return "Hello world";
        }

        public void SaveData(string data)
        {
            
        }
    }
}
