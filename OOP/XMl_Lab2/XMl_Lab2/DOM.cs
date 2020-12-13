using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Xml;

namespace XMl_Lab2
{
    public class DOM:ISearch
    {
        List<List<Movie>> info = new List<List<Movie>>();
        XmlDocument doc = new XmlDocument();

        public DOM(string path)
        {
            doc.Load(path);
        }

        //we find all the movies that match each parameter request and then cross them to prevent a recurrence
        public  List<Movie> Method(Movie movie)
        {
            bool all_null = true;
            try
            {
                if (movie.Genre != null)
                {
                    info.Add(SearchByParametr("genre", "GENRE", movie.Genre, doc, 0));
                    all_null = false;
                }
                if (movie.Studio != null)
                {
                    info.Add(SearchByParametr("studio", "STUDIO", movie.Studio, doc, 1));
                    all_null = false;
                }
                if (movie.Name != null)
                {
                    info.Add(SearchByParametr("movie", "NAME", movie.Name, doc, 2));
                    all_null = false;
                }
                if (movie.Year != null)
                {
                    info.Add(SearchByParametr("movie", "YEAR", movie.Year, doc, 2));
                    all_null = false;
                }
                if (movie.Time != null)
                {
                    info.Add(SearchByParametr("movie", "TIME", movie.Time, doc, 2));
                    all_null = false;
                }
            }
            catch { }
            if (!all_null)
            {
                return Cross(info);
            }
            return AllMovies(doc);

        }

        private List<Movie> Cross(List<List<Movie>> info)
        {
            List<Movie> movies = new List<Movie>();
            try
            {
                if (info != null)
                {

                    Movie[] movies1 = info[0].ToArray();
                    if (movies1 != null)
                    {
                        foreach (Movie elem in movies1)
                        {
                            bool IN = true;
                            foreach (List<Movie> i in info)
                            {
                                if (i.Count <= 0) return new List<Movie>();
                                foreach (Movie m in i)
                                {
                                    IN = false;
                                    if (elem.Equal(m))
                                    {
                                        IN = true;
                                        break;
                                    }
                                }
                                if (!IN)
                                {
                                    break;
                                }

                            }
                            if (IN)
                            {
                                movies.Add(elem);
                            }
                        }
                    }
                }
            }
            catch { }
            return movies;
        }

        //function SearchByParametr take v1,v2 parametrs to form xpath 
        //ideal to find only nodes which match to search request
        //doc as a database
        //level to know how many levels to the deepest node
        private List<Movie> SearchByParametr(string v1, string v2, string ideal, XmlDocument doc, int level)
        {
            List<Movie> movies = new List<Movie>();
            if(ideal!=null&&ideal!=string.Empty)
            {
                switch(level)
                {
                    case 0:
                        {
                            XmlNodeList elem = doc.SelectNodes("//" + v1 + "[@" + v2 + "=\"" + ideal + "\"]");
                            try
                            {
                                foreach(XmlNode e in elem)
                                {
                                    XmlNodeList list1 = e.ChildNodes;
                                    foreach (XmlNode el in list1)
                                    {
                                        XmlNodeList list2 = el.ChildNodes;
                                        foreach (XmlNode ell in list2)
                                        {
                                            movies.Add(Info(ell));
                                        }
                                    }
                                }
                            }
                            catch { }
                            return movies;
                        }
                    case 1:
                        {
                            XmlNodeList elem = doc.SelectNodes("//" + v1 + "[@" + v2 + "=\"" + ideal + "\"]");
                            try
                            {
                                foreach (XmlNode e in elem)
                                {
                                    XmlNodeList list1 = e.ChildNodes;
                                    foreach (XmlNode el in list1)
                                    {
                                        
                                            movies.Add(Info(el));
                                    }
                                }
                            }
                            catch { }
                            return movies;
                        }
                    case 2:
                        {
                            XmlNodeList elem = doc.SelectNodes("//" + v1 + "[@" + v2 + "=\"" + ideal + "\"]");
                            try
                            {
                                foreach (XmlNode e in elem)
                                {
                                        movies.Add(Info(e));
                                }
                            }
                            catch { }
                            return movies;
                        }
                    default: break;
                }
                
            }
            return movies;
        }

        private List<Movie> AllMovies(XmlDocument doc)
        {
            List<Movie> movies = new List<Movie>();
            try
            {
                XmlNodeList elem = doc.SelectNodes("//movie");
                foreach (XmlNode e in elem)
                {
                    movies.Add(Info(e));
                }
            }
            catch { }
            return movies;

        }

        private Movie Info(XmlNode e)
        {
            Movie m = new Movie();
            m.Genre = e.ParentNode.ParentNode.Attributes.GetNamedItem("GENRE").Value;
            m.Studio = e.ParentNode.Attributes.GetNamedItem("STUDIO").Value;
            m.Name = e.Attributes.GetNamedItem("NAME").Value;
            m.Time = e.Attributes.GetNamedItem("TIME").Value;
            m.Year = e.Attributes.GetNamedItem("YEAR").Value;
            return m;
        }
    }
}
