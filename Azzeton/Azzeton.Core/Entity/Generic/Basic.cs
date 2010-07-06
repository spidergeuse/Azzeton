using System;
using System.Collections.ObjectModel;
using System.Text;

namespace Azzeton.Core.Entity
{
    /// <summary>
    /// Generic abstract class for simple data objects
    /// </summary>
    [Serializable()]
    public abstract class Basic : GenericBase
    {
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
        /// Constructor
        /// </summary>
        protected Basic() 
        {
            this.Tag = null;
        }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="name">Name</param>
        /// <param name="description">Description</param>
        /// <param name="stamp">Last Modified</param>
        protected Basic(int id, string name, string description, DateTime stamp)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Stamp = stamp;
        }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="name">Name</param>
        /// <param name="description">description</param>
        /// <param name="stamp">Last Modified</param>
        /// <param name="visible">Visibility</param>
        protected Basic(int id, string name, string description, DateTime stamp, bool visible)
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
        protected Basic(int id, string name, string description, DateTime stamp, bool visible, object tag)
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
            Basic _simple = obj as Basic;
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