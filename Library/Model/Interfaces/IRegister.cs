using Library.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model.Interfaces
{
    internal interface IRegister
    {
        List<ProfileUser> _UserProfile { get; set; }
        void ConfirmRegister();
    }
}
