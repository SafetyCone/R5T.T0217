using System;


namespace R5T.T0217.F001
{
    public class TargetFrameworkDirectoryNameOperator : ITargetFrameworkDirectoryNameOperator
    {
        #region Infrastructure

        public static ITargetFrameworkDirectoryNameOperator Instance { get; } = new TargetFrameworkDirectoryNameOperator();


        private TargetFrameworkDirectoryNameOperator()
        {
        }

        #endregion
    }
}
