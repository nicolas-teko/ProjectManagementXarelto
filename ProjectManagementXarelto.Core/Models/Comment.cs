using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementXarelto.Core.Models;

public class Comment {
    public int Id { get; set; }

    public int InformationId { get; set; }
    public Information? Information { get; set; }

    public string Text { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; }
    public int CreatedByUserId { get; set; }

    public override string ToString()
        => $"{CreatedAt:yyyy-MM-dd HH:mm} - {Text}";
}
