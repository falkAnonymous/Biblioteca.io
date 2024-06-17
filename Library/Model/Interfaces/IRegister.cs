using Library.Model.Entities;
using System.Collections.Generic;

namespace Library.Model.Interfaces
{
    internal interface IRegister
    {
        List<ProfileUser> _UserProfile { get; set; }
        void ConfirmRegister();
    }
}
