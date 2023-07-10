using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0217
{
    /// <summary>
    /// Strongly-types a string as a directory whose name is a .NET target framework (like "net6.0").
    /// </summary>
    [StrongTypeMarker]
    public interface ITargetFrameworkDirectoryName : IStrongTypeMarker,
        ITyped<string>
    {
    }
}