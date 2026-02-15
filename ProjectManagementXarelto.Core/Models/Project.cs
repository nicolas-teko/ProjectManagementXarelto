using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementXarelto.Core.Models {
    public class Project {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;
        public string CustomerName { get; set; } = string.Empty;
        public string InitialDescription { get; set; } = string.Empty;

        public int ProjectLeadUserId { get; set; }
        public User? ProjectLeadUser { get; set; }

        public DateTime CreatedAt { get; set; }
        public int CreatedByUserId { get; set; }

        public ICollection<Information> Informations { get; set; } = new List<Information>();
    }
}
