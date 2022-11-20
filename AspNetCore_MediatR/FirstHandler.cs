using MediatR;

namespace AspNetCore_MediatR
{
    public class FirstHandler : IRequestHandler<FirstRequest, string>
    {
        public Task<string> Handle(FirstRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult("First Response");
        }
    }
}
