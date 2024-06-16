using Library.Model.Interfaces;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Library.Model.Entities
{
    internal class ProfileUser : IProfileUser
    {
        public int _Id { get; private set; } = 0;
        public string _ProfilePicture { get; set; } = null;
        public string _UserName { get; private set; } = string.Empty;
        public DateTime _BirthDate { get; private set; } = DateTime.MinValue;
        public int _Age { get; private set; } = 0;
        public string _Email { get; private set; } = null;
        public string _Password { get; private set; } = null;

        public ProfileUser(int id ,string username, DateTime birthDate, string email, string password)
        {
            _Id = id;
            _UserName = username;
            _BirthDate = birthDate;
            _Email = email;
            _Password = password;
        }

        public void ChangeName(string name)
        {
            _UserName = name.ToString();
        }

        public void NewUserPassword(int id, string username, string password)
        {
            if (id == _Id && username == _UserName)
            {
                if(password.Length >= 8)
                {
                    _Password = password;
                }
            }
        }

        public void Changepictures(int id, Image picture, string NewFilePath)
        {
            if(id == _Id)
            {
                _ProfilePicture = NewFilePath;
                picture.Save(_ProfilePicture);
            }
        }
    }
}
