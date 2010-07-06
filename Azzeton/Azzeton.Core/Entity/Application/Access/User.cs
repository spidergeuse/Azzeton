using System;
using System.Data;
using System.Collections.ObjectModel;
using System.Globalization;
using Azzeton.Shared;


namespace Azzeton.Core.Entity
{
    [Serializable()]
    public class User 
	{
        private Collection<IUserRight> _rights;
        private Collection<IGroup> _groups;
        private Collection<IGroup> _nongroups;
        private Collection<IUserSetting> _settings;
       
        /// <summary>
        /// Initialize User
        /// </summary>
        public User()
        {
            this._groups = new Collection<IGroup>();
            this._nongroups = new Collection<IGroup>();
            this._rights = new Collection<IUserRight>();
            this._settings = new Collection<IUserSetting>();
        }
        /// <summary>
        /// Initialize User
        /// </summary>
        /// <param name="id">Id of user</param>
        /// <param name="username">Username of user</param>
        /// <param name="password">Password of user</param>
        /// <param name="islocked">Lock status of user</param>
        /// <param name="isactive">Active status of user</param>
        /// <param name="resetquestion">Password reset question</param>
        /// <param name="resetanswer">Password reset answer</param>
        public User(int id, string username, string password, bool islocked, bool isactive, string resetquestion, string resetanswer):this()
        {
            this.Id = id;
            this.Username = username;
            this.Password = password;
            this.IsLocked = islocked;
            this.IsActive = isactive;
            this.ResetQuestion = resetquestion;
            this.ResetAnswer = resetanswer;
        }
        /// <summary>
        /// Id of user
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Username of user
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// Password of user
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Lock stautus of user
        /// </summary>
        public bool IsLocked { get; set; }
        /// <summary>
        /// Active status of user
        /// </summary>
        public bool IsActive { get; set; }
        /// <summary>
        /// Question to ask in order to reset password
        /// </summary>
        public string ResetQuestion { get; set; }
        /// <summary>
        /// Answer to reset question
        /// </summary>
        public string ResetAnswer { get; set; }
        /// <summary>
        /// Rights available to user
        /// </summary>
        public Collection<IUserRight> Rights { get { return _rights; } }
        /// <summary>
        /// Groups that user belongs to
        /// </summary>
        public Collection<IGroup> Groups { get { return _groups; } }
        /// <summary>
        /// Groups that user does not belong to
        /// </summary>
        public Collection<IGroup> NonGroups { get { return _nongroups; } }
        /// <summary>
        /// Application/System settings peculiar to this user
        /// </summary>
        public Collection<IUserSetting> Settings { get { return _settings; } }
        /// <summary>
        /// String representation of User object
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format(System.Globalization.CultureInfo.InvariantCulture, "{0}", this.Username);
        }
    }
    public class UserManager 
    {

    }
}