using DDD.Domain.ValueObjects;
using DDD.Shared.Entities;
using System;

namespace DDD.Domain.Entities
{
    public class User : Entity
    {
        public User(string name, Document cPF, string email, string password)
        {
            Name = name;
            CPF = cPF;
            Password = password;
            Email = email;
        }

        public User(string name, DateTime birthDay, string address, Document cPF,string email, string password)
        {
            Name = name;
            BirthDay = birthDay;
            Address = address;
            CPF = cPF;
            Email = email;
            Password = password;
        }

        public string Name { get; private set; }
        public DateTime BirthDay { get; private set; }
        public string Address { get; private set; }
        public Document CPF { get; private set; }
        public string Password { get; private set; }
        public string Email { get; private set; }
    }
}
