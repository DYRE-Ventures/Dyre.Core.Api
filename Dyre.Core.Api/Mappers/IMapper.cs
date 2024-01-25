namespace Moobii.Core.Mappers;

/// <summary>
/// An API that describes a mapper.
/// </summary>
/// <typeparam name="TIn">Type that needs to be used to transform from.</typeparam>
/// <typeparam name="TOut">Type that needs to be used to transform to.</typeparam>
public interface IMapper<in TIn, out TOut>
{
    /// <summary>
    /// Map a certain object to a certain target.
    /// </summary>
    /// <param name="from">The object that needs to be transformed.</param>
    /// <returns>The transformed object.</returns>
    TOut MapFrom(TIn from);
}