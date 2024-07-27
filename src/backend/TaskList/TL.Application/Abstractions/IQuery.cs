using MediatR;

namespace TL.Application.Abstractions
{
    public interface IQuery<TResponse> : IRequest<TResponse>
    {
    }

    public interface IQueryHandler<TCommand, TResponse> : IRequestHandler<TCommand, TResponse>
        where TCommand : ICommand<TResponse>
    { }
}
