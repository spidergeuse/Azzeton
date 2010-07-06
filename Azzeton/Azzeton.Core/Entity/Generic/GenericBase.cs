using System;
using System.Collections.ObjectModel;
using System.Text;

namespace Azzeton.Core.Entity
{
    /// <summary>
    /// Generic abstract class for simple data objects
    /// </summary>
    [Serializable()]
    public abstract class GenericBase
    {
        /// <summary>
        /// Time Stamp / Date Last Modified
        /// </summary>
        public DateTime Stamp { get; set; }
        /// <summary>
        /// Any data of importance to this object
        /// </summary>
        public object Tag { get; set; }
        /// <summary>
        /// Visibility of object. This is useful in the 
        /// case of implementing controlled delete
        /// where object could be hidden to assume deleted 
        /// until completely deleted.
        /// </summary>
        public bool Visible { get; set; }
        /// <summary>
        /// Constructor
        /// </summary>
        protected GenericBase() 
        {
            this.Tag = null;
        }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="stamp">Last Modified</param>
        protected GenericBase(DateTime stamp):this()
        {
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
        protected GenericBase(DateTime stamp, bool visible): this(stamp)
        {
            this.Visible = visible;
        }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="stamp">Last Modified</param>
        /// <param name="visible">Visibility</param>
        /// <param name="tag">Tag</param>
        protected GenericBase(DateTime stamp, bool visible, object tag)  : this(stamp, visible)
        {
            this.Tag = Tag;
        }
    }
}