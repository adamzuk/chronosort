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

        private void butChangeDirectory_Click(object sender, EventArgs e)
        {
            this.Presenter.OnChangeDirectoryClick(lstDirectoryFiles, lblDirectoryPathValue);
        }

        private void butChangeNewOrderDirectory_Click(object sender, EventArgs e)
        {
            this.Presenter.OnChangeDirectoryClick(lstNewOrder, lblNewOrderDirectoryPathValue);
        }

        private void lstDirectoryFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Presenter.OnPictureFileSelect(lstDirectoryFiles);
        }

        private void lstNewOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Presenter.OnPictureFileSelect(lstNewOrder);
        }

        private void butAddSelectedFiles_Click(object sender, EventArgs e)
        {
            this.Presenter.OnFilesAddButtonClick();
        }
    }
}
