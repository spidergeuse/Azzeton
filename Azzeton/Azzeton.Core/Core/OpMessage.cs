using System;
using System.Collections.Generic;
using System.Text;

namespace Azzeton.Core
{
    public class OpMessage
    {
        public string Description { get; set; }
        public MessageType MessageType { get; set; }
        public EntityType Target { get; set; }
        public EntityType Source { get; set; }
        public DateTime Stamp { get; set; }
        public OpMessage(MessageType messagetype, EntityType source, EntityType target)
        {
        }
    }
}
