using System;
namespace Azzeton.Shared
{
    /// <summary>
    /// System Access
    /// </summary>
    public interface IAccess
    {
        /// <summary>
        /// Access Category
        /// </summary>
        string Category { get; }
        /// <summary>
        /// Access Code
        /// </summary>
        string Code { get; set; }
        /// <summary>
        /// Access Description
        /// </summary>
        string Description { get; set; }
        /// <summary>
        /// Hash Code
        /// </summary>
        /// <returns></returns>
        int GetHashCode();
        /// <summary>
        /// Access Title/Name
        /// </summary>
        string Name { get; set; }
        string ToString();
    }
}
