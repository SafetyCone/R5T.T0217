using System;


namespace R5T.T0217.Extensions
{
    public static class StringExtensions
    {
        /// <inheritdoc cref="IStringOperator.ToTargetFrameworkDirectoryName(string)"/>
        public static ITargetFrameworkDirectoryName ToTargetFrameworkDirectoryName(this string value)
        {
            return Instances.StringOperator_Extensions.ToTargetFrameworkDirectoryName(value);
        }
    }
}
