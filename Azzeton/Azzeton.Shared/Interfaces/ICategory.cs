using System;
namespace Azzeton.Core.Entity
{
    interface ICategory
    {
        string Description { get; set; }
        bool Equals(object obj);
        int GetHashCode();
        int Id { get; set; }
        string Name { get; set; }
        int ParentID { get; set; }
        string ToString();
    }
}
