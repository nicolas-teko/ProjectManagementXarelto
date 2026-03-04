using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementXarelto.Core.Models {
    public enum LinkType {
        Image = 1,
        Document = 2
    }
    public class InfoLink {
        public int Id { get; set; }

        public int InformationId { get; set; }
        public Information? Information { get; set; }

        public LinkType Type { get; set; }
        public string Url { get; set; } = string.Empty;

        public override string ToString() {
            return $"{Type}: {Url}";
        }
    }
}