using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab11
{

    class Movie : List<Movie>
    {
        private string _title;
        private string _category;
        
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public string Category
           {
            get { return _category; }
            set { _category = value; }
        }
        public Movie(string title, string category)
        {
            Title = title;
            Category = category;
        }
        
        

    }
    
}
