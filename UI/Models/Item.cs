using System.Xml.Serialization;

namespace UI.Models
{
    [XmlRoot("Item")]
    public class Item
    {
        public string CurrentPath { get; set; }

        public string NewPath { get; set; }

        public Item()
        {

        }

        public Item(string currPath, string newPath)
        {
            this.CurrentPath = currPath;
            this.NewPath = newPath;
        }
    }
}
