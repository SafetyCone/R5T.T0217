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
            // If windows, the directory name is just the non windows part.
            var isWindows = Instances.TargetFrameworkMonikerOperator.Is_WindowsSpecific(targetFrameworkMoniker);
            if (isWindows)
            {
                var nonWindowsMoniker = Instances.TargetFrameworkMonikerOperator.Get_NonWindowsMoniker(targetFrameworkMoniker);

                // The directory name is just the moniker name.
                var output = nonWindowsMoniker.Value
                    .ToTargetFrameworkDirectoryName();

                return output;
            }
            else
            {
                // The directory name is just the moniker name.
                var output = targetFrameworkMoniker.Value
                    .ToTargetFrameworkDirectoryName();

                return output;
            }
        }
    }
}
