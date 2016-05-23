using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PicasaViewer.BusinessLogic
{
    public static class XmlExtensions
    {
        public static XElement GetElement(this XElement xml, XNamespace xmlNameSpace, string elementName)
        {
            var element = xml.Element(xmlNameSpace + elementName);
            if (element != null)
            {
                return element;
            }
            return null;
        }

        public static string GetValue(this XElement xml, XNamespace xmlNameSpace, string elementName)
        {
            var element = xml.GetElement(xmlNameSpace, elementName);
            if (element != null)
            {
                return element.Value;
            }
            return null;
        }
    }
}
