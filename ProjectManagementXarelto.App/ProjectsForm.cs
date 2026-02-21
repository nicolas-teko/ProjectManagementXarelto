using Microsoft.EntityFrameworkCore;
using ProjectManagementXarelto.Core.Common;
using ProjectManagementXarelto.Core.Models;

namespace ProjectManagementXarelto.App {
    public partial class ProjectsForm : Form {
        public ProjectsForm() {
            InitializeComponent();
             
            this.Load += ProjectsForm_Load;                          // Event ausführen, wenn das Form geladen wird
            btnNewProject.Click += BtnNewProject_Click;              // Klick-Event für "Neues Projekt"-Button
        }

        private void ProjectsForm_Load(object? sender, EventArgs e) {
            var user = SessionContext.CurrentUser;                   // Aktuell eingeloggten Benutzer aus Session holen

            if (user == null) {
                MessageBox.Show("Kein Benutzer angemeldet.");        // Sicherheitscheck
                Close();
                return;
            }

            lblCurrentUser.Text =
                $"Angemeldet als: {user.DisplayName} ({user.Role})"; // Benutzername im Label anzeigen

            btnNewProject.Visible =
                user.Role == RoleType.ProjectLead;                   // Button nur für Projektleiter sichtbar

            LoadProjects();                                          // Projektliste in das DataGridView laden
        }

        private void LoadProjects() {
            var projects = Program.DbContext.Projects
                .Include(p => p.ProjectLeadUser)                     // Projektleiter direkt mitladen (JOIN)
                .OrderBy(p => p.Name)                                // Projekte alphabetisch sortieren
                .ToList();

            var viewData = projects.Select(p => new                  // Anzeigeobjekt für DataGridView erzeugen
            {
                p.Id,
                p.Name,
                p.CustomerName,
                Projektleiter = p.ProjectLeadUser != null
                    ? p.ProjectLeadUser.DisplayName
                    : "",
                p.CreatedAt
            }).ToList();

            dgvProjects.DataSource = viewData;                       // DataGridView mit Projektdaten füllen
        }

        private void BtnNewProject_Click(object? sender, EventArgs e) {
            MessageBox.Show("Hier später: Neues Projekt erstellen."); // Platzhalter für Create-Form
        }
    } 
}
