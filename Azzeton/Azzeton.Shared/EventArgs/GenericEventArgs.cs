using System;
namespace Azzeton.Shared
{
    [Serializable()]
    public class GenericEventArgs : System.EventArgs
    {
        public object Object{ get; private set; }
        public bool HasErrors { get; private set; }
        public GenericEventArgs(bool haserrors, object @object)
        {
            this.HasErrors = haserrors;
            this.Object = @object;
        }
        public GenericEventArgs(ActionResult result)
        {
            this.Result = result;
        }
        public T GetActualObject<T>()
        {
            T _obj = Activator.CreateInstance<T>();
            _obj = (T)this.Object;
            return _obj;
        }
        public ActionResult Result { get; private set; }
    }
}
