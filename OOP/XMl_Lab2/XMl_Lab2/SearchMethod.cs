using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;
using System.Linq;
using System.Xml;

namespace XMl_Lab2
{
    public interface ISearch
    {
        
        List<Movie> Method(Movie movie);
    }
    
  
}
