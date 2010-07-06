using System;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Text;
using Azzeton.Shared;
namespace Azzeton.Core
{
    public static class CoreMessageStack
    {
        public static event OpMessageDispatchedEventHandler MessageDispatched;
        public static Stack<OpMessage> OpStack = new Stack<OpMessage>();
        public static void Push(OpMessage message)
        {
            OpStack.Push(message);
            MessageDispatched(new OpMessageEventArgs(message));
        }
    }
    public delegate void OpMessageDispatchedEventHandler(OpMessageEventArgs e);
}
