using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class AppUser
    {
        public int ID { get; set; }
        // private int MyProperty1 { get; set; }
        // internal int MyProperty2 { get; set; }

        // public string UserName { get; set; } = ""; Not good practice, instead use 'Required'
        // above turns warning when Nullable property is enable
        public required string UserName { get; set; }

    }
}