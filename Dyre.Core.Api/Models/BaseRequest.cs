using MediatR;

namespace Dyre.Core.Api.Models;

/// <summary>
/// The base implementation of the <see cref="IRequest{TResponse}"/> API.
/// </summary>
public class BaseRequest<TModel> : IRequest<TModel>;