using System;

using R5T.T0132;
using R5T.T0218;

using R5T.T0217.Extensions;


namespace R5T.T0217.F001
{
    [FunctionalityMarker]
    public partial interface ITargetFrameworkDirectoryNameOperator : IFunctionalityMarker
    {
        public ITargetFrameworkDirectoryName Get_TargetFrameworkDirectoryName(ITargetFrameworkMoniker targetFrameworkMoniker)
        {
            // The directory name is just the moniker name.
            var output = targetFrameworkMoniker.Value
                .ToTargetFrameworkDirectoryName();

            return output;
        }
    }
}
