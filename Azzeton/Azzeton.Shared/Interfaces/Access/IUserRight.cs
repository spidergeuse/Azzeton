using System;
using System.Collections.Generic;
namespace Azzeton.Shared
{
    public interface IUserRight
    {
        int CabinetID { get; set; }
        string RightCode { get; set; }
        int UserID { get; set; }
    }
}
