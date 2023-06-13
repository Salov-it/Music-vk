

using MediatR;

namespace UserService.Application.CQRS.Command.Authorization
{
    public class GetAutCommand : IRequest<string>
    {
        public string login { get; set; }
        public string password { get; set; }
    }
}
