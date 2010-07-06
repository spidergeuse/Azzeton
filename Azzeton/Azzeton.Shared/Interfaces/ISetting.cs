using System;
using System.Collections.Generic;
namespace Azzeton.Shared
{
    public interface IConfiguration 
    {
        string Title { get; set; }
        string Description { get; set; }
        object Value { get; set; }
    }
}
