using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    public interface IPresenter<TSource, TData>
    {
        IView<TSource, TData> View { set; }
        IModel<TSource, TData> Model { set; }
        void Run();
        string DataRequest(TSource source);
        void SaveRequest(TData data);
    }

    public interface IView<TSource, TData>
    {
        IPresenter <TSource, TData> Presenter { set; }
        //void Show();
        void Start();
    }

    public interface IModel<TSource, TData>
    {
        IPresenter<TSource, TData> Presenter { set; }
        TSource Source { set; }
        TData GetData();
        void SaveData(TData data);
    }

}
