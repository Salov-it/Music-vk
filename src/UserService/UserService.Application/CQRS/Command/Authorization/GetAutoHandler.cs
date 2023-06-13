using MediatR;

namespace UserService.Application.CQRS.Command.Authorization
{
    public class GetAutoHandler : IRequestHandler<GetAutCommand, string>
    {
        public async Task<string> Handle(GetAutCommand request, CancellationToken cancellationToken)
        {
            Authorize authorize = new Authorize();
            await authorize.Authoriz(request.login, request.password);

            return  "ok";
        }
    }
}
