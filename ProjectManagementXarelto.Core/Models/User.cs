using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementXarelto.Core.Models {
    public class User {
        public int Id { get; set; }
        public string DisplayName { get; set; } = string.Empty;
        public RoleType Role { get; set; }
    }
}
