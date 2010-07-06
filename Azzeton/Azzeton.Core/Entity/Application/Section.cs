using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Azzeton.Core.Entity
{
    /// <summary>
    /// Represent a section of the application
    /// </summary>
    public class Section
    {
        /// <summary>
        /// Code for the section
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// Name of the section
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Description of the section
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Initialize section object
        /// </summary>
        /// <param name="code">section code</param>
        /// <param name="name">name of section</param>
        /// <param name="description">description of section</param>
        public Section(string code, string name, string description)
        {
            this.Code = code;
            this.Name = name;
            this.Description = description;
        }
        /// <summary>
        /// String representation of section
        /// </summary>
        /// <returns>Name and Description</returns>
        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0}\n[{1}]", this.Name, this.Code);
        }
    }
}
