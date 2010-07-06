using System;
using System.Drawing;
using System.Collections.ObjectModel;
using System.Text;
using System.Globalization;
namespace Azzeton.Core.Entity
{
    [Serializable()]
    public class Product : GenericBase
    {
        /// <summary>
        /// Code of the product
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// Name of the product
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Description of object
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Image of product
        /// </summary>
        public Image Image { get; set; }
        /// <summary>
        /// Initialize product
        /// </summary>
        public Product()
        {

        }
        /// <summary>
        /// Initialize Product
        /// </summary>
        /// <param name="name">name of product</param>
        /// <param name="code">product code</param>
        public Product(string name, string code):this()
        {
            this.Name = name;
            this.Code = code;
        }
        /// <summary>
        /// Initialize Product
        /// </summary>
        /// <param name="name">name of product</param>
        /// <param name="code">product code</param>
        /// <param name="description">description of product</param>
        public Product(string name, string code, string description):this(name,code)
        {
            this.Description = description;
        }
        /// <summary>
        /// Initialize Product
        /// </summary>
        /// <param name="name">name of product</param>
        /// <param name="code">product code</param>
        /// <param name="description">description of product</param>
        /// <param name="image">image/picture of product</param>
        public Product(string name, string code, string description, Image image):this(name,code,description)
        {
            this.Image = image;
        }
        /// <summary>
        /// String representation of access
        /// </summary>
        /// <returns>Name and Description</returns>
        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0}\n[{1}]", this.Name, this.Code);
        }
    }
    public class ProductManager
    {
    }
}
