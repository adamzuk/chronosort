using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Models;

namespace UI.Presenters
{
    public class MainViewPresenter
    {
        private List<Item> items;

        private MainView view;

        public MainViewPresenter(List<Item> items, MainView view)
        {
            this.items = items;
            this.view = view;

            this.view.Presenter = this;
        }
    }
}
