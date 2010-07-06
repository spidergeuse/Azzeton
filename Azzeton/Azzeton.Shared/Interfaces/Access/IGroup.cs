using System;
using System.Collections.Generic;
namespace Azzeton.Shared
{
    public interface IGroup
    {
        int Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        List<IUser> Members { get; set; }
        List<IUser> NonMembers { get; set; }
        List<IGroupRight> Rights { get; set; }
        DateTime Stamp { get; set; }
        string ToString();
        int UserID { get; set; }
    }
}
