using DDD.Shared.Commands;

namespace DDD.Domain.Commands.Results
{
    public class CreateUserCommandResult : ICommandResult
    {
        public string Mensagem { get; set; }
    }
}
