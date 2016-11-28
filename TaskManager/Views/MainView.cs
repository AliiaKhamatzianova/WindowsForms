using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class MainView : Form, IView<string, string>
    {
        public MainView()
        {
            InitializeComponent();
        }

        public IPresenter<string, string> Presenter { get; set; }
           

        public void Start()
        {
            Application.Run(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = Presenter.DataRequest("hello");
            mainTextBox.Text = str;
        }
    }
}
