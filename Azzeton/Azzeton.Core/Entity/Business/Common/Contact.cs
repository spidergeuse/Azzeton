using System;
using System.Collections.Generic;
using System.Text;

namespace Azzeton.Core.Entity
{
    public abstract class Contact : GenericBase
    {
        /// <summary>
        /// Unique id of contact
        /// </summary>
        public int ContactId { get; set; }
        /// <summary>
        /// Id of owner
        /// </summary>
        public int OwnerId { get; set; }
        /// <summary>
        /// Type of owner
        /// </summary>
        public ContactOwnerType OwnerType { get; set; }
    }

}
