using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Reflection;

namespace Azzeton.Shared
{
    public class ActionResult : IActionResult
    {
        public enum ResultType
        {
            Success,
            Fail,
            Exception
        }
        public ActionResult(ResultType resulttype)
        {
            this.Result = resulttype;
        }
        public ActionResult(object returnobject, ResultType resulttype):this(resulttype)
        {
            this.Result = resulttype;
            this.ReturnObject = returnobject;
        }
        public ActionResult(object returnobject, ResultType resulttype, Exception exception)
        {
            this.Result = resulttype;
            this.ReturnObject = returnobject;
            this.Exception = exception;
        }
        public object ReturnObject { get; private set; }
        public ResultType Result { get; private set; }
        public Exception Exception { get; private set; }
        public ActionType ActionType { get; private set; }
    }
    public enum ActionType
    {
        Save,
        Update,
        Delete,
        Select
    }
}
