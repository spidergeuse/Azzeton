using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

namespace Azzeton.Shared
{
    /// <summary>
    /// Event supression
    /// </summary>
    public class EventSuppressor
    {
        private string _event;
        private Control _source;
        private EventHandlerList _sourceEventHandlerList;
        private FieldInfo _headFI;
        private Dictionary<object, Delegate[]> _handlers;
        private PropertyInfo _sourceEventsInfo;
        private Type _eventHandlerListType;
        private Type _sourceType;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="control">the control whose event is to be supressed</param>
        public EventSuppressor(Control control,string @event)
         {
             InitializeControl(control);
             this._event = @event;
         }
        /// <summary>
        /// Initialize variables
        /// Read events
        /// </summary>
        /// <param name="control">the control whose event is to be supressed</param>
        private void InitializeControl(Control control)
        {
            if (control == null) return;
                //throw new ArgumentNullException("control", "An instance of a control must be provided.");
            
            _source = control;
            _sourceType = _source.GetType();
            _sourceEventsInfo = _sourceType.GetProperty("Events", BindingFlags.Instance | BindingFlags.NonPublic);
            _sourceEventHandlerList = (EventHandlerList)_sourceEventsInfo.GetValue(_source, null);
            _eventHandlerListType = _sourceEventHandlerList.GetType();
            _headFI = _eventHandlerListType.GetField("head", BindingFlags.Instance | BindingFlags.NonPublic);
        }
        /// <summary>
        /// Build a list of registered delegate for the control
        /// </summary>
        private void BuildList()
        {
            _handlers = new Dictionary<object, Delegate[]>();
            object head = _headFI.GetValue(_sourceEventHandlerList);
            if (head != null)
            {
                Type listEntryType = head.GetType();
                FieldInfo delegateFI = listEntryType.GetField("handler", BindingFlags.Instance | BindingFlags.NonPublic);
                FieldInfo keyFI = listEntryType.GetField("key", BindingFlags.Instance | BindingFlags.NonPublic);
                FieldInfo nextFI = listEntryType.GetField("next", BindingFlags.Instance | BindingFlags.NonPublic);
                BuildListWalk(head, delegateFI, keyFI, nextFI);
            }
        }
        /// <summary>
        /// Build a slist of registerd delegates for the control
        /// </summary>
        /// <param name="entry"></param>
        /// <param name="delegateFI"></param>
        /// <param name="keyFI"></param>
        /// <param name="nextFI"></param>
        private void BuildListWalk(object entry, FieldInfo delegateFI, FieldInfo keyFI, FieldInfo nextFI)
        {
            if (entry != null)
            {
                Delegate dele = (Delegate)delegateFI.GetValue(entry);
                
                object key = keyFI.GetValue(entry);
                object next = nextFI.GetValue(entry);

                Delegate[] listeners = dele.GetInvocationList();
                if (listeners != null && listeners.Length > 0)
                    _handlers.Add(key, listeners);

                if (next != null)
                {
                    BuildListWalk(next, delegateFI, keyFI, nextFI);
                }
            }
        }
        /// <summary>
        /// Reassigns events
        /// </summary>
        public void Resume()
        {
            if (_handlers == null)return;
                //throw new ApplicationException("Events have not been suppressed.");

            foreach (KeyValuePair<object, Delegate[]> pair in _handlers)
            {
                for (int x = 0; x < pair.Value.Length; x++)
                    _sourceEventHandlerList.AddHandler(pair.Key, pair.Value[x]);
            }

            _handlers = null;
        }
        /// <summary>
        /// Supress an event
        /// </summary>
        /// <param name="control">the control whose event is to be supressed</param>
        /// <param name="event">name of event</param>
        public static void Suppress(Control control,string @event)
        {
            EventSuppressor _suppressor = new EventSuppressor(control,@event);
            _suppressor.Suppress();
        }
        /// <summary>
        /// Suppress an event
        /// </summary>
        public void Suppress()
        {
            if (_handlers != null) return;
                //throw new ApplicationException("Events are already being suppressed.");

            BuildList();

            foreach (KeyValuePair<object, Delegate[]> pair in _handlers)
            {
                for (int x = pair.Value.Length - 1; x >= 0; x--)
                {
                    if (pair.Value[x].Method.Name.ToLowerInvariant() == this._event)
                    {
                        _sourceEventHandlerList.RemoveHandler(pair.Key, pair.Value[x]);
                        break;
                    }
                }
            }
        }
    }
}