using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Data;

namespace Azzeton.Shared
{

    public interface IDataHost
    {
        /// <summary>
        /// Id of last insterted record
        /// </summary>
        int LastInsertID { get; }
        /// <summary>
        /// True if the last operation resulted in an error.
        /// False otherwise
        /// </summary>
        bool HasErrors { get; }
        /// <summary>
        /// Initialize a DataHost Manager
        /// </summary>
        /// <param name="DataHostAuthentication">Authentication to the host to be accessed</param>
        void Initialize(AccessCredentials credentials);
        /// <summary>
        /// Test connection to datasource
        /// </summary>
        /// <returns>Action result object containing details of operaton</returns>
        ActionResult TestConnection();
        /// <summary>
        /// Setus up datasource
        /// </summary>
        /// <returns>Action result object containing details of operaton</returns>
        ActionResult Setup();
        /// <summary>
        /// Back's up datasource to a file
        /// </summary>
        /// <param name="path">Backup path</param>
        /// <returns>Action result object containing details of operaton</returns>
        ActionResult Backup(string path);
        /// <summary>
        /// Removes database and contents
        /// </summary>
        /// <returns>Action result object containing details of operaton</returns>
        ActionResult TearDown();
        /// <summary>
        /// Execute a command that returns no value
        /// </summary>
        /// <param name="command">The command</param>
        /// <returns>Action result object containing details of operaton</returns>
        ActionResult ProcessCommand(DataCommand command);
        /// <summary>
        /// Execute a command that returns no value
        /// </summary>
        /// <param name="command">The command</param>
        /// <param name="reader">DataReader object to hold returned data</param>
        /// <returns>Action result object containing details of operaton</returns>
        ActionResult ProcessCommand(DataCommand command, ref IDataReader reader);
        /// <summary>
        /// Execute a command that returns no value
        /// </summary>
        /// <param name="command">The command</param>
        /// <param name="reader">object to hold returned data</param>
        /// <returns>Action result object containing details of operaton</returns>
        ActionResult ProcessCommand(DataCommand command, ref object value);
        /// <summary>
        /// Execute a command that returns no value
        /// </summary>
        /// <param name="command">The command</param>
        /// <param name="reader">DataTable object to hold returned data</param>
        /// <returns>Action result object containing details of operaton</returns>
        ActionResult ProcessCommand(DataCommand command, ref DataTable table);
    }
}
