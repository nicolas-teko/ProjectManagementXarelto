using ProjectManagementXarelto.Core.Common;
using ProjectManagementXarelto.Core.Models;
using ProjectManagementXarelto.Data.Context;

namespace ProjectManagementXarelto.App {
    public partial class ProjectCreateForm : Form {
        public ProjectCreateForm() {
            InitializeComponent();

            this.Load += ProjectCreateForm_Load;   // Erklärung: Beim Laden des Forms Init-Logik ausführen
            btnSave.Click += BtnSave_Click;        // Erklärung: Speichern-Button-Click behandeln
            btnCancel.Click += BtnCancel_Click;    // Erklärung: Abbrechen-Button-Click behandeln
        }

        private void ProjectCreateForm_Load(object? sender, EventArgs e) {
            var user = SessionContext.CurrentUser; // Erklärung: Aktuell eingeloggten Benutzer holen

            if (user == null) {
                MessageBox.Show("Kein Benutzer angemeldet.");
                DialogResult = DialogResult.Cancel;
                Close();
                return;
            }

            // Erklärung: Projektleiter ist der aktuell eingeloggte Benutzer
            lblProjectLead.Text = $"{user.DisplayName}";
        }

        private void BtnSave_Click(object? sender, EventArgs e) {
            var user = SessionContext.CurrentUser; // Erklärung: Aktuellen Benutzer holen

            if (user == null) {
                MessageBox.Show("Kein Benutzer angemeldet.");
                return;
            }

            // Erklärung: Einfache Validierung der Pflichtfelder
            if (string.IsNullOrWhiteSpace(txtName.Text)) {
                MessageBox.Show("Projektname ist erforderlich.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCustomer.Text)) {
                MessageBox.Show("Kunde ist erforderlich.");
                return;
            }

            // Erklärung: Neues Projektobjekt aus den Formfeldern erstellen
            var project = new Project {
                Name = txtName.Text.Trim(),
                CustomerName = txtCustomer.Text.Trim(),
                InitialDescription = txtInitialDescription.Text.Trim(),
                ProjectLeadUserId = user.Id,      // Erklärung: aktueller User ist Projektleiter
                CreatedAt = DateTime.UtcNow,      // Erklärung: Erstellungszeitpunkt
                CreatedByUserId = user.Id         // Erklärung: Ersteller-ID
            };

            // Erklärung: Projekt in die DB schreiben
            Program.DbContext.Projects.Add(project);
            Program.DbContext.SaveChanges();

            // Erklärung: Dialog mit OK beenden, damit aufrufende Form weiß: Speichern erfolgreich
            DialogResult = DialogResult.OK;
            Close();
        }

        private void BtnCancel_Click(object? sender, EventArgs e) {
            // Erklärung: Ohne Speichern schließen
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}