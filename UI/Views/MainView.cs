using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Presenters;

namespace UI
{
    public partial class MainView : Form
    {
        public MainViewPresenter Presenter { get; set; }

        public MainView()
        {
            InitializeComponent();
        }
    }
}
