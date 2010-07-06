using System;
using System.Collections.Generic;
using System.Text;

namespace Azzeton.Entity.Core
{
    public class OpMessageEventArgs : EventArgs
    {
        public OpMessage Message { get; private set; }
        public EntityType Source { get { return this.Message.Source; } }
        public OpMessageEventArgs(OpMessage message)
        {
            this.Message = message;
        }
    }
}
