using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Azzeton.Shared;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace Azzeton.MySQL
{
    public class MySQL : IDataHost, IModule
    {
        private AccessCredentials _credentials;
        private string _connection_string;
        #region IDataHost Members

        public int LastInsertID
        {
            get { throw new NotImplementedException(); }
        }
        public bool HasErrors
        {
            get { throw new NotImplementedException(); }
        }
        public void Initialize(AccessCredentials credentials)
        {
           
            this._credentials = credentials;
            this._connection_string = string.Format(CultureInfo.InvariantCulture, 
                                                "Data Source={0};User Id={1};Password={2}; Pooling=false; ",
                                                credentials.Host,
                                                credentials.Username,
                                                credentials.Password);
            if (!string.IsNullOrEmpty(_credentials.Database))
                this._connection_string += " Database = " + _credentials.Database + ";";

            if (!string.IsNullOrEmpty(_credentials.Port))
                this._connection_string += "Port = " + _credentials.Port + ";";
            

        }
        public ActionResult TestConnection()
        {
            try
            {
                using (MySqlConnection _cn = new MySqlConnection(_connection_string))
                {
                    _cn.Open();
                    _cn.Close();
                    return new ActionResult(ActionResult.ResultType.Success);
                }

            }
            catch
            {
                /*raise native exception here to be handled by caller*/
                return new ActionResult(ActionResult.ResultType.Exception);
            }
        }
        public ActionResult Setup()
        {
            throw new NotImplementedException();
        }
        public ActionResult Backup(string path)
        {
            throw new NotImplementedException();
        }
        public ActionResult TearDown()
        {
            throw new NotImplementedException();
        }
        public ActionResult ProcessCommand(DataCommand command)
        {

            try
            {
                using (MySqlConnection _cn = new MySqlConnection(_connection_string))
                {
                    using (MySqlCommand _cm = new MySqlCommand(command.CommandText, _cn))
                    {
                        
                        foreach (DataParameter p in command.Parameters)
                        {
                            _cm.Parameters.AddWithValue("@" + p.Name, p.Value);
                        }
                        _cm.CommandType = command.CommandType;
                        MySqlTransaction _tn = _cn.BeginTransaction(System.Data.IsolationLevel.Serializable);
                        try
                        { 
                            _cn.Open();
                            _cm.ExecuteNonQuery();
                            _tn.Commit(); 
                            _cn.Close();
                        }
                        catch 
                        { 
                            _tn.Rollback();
                        }
                        return new ActionResult(ActionResult.ResultType.Success);
                    }
                }

            }
            catch
            {
                /*raise native exception here to be handled by caller*/
                return new ActionResult(ActionResult.ResultType.Exception);
            }


        }
        public ActionResult ProcessCommand(DataCommand command, ref System.Data.IDataReader reader)
        {
            throw new NotImplementedException();
        }
        public ActionResult ProcessCommand(DataCommand command, ref object value)
        {
            throw new NotImplementedException();
        }
        public ActionResult ProcessCommand(DataCommand command, ref System.Data.DataTable table)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region IModule Members
        public ModuleInformation PluginInformation
        {
            get { throw new NotImplementedException(); }
        }
        public object CreateInstance()
        {
            throw new NotImplementedException();
        }
        public object CreateInstance(params object parameters)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
