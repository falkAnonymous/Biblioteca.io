using Library.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model.Entities
{
    internal class Register : IRegister
    {
        private int _Id = 0;
        private string _Name = null;
        private DateTime _BirthDate = DateTime.MinValue;
        private string _Email = null;
        private string _Password = string.Empty;
        public List<ProfileUser> _UserProfile { get; set; }

        public Register(int id, string name, DateTime birthDate, string email, string password)
        {
            _Id = id;
            _Name = name;
            _BirthDate = birthDate;
            _Email = email;
            _Password = password;
        }

        public void ConfirmRegister()
        {
            _UserProfile.Add(new ProfileUser(_Id, _Name, _BirthDate, _Email, _Password));
        }
    }
}
