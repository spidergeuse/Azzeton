using System;
using System.Collections.ObjectModel;
using System.Text;

namespace Azzeton.Core.Entity
{
    /// <summary>
    /// Generic  class for simple data objects
    /// </summary>
    [Serializable()]
    public class Group : GenericBase
    {
        private Collection<GroupRight> _rights;
        private Collection<User> _members;
        private Collection<User> _nonmembers;

        /// <summary>
        /// Id of object
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Name of object
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Description of object
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Rights available to user
        /// </summary>
        public Collection<IUserRight> Rights { get { return _rights; } }
        /// <summary>
        /// Groups that user belongs to
        /// </summary>
        public Collection<User> Members { get { return _members; } }
        /// <summary>
        /// Groups that user does not belong to
        /// </summary>
        public Collection<User> NonMembers { get { return _nonmembers; } }
       
        /// <summary>
        /// Initialize Group
        /// </summary>
        public Group()
        {
            this._members = new Collection<User>();
            this._nonmembers = new Collection<User>();
            this._rights = new Collection<GroupRight>();
        }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="name">Name</param>
        /// <param name="description">Description</param>
        /// <param name="stamp">Last Modified</param>
        public Group(int id, string name, string description, DateTime stamp)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Stamp = stamp;
            this.Tag = null;
        }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="name">Name</param>
        /// <param name="description">description</param>
        /// <param name="stamp">Last Modified</param>
        /// <param name="visible">Visibility</param>
        public Group(int id, string name, string description, DateTime stamp, bool visible)
            : this(id, name, description, stamp)
        {
            this.Visible = visible;
        }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="name">Name</param>
        /// <param name="description">description</param>
        /// <param name="stamp">Last Modified</param>
        /// <param name="visible">Visibility</param>
        /// <param name="tag">Tag</param>
        public Group(int id, string name, string description, DateTime stamp, bool visible, object tag)
            : this(id, name, description, stamp, visible)
        {
            this.Tag = Tag;
        }
        /// <summary>
        /// Override ToString() of base
        /// Return Name and Description
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Name;
        }
        /// <summary>
        /// Override Equal of base
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            Group _simple = obj as Group;
            if (_simple != null)
                return (this.Id == this.Id && this.Name == _simple.Name);
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}