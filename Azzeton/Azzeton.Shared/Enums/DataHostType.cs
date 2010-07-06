using System;
using System.Collections.Generic;
using System.Text;

namespace Azzeton.Shared
{
    /// <summary>
    /// Specifies the type of DataHost
    /// Server: Server based host like SQL Server, MySQL, Oracle etc.
    /// File: Ms Access
    /// </summary>
    public enum DataHostType
    {
        /// <summary>
        /// Files based host like Ms Access, Ms SQL Server CE
        /// </summary>
        File,
        /// <summary>
        /// Server based host (RDBMS like MySQL Server, Ms SQL Server, Oracle, PosgreSQL)
        /// </summary>
        Server
    }
}
