using Library.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model.Entities
{
    internal class Book : IBook
    {
        public int _Id { get; set; }
        public string _Title { get; set; }
        public string _Description { get; set; }

        public Book(int id, string title, string description)
        {
            _Id = id;
            _Title = title;
            _Description = description;
        }

    }
}
