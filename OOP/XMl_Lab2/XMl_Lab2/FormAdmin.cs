using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;

namespace XMl_Lab2
{
    class FormAdmin
    {
        public static void LoadInfo(ComboBox name, string param1, string param2)
        {
            List<string> items = new List<string>();
            items = getInfo(param1, param2);
            items.Sort();
            name.Items.Clear();
            foreach (string i in items)
            {
                name.Items.Add(i);
            }

        }
        public static List<string> getInfo(string param1, string param2)
        {
            List<string> nodes = new List<string>();
            XmlDocument doc = new XmlDocument();
            doc.Load(XmlSearch.path);
            foreach (XmlNode node in doc.SelectNodes("//" + param1 + "[@" + param2 + "]"))
            {
                if (!(nodes.Contains(node.Attributes[param2].Value)))
                {
                    nodes.Add(node.Attributes[param2].Value);
                }
            }
            return nodes;

        }
        public static void Transform()
        {
            // Завантаження стилів
            XslCompiledTransform xslt = new XslCompiledTransform();
            string f1 = "C:\\Users\\Admin\\Documents\\program67\\XMl_Lab2\\XMl_Lab2\\XSLTFile1.xslt";
            xslt.Load(f1);
            // Виконання перетворення і виведення результатів у файл.
            string f2 = "C:\\Users\\Admin\\Documents\\program67\\XMl_Lab2\\XMl_Lab2\\XMLFile1.xml";
            string f3 = "C:\\Users\\Admin\\Documents\\program67\\XMl_Lab2\\XMl_Lab2\\XMLFile1.html";
            xslt.Transform(f2, f3);
        }

    }
}
