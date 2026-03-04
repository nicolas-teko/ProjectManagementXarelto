using Microsoft.EntityFrameworkCore;
using ProjectManagementXarelto.Core.Common;
using ProjectManagementXarelto.Core.Models;

namespace ProjectManagementXarelto.App {
    public partial class ProjectsForm : Form {
        public ProjectsForm() {
            InitializeComponent();
             
            this.Load += ProjectsForm_Load;                          // Event ausführen, wenn das Form geladen wird
            btnNewProject.Click += BtnNewProject_Click;              // Klick-Event für "Neues Projekt"-Button
            dgvProjects.CellDoubleClick += DgvProjects_CellDoubleClick; // Erklärung: Doppelklick auf Projekt-Zeile
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

            dgvProjects.DataSource = viewData;
            dgvProjects.Columns["Id"].Visible = false;   // ID-Spalte ausblenden

            // Spalten passen sich an und füllen die Breite
            dgvProjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProjects.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dgvProjects.DataSource = viewData;                       // DataGridView mit Projektdaten füllen
        }

        private void BtnNewProject_Click(object? sender, EventArgs e) {
            // Erklärung: Formular zum Erstellen eines neuen Projekts öffnen
            using var form = new ProjectCreateForm();

            // Erklärung: Wenn der Dialog mit OK beendet wird, Projekte neu laden
            if (form.ShowDialog(this) == DialogResult.OK) {
                LoadProjects();                                // Erklärung: DataGridView nach dem Speichern aktualisieren
            }
        }

        private void DgvProjects_CellDoubleClick(object? sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0)
                return; // Erklärung: Header-Zeile ignorieren

            // Erklärung: Zeile holen, auf die doppelt geklickt wurde
            var row = dgvProjects.Rows[e.RowIndex];

            // Erklärung: Projekt-Id aus der Spalte "Id" lesen
            if (row.Cells["Id"].Value is int projectId) {
                using var form = new ProjectDetailsForm(projectId); // Erklärung: Detail-Form für dieses Projekt erzeugen
                form.ShowDialog(this);                              // Erklärung: Modal anzeigen

                LoadProjects(); // Erklärung: Nach dem Schließen Projekte neu laden (falls sich etwas geändert hat)
            }
        }

    }
   
}
