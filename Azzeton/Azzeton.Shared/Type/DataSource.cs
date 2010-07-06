using System;
namespace Azzeton.Shared
{
    /// <summary>
    /// DataSource Object
    /// </summary>
    [Serializable()]
    public sealed class DataSource
    {
        public DataSource(string database) : this(database, "NewDataSource") 
        { }
        public DataSource(string database, string alias) : this(database, database, "", "", DataHostType.File) 
        { }
        public DataSource(string database, string username, string password) : this(database,username,password,"NewDataSource", DataHostType.File) 
        { }
        public DataSource(string database, string username, string password, string alias) : this(database, database, username, password, DataHostType.File) 
        { }
        
        public DataSource(string host, string database, string username, string password, DataHostType hosttype) : this(host, database, username, password, hosttype, 0,"NewConnection")
        { }
        public DataSource(string host, string database, string username, string password, DataHostType hosttype, int port,string alias)
        {
            this.Host = host;
            this.Database = database;
            this.Username = username;
            this.Password = password;
            this.HostType = hosttype;
            this.Port = port;
        }
        
        public string Database { get; set; }
        public string Path { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
        public string Username { get; set; }
        public string Alias { get; set; }
        public bool Default { get; set; }
        public string Password{ get; set; }
        public DataHostType HostType { get; set; }
        public string UniqueID { get; set; }
        public override string ToString()
        {return this.Alias; }
        public override bool Equals(object obj)
        {
            DataSource _source = obj as DataSource;
            if (_source != null)
            {
                if (
                        /*compare all fields - not elegant but does the work*/
                       _source.Password     == this.Password &&
                       _source.Alias        == this.Alias &&
                       _source.Database     == this.Database &&
                       _source.Default      == this.Default &&
                       _source.Host         == this.Host &&
                       _source.Path         == this.Path &&
                       _source.Port         == this.Port &&
                       _source.UniqueID     == this.UniqueID &&
                       _source.Username     == this.Username
                    )
                    return true;


            }
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
