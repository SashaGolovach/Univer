using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace XMl_Lab2
{
     public class Linq : ISearch
    {
        List<Movie> info = new List<Movie>();
        XDocument doc = new XDocument();
        public Linq(string path)
        {
            doc = XDocument.Load(path);
        }
        public List<Movie> Method(Movie movie)
        {
            info.Clear();
            List<XElement> match = (from val in doc.Descendants("movie")
                                    where
                                    ((movie.Genre == null  || movie.Genre == val.Parent.Parent.Attribute("GENRE").Value) &&
                                    (movie.Studio == null || movie.Studio == val.Parent.Attribute("STUDIO").Value) &&
                                    (movie.Name == null || movie.Name == val.Attribute("NAME").Value) &&
                                    (movie.Year == null || movie.Year == val.Attribute("YEAR").Value) &&
                                    (movie.Time == null ||movie.Time == val.Attribute("TIME").Value))
                                    select val).ToList();
            foreach (XElement val in match)
            {
                Movie m = new Movie();
                m.Genre = val.Parent.Parent.Attribute("GENRE").Value;
                m.Studio = val.Parent.Attribute("STUDIO").Value;
                m.Name = val.Attribute("NAME").Value;
                m.Year = val.Attribute("YEAR").Value;
                m.Time = val.Attribute("TIME").Value;
                info.Add(m);
            }
            return info;

        }
    }
}
