using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Data;
using Azzeton.Shared;
namespace Azzeton.Core.Entity
{
    /// <summary>
    /// Email Address
    /// </summary>
    public class Email:Contact
    {
        /// <summary>
        /// Email
        /// </summary>
        public string EmailAddress { get; set; }
        public Email() { }
        public Email(int contactid, string emailaddress):this()
        {
            this.ContactId = contactid;
            this.EmailAddress = emailaddress;
        }
        public Email(int id, string emailaddress, int OwnerId,  bool visible, DateTime stamp):this(id,emailaddress)
        {
            this.Visible = visible;
            this.Stamp = stamp;
        }
    }
    public class EmailManager 
    {
        public ActionResult Add(Email email)
        {
            List<DataParameter> _params = new List<DataParameter>();
            _params.Add(new DataParameter("Id", email.ContactId));
            _params.Add(new DataParameter("EmailAddress", email.EmailAddress));
            _params.Add(new DataParameter("OwnerId", email.OwnerId));
            _params.Add(new DataParameter("OwnerType", email.OwnerType));
            return CoreGlobals.CurrentHost.ProcessCommand(new DataCommand(_params, "sp_save_email"));
        }
        /// <summary>
        /// Edits/Updates entity
        /// </summary>
        /// <typeparam name="T">Type of entity</typeparam>
        /// <param name="entity">Entity</param>
        /// <returns>Action Result</returns>
        public ActionResult Edit(Email email)
        {
            List<DataParameter> _params = new List<DataParameter>();
            _params.Add(new DataParameter("Id", email.ContactId));
            _params.Add(new DataParameter("EmailAddress", email.EmailAddress));
            _params.Add(new DataParameter("OwnerId", email.OwnerId));
            _params.Add(new DataParameter("OwnerType", email.OwnerType));
            return CoreGlobals.CurrentHost.ProcessCommand(new DataCommand(_params, "sp_save_email"));
        }
        /// <summary>
        /// Delete/Removes entity
        /// </summary>
        /// <typeparam name="T">Type of entity</typeparam>
        /// <param name="entity">Entity</param>
        /// <returns>Action Result</returns>
        public ActionResult Delete(Email email)
        {
            List<DataParameter> _params = new List<DataParameter>();
            _params.Add(new DataParameter("Id", email.ContactId));
            return CoreGlobals.CurrentHost.ProcessCommand(new DataCommand(_params, "sp_delete_email"));
        }
        /// <summary>
        /// Gets/Retrieves 1 entity
        /// </summary>
        /// <typeparam name="T">Type of entity</typeparam>
        /// <param name="id">Id of entity</param>
        /// <returns>Returns an entity of specified type</returns>
        public Email GetSingle(string emailaddress)
        {
            IDataReader _reader = null;
            List<DataParameter> _params = new List<DataParameter>();
            _params.Add(new DataParameter("EmailAddress", emailaddress));
            CoreGlobals.CurrentHost.ProcessCommand(new DataCommand(_params, "sp_select_email"),ref _reader);
            if (_reader != null)
            {
                while (_reader.Read())
                {
                    Email _email = new Email();
                    _email.ContactId = (int)_reader["contactid"];
                    _email.OwnerId = (int)_reader["contactid"];
                    _email.OwnerType = (ContactOwnerType)_reader["contactid"];
                    _email.Visible = (bool)_reader["contactid"];
                    _email.Stamp = (DateTime)_reader["contactid"];
                    _email.Tag = (object)_reader["contactid"];
                    return _email;
                }
               
            }
            return null;
        }
        /// <summary>
        /// Gets a collection of entities
        /// </summary>
        /// <typeparam name="T">Type of entity</typeparam>
        /// <returns>Returns an entity of specified type</returns>
        public Email GetSingle(Collection<SearchParameter> criteria)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get a collection of entities
        /// </summary>
        /// <typeparam name="T">Type of entity</typeparam>
        /// <param name="criteria">Collection of search parameters</param>
        /// <returns>Returns an entity of specified type</returns>
        public Email GetSingle(params SearchParameter[] criteria)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Gets a collection of entities
        /// </summary>
        /// <typeparam name="T">Type of entity</typeparam>
        /// <returns>Collection of entities</returns>
        public Collection<Email> GetMultiple()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get a collection of entities
        /// </summary>
        /// <typeparam name="T">Type of entity</typeparam>
        /// <param name="criteria">Collection of search parameters</param>
        /// <returns>Collection of entities</returns>
        public Collection<Email> GetMultiple(Collection<SearchParameter> criteria)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get a collection of entities
        /// </summary>
        /// <typeparam name="T">Type of entity</typeparam>
        /// <param name="criteria">Comma seperated list of parameters</param>
        /// <returns>Collection of entities</returns>
        public Collection<Email> GetMultiple(params SearchParameter[] criteria)
        {
            throw new NotImplementedException();
        }
    }
}
