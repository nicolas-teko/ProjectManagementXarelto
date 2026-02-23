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

        private void LoadInformations() {                         
            // Warum darf diese Methode darf KEINEN Parameter mehr haben? 
            //Antwort: Weil die Methode immer die Informationen für das aktuell angezeigte Projekt laden soll, und die Projekt-Id bereits als Feld (_projectId) in der Klasse gespeichert ist
            var infos = Program.DbContext.Informations
                .Where(i => i.ProjectId == _projectId)
                .OrderBy(i => i.CreatedAt)
                .ToList();

            lstInformations.Items.Clear(); // Erklärung: Liste leeren

            foreach (var info in infos) {
                // Erklärung: Einfache Anzeigezeile pro Information erzeugen
                var displayText = $"{info.CreatedAt:yyyy-MM-dd HH:mm} - {info.Text}";
                lstInformations.Items.Add(displayText);
            }

            // Erklärung: Falls keine Informationen vorhanden sind, Hinweis anzeigen
            if (!infos.Any()) {
                lstInformations.Items.Add("(Noch keine Informationen vorhanden)");
            }

            foreach (var info in infos) {
                lstInformations.Items.Add(info); // Erklärung: Information-Objekte direkt hinzufügen (ToString wird genutzt)
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
    }
}
