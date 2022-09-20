using Manager.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Users
{
    public class UsersModel : IElementWithId
    {
        public UsersModel()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Imię { get; set; }
        public string Nazwisko { get; set; }
        public string Email { get; set; }
    }
}
