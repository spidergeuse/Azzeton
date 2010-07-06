using System;
using System.Collections.Generic;
namespace Azzeton.Shared
{
    public interface IUserSetting
    {
        string Setting { get; set; }
        int UserID { get; set; }
        object Value { get; set; }
    }

}
