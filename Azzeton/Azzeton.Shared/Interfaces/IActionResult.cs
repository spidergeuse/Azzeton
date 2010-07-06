using System;

namespace Azzeton.Shared
{
    /// <summary>
    /// The result of an action/function
    /// </summary>
    public interface IActionResult
    {
        /// <summary>
        /// Exception, if any, of the function called
        /// </summary>
        Exception Exception { get; }
        /// <summary>
        /// Type of result return by an action/function
        /// </summary>
        ActionResult.ResultType Result { get; }
        /// <summary>
        /// Type of action
        /// </summary>
        ActionResult.ResultType ActionType { get; }
    }
}
