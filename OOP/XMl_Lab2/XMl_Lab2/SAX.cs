using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace XMl_Lab2
{
    public  class SAX : ISearch
    {
        List<Movie> info = new List<Movie>();
        XmlTextReader xmlReader;
        public SAX(string path)
        {
            xmlReader = new XmlTextReader(path);
        }
        public List<Movie> Method(Movie movie)
        {
            info.Clear();
            Movie m = null;
            string genre = null;
            string studio = null;
            while (xmlReader.Read())
            {
                if (xmlReader.Name == "genre")
                {
                    while (xmlReader.MoveToNextAttribute())
                    {
                        if (xmlReader.Name == "GENRE")
                        {
                            genre = xmlReader.Value;
                        }
                    }
                }
                if (xmlReader.Name == "studio")
                {
                    while (xmlReader.MoveToNextAttribute())
                    {
                        if (xmlReader.Name == "STUDIO")
                        {
                            studio = xmlReader.Value;
                        }
                    }
                }
                if (xmlReader.Name == "movie")
                {
                    m = new Movie();
                    m.Genre = genre;
                    m.Studio = studio;
                    if (xmlReader.HasAttributes)
                    {
                        while (xmlReader.MoveToNextAttribute())
                        {
                            if (xmlReader.Name == "NAME")
                            {
                                m.Name = xmlReader.Value;
                            }
                            if (xmlReader.Name == "YEAR")
                            {
                                m.Year = xmlReader.Value;
                            }
                            if (xmlReader.Name == "TIME")
                            {
                                m.Time = xmlReader.Value;
                            }
                        }

                    }
                    if (m.Time != null)
                    {
                        info.Add(m);
                    }
                }

            }
            info = Filtr(info, movie);
            return info;

        }
        //in SAX we read all movies
        //in filter we leave only matched with parametrs 
        private List<Movie> Filtr(List<Movie> info, Movie movie)
        {
            List<Movie> result = new List<Movie>();
            if (info != null)
            {
                foreach (Movie m in info)
                {
                    try
                    {
                        if ((movie.Genre == null || m.Genre == movie.Genre) && 
                            (movie.Studio == null || m.Studio == movie.Studio) &&
                            (movie.Name == null || m.Name == movie.Name) &&
                            (movie.Time == null || m.Time == movie.Time) && 
                            (movie.Year == null || m.Year == movie.Year ))
                        {
                            result.Add(m);
                        }
                    }
                    catch { }
                }
            }
            return result;
        }
    }
}


