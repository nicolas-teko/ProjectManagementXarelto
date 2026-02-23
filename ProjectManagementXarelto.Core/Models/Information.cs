using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementXarelto.Core.Models {
    public class Information {
        public int Id { get; set; }

        public int ProjectId { get; set; }
        public Project? Project { get; set; }

        public string Text { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; }
        public int CreatedByUserId { get; set; }

        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedByUserId { get; set; }

        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
        public ICollection<InfoTag> Tags { get; set; } = new List<InfoTag>();
        public ICollection<InfoLink> Links { get; set; } = new List<InfoLink>();

        public override string ToString() {
            // Erklärung: Text, wie die Information in Listen angezeigt wird
            return $"{CreatedAt:yyyy-MM-dd HH:mm} - {Text}";
        }
    }
}
