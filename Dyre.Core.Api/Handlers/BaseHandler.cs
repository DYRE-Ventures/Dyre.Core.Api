using MediatR;

namespace Dyre.Core.Api.Handlers;

/// <summary>
/// The base implementation of the <see cref="IRequestHandler{TRequest}"/> API.
/// </summary>
public abstract class BaseHandler<TRequest, TResponse> : 
    IRequestHandler<TRequest, TResponse> 
    where TRequest : IRequest<TResponse>
{
    /// <inheritdoc cref="IRequestHandler{TRequest,TResponse}.Handle(TRequest,CancellationToken)"/>
    protected abstract Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken);

    Task<TResponse> IRequestHandler<TRequest, TResponse>.Handle(TRequest request, CancellationToken cancellationToken)
        => Handle(request, cancellationToken);
}