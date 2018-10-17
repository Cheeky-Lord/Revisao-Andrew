using DDD.Domain.Commands.Inputs;
using DDD.Domain.Commands.Results;
using DDD.Domain.Entities;
using DDD.Domain.Repositories;
using DDD.Domain.ValueObjects;
using DDD.Shared.Commands;

namespace DDD.Domain.Commands.Handlers
{
    public class UserHandler : 
        ICommandHandler<PublicCreateUser>,
        ICommandHandler<AdminCreateUser>
    {
        private readonly IUserRepository _userRepository;
        public UserHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;

        }
        public ICommandResult Handle(PublicCreateUser command)
        {
            //Comportamento para a criação de um usuario apartir da area pública.
            //1 - Criar VOs
            Document document = new Document(command.CPF);
            //2 - Criar Entities
            User user = new User(command.Name, command.BirthDay, command.Address, document,command.Email, command.Password);
            //3 - Validar

            //4 - Salvar no Banco
            _userRepository.Save(user);

            //5 - Criar Command Result
            CreateUserCommandResult result = new CreateUserCommandResult();
            result.Mensagem = "Usuário registrado com sucesso.";

            return result;

        }

        public ICommandResult Handle(AdminCreateUser command)
        {
            //Comportamento para a criação de um usuario apartir da area pública.
            //1 - Criar VOs
            Document document = new Document(command.CPF);
            //2 - Criar Entities
            User user = new User(command.Name, document,command.Email, command.CPF);
            //3 - Validar

            //4 - Salvar no Banco
            _userRepository.Save(user);

            //5 - Criar Command Result
            CreateUserCommandResult result = new CreateUserCommandResult();
            result.Mensagem = "Usuário registrado com sucesso. O CPF é a senha inicial.";

            return result;
        }
    }
}
