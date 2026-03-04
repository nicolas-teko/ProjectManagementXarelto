using System.Linq;
using Microsoft.EntityFrameworkCore;
using ProjectManagementXarelto.Core.Models;

namespace ProjectManagementXarelto.App {
    public partial class ProjectDetailsForm : Form {
        private readonly int _projectId; // Erklärung: Id des Projekts, das angezeigt werden soll

        public ProjectDetailsForm(int projectId) {
            InitializeComponent();
            _projectId = projectId;                     // Erklärung: Projekt-Id speichern

            this.Load += ProjectDetailsForm_Load;       // Erklärung: Beim Laden des Forms Daten aus DB holen

            btnNewInformation.Click += BtnNewInformation_Click; // Erklärung: Klick-Ereignis für "Neue Information hinzufügen" Button

            lstInformations.DoubleClick += LstInformations_DoubleClick; // Erklärung: Doppelklick-Ereignis für Liste

            btnApplyTagFilter.Click += BtnApplyTagFilter_Click;   // Erklärung: Filter anwenden
            
            btnClearTagFilter.Click += BtnClearTagFilter_Click;   // Erklärung: Filter löschen

        }

        private void ProjectDetailsForm_Load(object? sender, EventArgs e) {
            // Erklärung: Projekt inkl. Projektleiter und Informationen aus der Datenbank laden
            var project = Program.DbContext.Projects
                .Include(p => p.ProjectLeadUser)
                .Include(p => p.Informations)
                .FirstOrDefault(p => p.Id == _projectId);

            if (project == null) {
                MessageBox.Show("Projekt wurde nicht gefunden.");
                Close();
                return;
            }

            // Erklärung: Kopfbereich mit Projektinformationen füllen
            lblProjectName.Text = $"Projekt: {project.Name}";
            lblCustomerName.Text = $"Kunde: {project.CustomerName}";
            lblProjectLead.Text = $"Projektleiter: {project.ProjectLeadUser?.DisplayName ?? "-"}";

            txtInitialDescription.Text = project.InitialDescription; // Erklärung: Initialbeschreibung anzeigen (readonly)

            LoadInformations(); // Erklärung: Liste der Informations-Elemente füllen
        }

        private void LoadInformations(string? tagFilter = null) {
            var query = Program.DbContext.Informations
                .Where(i => i.ProjectId == _projectId);

            // Filter anwenden, falls vorhanden
            if (!string.IsNullOrWhiteSpace(tagFilter)) {
                var filter = tagFilter.Trim().ToLower();
                query = query.Where(i => i.Tags.Any(t => t.Tag.ToLower().Contains(filter)));
            }

            var infos = query
                .OrderBy(i => i.CreatedAt)
                .ToList();

            lstInformations.Items.Clear();

            if (!infos.Any()) {
                lstInformations.Items.Add("(Keine Informationen vorhanden)");
                return;
            }

            foreach (var info in infos) {
                lstInformations.Items.Add(info);  // ToString() zeigt Text + Datum
            }
        }

        private void LstInformations_DoubleClick(object? sender, EventArgs e) {
            // Ausgewähltes Element holen
            var selected = lstInformations.SelectedItem;

            if (selected is not Information info) {
                // z.B. "(Keine Informationen vorhanden)"
                return;
            }

            // EXISTIERENDE Info bearbeiten → InformationEditForm benötigt die Id
            using var form = new InformationEditForm(info.Id);

            if (form.ShowDialog(this) == DialogResult.OK) {
                LoadInformations(); // nach Speichern aktualisieren
            }
        }

        private void BtnNewInformation_Click(object? sender, EventArgs e) {              // METHODE HABE ICH MAL SO SELBST ERSTELLT: GLEICH WIE BEI PROJEKT ERSTELLEN SEIN
            // Erklärung: Formular zum Erstellen einer Neuen Information öffnen (ohne Id, da es neu ist)
            using var form = new InformationCreateForm(_projectId);

            // Erklärung: Wenn der Dialog mit OK beendet wird, Projekte neu laden
            if (form.ShowDialog(this) == DialogResult.OK) {
                LoadInformations();                                                      // Erklärung: DataGridView nach dem Speichern aktualisieren
            }
        }
        private void BtnApplyTagFilter_Click(object? sender, EventArgs e) {
            // Erklärung: Filter-Text auslesen und Liste damit neu laden
            var filter = txtTagFilter.Text;
            LoadInformations(filter);
        }

        private void BtnClearTagFilter_Click(object? sender, EventArgs e) {
            // Erklärung: Filter zurücksetzen und alle Infos anzeigen
            txtTagFilter.Clear();
            LoadInformations();
        }
    }
}
