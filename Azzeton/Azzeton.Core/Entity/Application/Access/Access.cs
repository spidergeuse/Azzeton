using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Text;
using System.Globalization;
using Azzeton.Shared;

namespace Azzeton.Core.Entity
{
    [Serializable()]
    public sealed class Access 
    {
        /// <summary>
        /// Initialize Access
        /// </summary>
        public Access()
        {
        }
        /// <summary>
        /// Initialize Access
        /// </summary>
        /// <param name="name">Name of access</param>
        /// <param name="description">Description of access</param>
        /// <param name="sectioncode">Section code</param>
        /// <param name="code">Access Code</param>
        public Access(string name, string description, string sectioncode, string code):this()
        {
            this.Name = name;
            this.Description = description;
            this.SectionCode = sectioncode;
            this.Code = code;
        }
        /// <summary>
        /// Name of access
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Description of access
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Section code
        /// </summary>
        public string SectionCode { get; private set; }
        /// <summary>
        /// Access code
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// String representation of access
        /// </summary>
        /// <returns>Name and Description</returns>
        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0}\n[{1}]", this.Name, this.Code);
        }
    }
    public class AccessManager : MarshalByRefObject
    {
        public Collection<Access> AccessList
        {
            get
            {
                Collection<Access> _accessList = new Collection<Access>();
                if (_accessList == null)
                {
                    _accessList = new Collection<Access>();
                    _accessList.Add(new Access("Add Something", "Add Something's Description", "SEC_001", "USR_001"));
                }
                return _accessList;
            }
        }
        public Hashtable Sections { get; private set; }
        public AccessManager()
        {
            this.Sections = new Hashtable();
        }
        private void InitializeSection()
        {
            this.Sections.Add("SEC001",new Section("","",""));
        }
    }
}
