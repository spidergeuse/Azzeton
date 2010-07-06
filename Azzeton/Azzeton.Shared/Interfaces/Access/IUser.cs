using System;
using System.Collections.Generic;
namespace Azzeton.Shared
{
    public interface IUser
    {
        bool Equals(object obj);
        int GetHashCode();
        List<IGroup> Groups { get; set; }
        int Id { get; set; }
        bool IsActive { get; set; }
        bool IsLocked { get; set; }
        List<IGroup> NonGroups { get; set; }
        string Password { get; set; }
        string ResetAnswer { get; set; }
        string ResetQuestion { get; set; }
        List<IUserRight> Rights { get; set; }
        string ToString();
        string Username { get; set; }
    }
}
