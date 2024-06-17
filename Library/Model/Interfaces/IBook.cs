using Library.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model.Interfaces
{
    internal interface IBook
    {
        int _Id { get; set; } 
        string _Title { get; set; }
        string _Description { get; set; }
        

    }
}
