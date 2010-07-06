using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
namespace Azzeton.Shared
{
    [XmlRoot]
    [Serializable()]
    public class AccessCredentials
    {
        /// <summary>
        /// Name/IP of machine that hosts database. If file based database like
        /// MS Access, this value is the same as Database property
        /// </summary>
        public string Host { get; set; }
        /// <summary>
        /// Name/Filename of database to connect to 
        /// </summary>
        public string Database { get; set; }
        /// <summary>
        /// Username to access database
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// Password to access database
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Port to access database.
        /// Leave blank to assume default
        /// </summary>
        public string Port { get; set; }
        public AccessCredentials()
        { }
        public AccessCredentials(string host, string database, string username, string password, string port):this()
        {
            this.Host = host;
            this.Database = database;
            this.Username = username;
            this.Password = password;
            this.Port = port;
        }
    }
}
