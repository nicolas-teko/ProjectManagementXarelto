using System.ComponentModel.DataAnnotations;
using ProjectManagementXarelto.Core.Models;

namespace ProjectManagementXarelto.Web.Models;

public sealed class ProjectFormModel
{
    [Required(ErrorMessage = "Bitte gib einen Projektnamen ein.")]
    [StringLength(200)]
    [Display(Name = "Projektname")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Bitte gib einen Kunden ein.")]
    [StringLength(200)]
    [Display(Name = "Kunde")]
    public string CustomerName { get; set; } = string.Empty;

    [Display(Name = "Projektbeschreibung")]
    public string InitialDescription { get; set; } = string.Empty;
}

public sealed class InformationFormModel
{
    [Required(ErrorMessage = "Der Informationstext darf nicht leer sein.")]
    [Display(Name = "Information")]
    public string Text { get; set; } = string.Empty;
}

public sealed class ProjectListItem
{
    public int Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public string CustomerName { get; init; } = string.Empty;
    public string ProjectLeadName { get; init; } = string.Empty;
    public DateTime CreatedAt { get; init; }
    public int InformationCount { get; init; }
}

public sealed class ProjectsIndexViewModel
{
    public string UserName { get; init; } = string.Empty;
    public bool CanCreateProjects { get; init; }
    public IReadOnlyList<ProjectListItem> Projects { get; init; } = [];
}

public sealed class InformationListItem
{
    public int Id { get; init; }
    public string Text { get; init; } = string.Empty;
    public DateTime CreatedAt { get; init; }
    public DateTime? UpdatedAt { get; init; }
    public IReadOnlyList<string> Tags { get; init; } = [];
    public int CommentCount { get; init; }
    public int LinkCount { get; init; }
}

public sealed class ProjectDetailsViewModel
{
    public Project Project { get; init; } = null!;
    public IReadOnlyList<InformationListItem> Informations { get; init; } = [];
    public IReadOnlyList<string> AvailableTags { get; init; } = [];
    public string? ActiveTag { get; init; }
}

public sealed class InformationEditViewModel
{
    public Information Information { get; init; } = null!;
    public InformationFormModel Form { get; init; } = new();
}
