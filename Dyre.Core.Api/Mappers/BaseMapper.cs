namespace Moobii.Core.Mappers;

/// <summary>
/// The base implementation of the <see cref="IMapper{TIn,TOut}"/> API.
/// </summary>
public abstract class BaseMapper<TIn, TOut> :
    IMapper<TIn, TOut>
{
    /// <inheritdoc cref="IMapper{TIn,TOut}.MapFrom(TIn)"/>
    protected abstract TOut MapFrom(TIn from);

    TOut IMapper<TIn, TOut>.MapFrom(TIn from) => MapFrom(from);
}