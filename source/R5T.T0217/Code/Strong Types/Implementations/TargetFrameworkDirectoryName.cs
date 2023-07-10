using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0217
{
    /// <inheritdoc cref="ITargetFrameworkDirectoryName"/>
    [StrongTypeImplementationMarker]
    public class TargetFrameworkDirectoryName : TypedBase<string>, IStrongTypeMarker,
        ITargetFrameworkDirectoryName
    {
        public TargetFrameworkDirectoryName(string value)
            : base(value)
        {
        }
    }
}