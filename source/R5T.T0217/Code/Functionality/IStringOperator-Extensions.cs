using System;

using R5T.T0132;


namespace R5T.T0217.Extensions
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        /// <inheritdoc cref="ITargetFrameworkDirectoryName"/>
        public ITargetFrameworkDirectoryName ToTargetFrameworkDirectoryName(string value)
        {
            var output = new TargetFrameworkDirectoryName(value);
            return output;
        }
    }
}
