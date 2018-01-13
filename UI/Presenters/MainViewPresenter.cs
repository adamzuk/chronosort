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
        private List<Item> items;

        private MainView view;

        public MainViewPresenter(List<Item> items, MainView view)
        {
            this.items = items;
            this.view = view;

            this.view.Presenter = this;
        }

        public void OnChangeDirectoryClicked(ListBox listBox, Label directoryValueLabel)
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

        public void OnPictureFileSelected(ListBox sender)
        {
            this.view.picPreview.ImageLocation = sender.SelectedItem.ToString();
        }
    }
}
