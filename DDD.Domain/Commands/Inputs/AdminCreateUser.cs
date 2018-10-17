using DDD.Shared.Commands;

namespace DDD.Domain.Commands.Inputs
{
    public class AdminCreateUser : ICommand
    {
        public string Name { get; private set; }
        public string CPF { get; private set; }
        public string Email { get; set; }
    }
}
