using System;

namespace Volo.Abp.Guids;

/// <summary>
/// Used to generate Ids.
/// </summary>
public interface IGuidGenerator
{
    /// <summary>
    /// Creates a new <see cref="Guid"/>.
    /// </summary>
    Guid Create();

    /// <summary>
    /// Creates a new <see cref="Guid"/>.
    /// </summary>
    /// <param name="guidType">Sequential Guid type.</param>
    Guid Create(SequentialGuidType guidType);
}
