using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementXarelto.Core.Models {
    public class InfoTag {
        public int Id { get; set; }

        public int InformationId { get; set; }
        public Information? Information { get; set; }

        public string Tag { get; set; } = string.Empty;

        // Erklärung: Bestimmt, wie das Objekt in Listen (ListBox) angezeigt wird
        public override string ToString() {
            return Tag;
        }
    }
}
