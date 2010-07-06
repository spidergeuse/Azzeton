using System;
using System.Drawing;
using System.Collections.ObjectModel;
namespace Azzeton.Core.Entity
{
    /// <summary>
    /// Category of object
    /// </summary>
    [Serializable()]
    public class Category: GenericBase
    {
        /// <summary>
        /// Id of object
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Parent category's Id
        /// </summary>
        public int ParentId { get; set; }
        /// <summary>
        /// Name of object
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Image of category
        /// </summary>
        public Image Image { get; set; }
        /// <summary>
        /// Description of object
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Constructor
        /// </summary>
        public Category() { }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="name">Name</param>
        /// <param name="description">Description</param>
        /// <param name="stamp">Last Modified</param>
        public Category(int id, string name, string description, DateTime stamp)
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
        public Category(int id, string name, string description, DateTime stamp, bool visible): this(id,name,description,stamp)
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
        public Category(int id, string name, string description, DateTime stamp, bool visible, object tag)  : this(id, name, description, stamp, visible)
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
            Category _simple = obj as Category;
            if (_simple != null)
                return (this.Id == this.Id && this.Name == _simple.Name);
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
    public class CategoryManager
    {
    }
}
