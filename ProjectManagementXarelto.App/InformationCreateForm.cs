using ProjectManagementXarelto.Core.Common;
using ProjectManagementXarelto.Core.Models;

namespace ProjectManagementXarelto.App {
    public partial class InformationCreateForm : Form {
        private readonly int _projectId; // Erklärung: Projekt, zu dem die Info gehört

        public InformationCreateForm(int projectId) {
            InitializeComponent();
            _projectId = projectId;                  // Erklärung: Projekt-Id speichern

            this.Load += InformationCreateForm_Load; // aktuell keine Logik nötig, aber vorbereitet
            btnSave.Click += BtnSave_Click;          // Erklärung: Klick auf "Speichern"
            btnCancel.Click += BtnCancel_Click;      // Erklärung: Klick auf "Abbrechen"
        }

        private void InformationCreateForm_Load(object? sender, EventArgs e) {
            // aktuell nichts zu tun – Platzhalter, falls du später z.B. Titel setzen willst
        }

        private void BtnSave_Click(object? sender, EventArgs e) {
            var user = SessionContext.CurrentUser; // Erklärung: aktuell eingeloggter Benutzer

            if (user == null) {
                MessageBox.Show("Kein Benutzer angemeldet.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtInfoText.Text)) {
                MessageBox.Show("Der Informationstext darf nicht leer sein.");
                return;
            }

            // Erklärung: neue Information aus den Formfeldern erzeugen
            var info = new Information {
                ProjectId = _projectId,
                Text = txtInfoText.Text.Trim(),
                CreatedAt = DateTime.UtcNow,
                CreatedByUserId = user.Id
            };

            Program.DbContext.Informations.Add(info); // Erklärung: Info in DbContext einfügen
            Program.DbContext.SaveChanges();          // Erklärung: in die DB schreiben

            DialogResult = DialogResult.OK;           // Erklärung: Erfolg melden
            Close();
        }

        private void BtnCancel_Click(object? sender, EventArgs e) {
            DialogResult = DialogResult.Cancel; // Erklärung: ohne Speichern schließen
            Close();
        }
    }
}