using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Models;

namespace UI.Presenters
{
    public class MainViewPresenter
    {
        private List<Item> _items;

        private MainView _view;

        public MainViewPresenter(List<Item> items, MainView view)
        {
            this._items = items;
            this._view = view;

            this._view.Presenter = this;
        }

        public void OnChangeDirectoryClick(ListBox listBox, Label directoryValueLabel)
        {
            using (var directoryDialog = new FolderBrowserDialog())
            {
                var result = directoryDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(directoryDialog.SelectedPath))
                {
                    directoryValueLabel.Text = directoryDialog.SelectedPath;

                    var files = Directory.GetFiles(directoryDialog.SelectedPath);

                    listBox.DataSource = files;
                }
            }
        }

        public void OnPictureFileSelect(ListBox sender)
        {
            if (sender.SelectedItem == null)
            {
                return;
            }
            this._view.picPreview.ImageLocation = sender.SelectedItem.ToString();
        }

        public void OnFilesAddButtonClick()
        {
            foreach (var item in this._view.lstDirectoryFiles.SelectedItems)
            {
                this._view.lstNewOrder.Items.Add(item.ToString());
            }
        }
    }
}
