using DDD.Shared.Commands;
using System;

namespace DDD.Domain.Commands.Inputs
{
    public class PublicCreateUser : ICommand
    {
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
        public string Address { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
