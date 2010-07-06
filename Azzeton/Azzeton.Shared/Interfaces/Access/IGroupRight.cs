using System;
using System.Collections.Generic;
namespace Azzeton.Shared
{
    public interface IGroupRight
    {
        int CabinetID { get; set; }
        int GroupID { get; set; }
        string RightCode { get; set; }
    }
}
