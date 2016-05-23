using PicasaViewer.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PicasaViewer.DataModel
{
    public class Album
    {
        public Album(XElement element)
        {
            Title = element.GetValue(XmlNamespaces.Atom, "title");
        }

        public string Title { get; set; }
    }
}
