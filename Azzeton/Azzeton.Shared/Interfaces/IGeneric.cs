using System;
namespace Azzeton.Shared
{
    /// <summary>
    /// Generic base - must be implemented 
    /// by an abstract class
    /// </summary>
    public interface IGeneric
    {
        /// <summary>
        /// Description of item
        /// </summary>
        string Description { get; set; }
        /// <summary>
        /// Compares item to another object
        /// </summary>
        /// <param name="obj">object to compare with</param>
        /// <returns></returns>
        bool Equals(object obj);
        /// <summary>
        /// Gets hash code
        /// </summary>
        /// <returns>interger hash code</returns>
        int GetHashCode();
        /// <summary>
        /// Id of item
        /// </summary>
        int Id { get; set; }
        /// <summary>
        /// Name of item
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// Convert item to string
        /// </summary>
        /// <returns>String equivallent of item</returns>
        string ToString();
    }
}
