using System.Linq;
using ProjectManagementXarelto.Core.Common;
using ProjectManagementXarelto.Core.Models;

namespace ProjectManagementXarelto.App {
    public partial class InformationEditForm : Form {
        private readonly int _informationId; // Erklärung: Id der Information, die bearbeitet wird
        private Information? _info;          // Erklärung: Geladene Information inkl. Tags/Links

        public InformationEditForm(int informationId) {
            InitializeComponent();
            _informationId = informationId;             // Erklärung: Id speichern

            this.Load += InformationEditForm_Load;      // Erklärung: Beim Laden Daten holen
            btnSave.Click += BtnSave_Click;             // Erklärung: Klick auf "Speichern"
            btnCancel.Click += BtnCancel_Click;         // Erklärung: Klick auf "Abbrechen"

            btnAddTag.Click += BtnAddTag_Click;         // Erklärung: Neuen Tag hinzufügen
            btnRemoveTag.Click += BtnRemoveTag_Click;   // Erklärung: Tag entfernen

            btnAddLink.Click += BtnAddLink_Click;       // Erklärung: Neuen Link hinzufügen
            btnRemoveLink.Click += BtnRemoveLink_Click; // Erklärung: Link entfernen

            btnAddComment.Click += BtnAddComment_Click; // Erklärung: Klick auf "Kommentar hinzufügen"
        }

        private void InformationEditForm_Load(object? sender, EventArgs e) {
            // Erklärung: Information inkl. Tags und Links aus DB laden
            _info = Program.DbContext.Informations
                .Where(i => i.Id == _informationId)
                .Select(i => new 
                {
                    Info = i,
                    Tags = i.Tags.ToList(),
                    Links = i.Links.ToList(),
                    Comments = i.Comments.ToList()
                })
                .AsEnumerable()  // Erklärung: danach im Speicher weiterarbeiten
                .Select(x => {
                    x.Info.Tags = x.Tags;
                    x.Info.Links = x.Links;
                    x.Info.Comments = x.Comments;
                    return x.Info;
                })
                .FirstOrDefault();

            if (_info == null) {
                MessageBox.Show("Information wurde nicht gefunden.");
                DialogResult = DialogResult.Cancel;
                Close();
                return;


            }

            txtInfoText.Text = _info.Text; // Erklärung: bestehenden Text anzeigen

            var meta = $"Erstellt: {_info.CreatedAt:yyyy-MM-dd HH:mm}";
            if (_info.UpdatedAt.HasValue) {
                meta += $" | Geändert: {_info.UpdatedAt:yyyy-MM-dd HH:mm}";
            }
            lblMeta.Text = meta; // Erklärung: Meta-Info anzeigen

            RefreshTagsList();  // Erklärung: Tag-Liste füllen
            RefreshLinksList(); // Erklärung: Link-Liste füllen
            RefreshCommentsList(); // Erklärung: Kommentare füllen

            // Erklärung: ComboBox für Link-Typ initialisieren
            cmbLinkType.Items.Clear();
            cmbLinkType.Items.Add(LinkType.Image);
            cmbLinkType.Items.Add(LinkType.Document);
            cmbLinkType.SelectedIndex = 0;
        }

        private void RefreshTagsList() {
            lstTags.Items.Clear(); // Erklärung: Tag-Liste leeren
            if (_info == null) return;

            foreach (var tag in _info.Tags.OrderBy(t => t.Tag)) {
                lstTags.Items.Add(tag); // Erklärung: InfoTag-Objekte, ToString() zeigt Text
            }

            if (!_info.Tags.Any()) {
                lstTags.Items.Add("(keine Tags)");
            }
        }

        private void RefreshLinksList() {
            lstLinks.Items.Clear(); // Erklärung: Link-Liste leeren
            if (_info == null) return;

            foreach (var link in _info.Links.OrderBy(l => l.Type).ThenBy(l => l.Url)) {
                lstLinks.Items.Add(link); // Erklärung: InfoLink-Objekte, ToString() zeigt Typ + URL
            }

            if (!_info.Links.Any()) {
                lstLinks.Items.Add("(keine Links)");
            }
        }

        private void BtnAddTag_Click(object? sender, EventArgs e) {
            if (_info == null) return;

            var text = txtNewTag.Text.Trim(); // Erklärung: neuen Tag-Text holen

            if (string.IsNullOrWhiteSpace(text)) {
                MessageBox.Show("Tag darf nicht leer sein.");
                return;
            }

            if (_info.Tags.Count >= 3) {
                MessageBox.Show("Maximal 3 Tags pro Information erlaubt.");
                return;
            }

            if (_info.Tags.Any(t => t.Tag.Equals(text, StringComparison.OrdinalIgnoreCase))) {
                MessageBox.Show("Dieser Tag ist bereits vorhanden.");
                return;
            }

            var tag = new InfoTag {
                InformationId = _info.Id,
                Tag = text
            };

            _info.Tags.Add(tag);                     // Erklärung: Tag in Navigation hinzufügen
            Program.DbContext.InfoTags.Add(tag);     // Erklärung: Tag in DbContext registrieren

            txtNewTag.Clear();                       // Erklärung: Eingabefeld leeren
            RefreshTagsList();                       // Erklärung: Liste aktualisieren
        }

        private void BtnRemoveTag_Click(object? sender, EventArgs e) {
            if (_info == null) return;

            if (lstTags.SelectedItem is InfoTag tag) // Erklärung: ausgewählten Tag holen
            {
                _info.Tags.Remove(tag);                     // Erklärung: aus Navigation entfernen
                Program.DbContext.InfoTags.Remove(tag);     // Erklärung: zum Löschen markieren
                RefreshTagsList();                          // Erklärung: Liste aktualisieren
            }
        }

        private void BtnAddLink_Click(object? sender, EventArgs e) {
            if (_info == null) return;

            var url = txtNewUrl.Text.Trim(); // Erklärung: neue URL holen

            if (string.IsNullOrWhiteSpace(url)) {
                MessageBox.Show("URL darf nicht leer sein.");
                return;
            }

            if (cmbLinkType.SelectedItem is not LinkType type) {
                MessageBox.Show("Bitte einen Link-Typ auswählen.");
                return;
            }

            var link = new InfoLink {
                InformationId = _info.Id,
                Url = url,
                Type = type
            };

            _info.Links.Add(link);                     // Erklärung: Link in Navigation hinzufügen
            Program.DbContext.InfoLinks.Add(link);     // Erklärung: Link in DbContext registrieren

            txtNewUrl.Clear();                         // Erklärung: Eingabefeld leeren
            RefreshLinksList();                        // Erklärung: Liste aktualisieren
        }

        private void BtnRemoveLink_Click(object? sender, EventArgs e) {
            if (_info == null) return;

            if (lstLinks.SelectedItem is InfoLink link) // Erklärung: ausgewählten Link holen
            {
                _info.Links.Remove(link);                    // Erklärung: aus Navigation entfernen
                Program.DbContext.InfoLinks.Remove(link);    // Erklärung: zum Löschen markieren
                RefreshLinksList();                          // Erklärung: Liste aktualisieren
            }
        }

        private void BtnSave_Click(object? sender, EventArgs e) {
            if (_info == null)
                return;

            var user = SessionContext.CurrentUser; // Erklärung: aktuell eingeloggter Benutzer

            if (user == null) {
                MessageBox.Show("Kein Benutzer angemeldet.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtInfoText.Text)) {
                MessageBox.Show("Der Informationstext darf nicht leer sein.");
                return;
            }

            // Erklärung: Text und Metadaten aktualisieren
            _info.Text = txtInfoText.Text.Trim();
            _info.UpdatedAt = DateTime.UtcNow;
            _info.UpdatedByUserId = user.Id;

            Program.DbContext.SaveChanges(); // Erklärung: alle Änderungen (Text/Tags/Links) speichern

            DialogResult = DialogResult.OK;  // Erklärung: Erfolg melden
            Close();
        }

        private void BtnCancel_Click(object? sender, EventArgs e) {
            DialogResult = DialogResult.Cancel; // Erklärung: ohne Speichern schließen
            Close();
        }

        private void RefreshCommentsList() {
            lstComments.Items.Clear(); // Erklärung: Liste leeren
            if (_info == null) return;

            foreach (var c in _info.Comments.OrderBy(c => c.CreatedAt)) {
                lstComments.Items.Add(c); // Erklärung: Comment-Objekte, ToString() zeigt Datum + Text
            }

            if (!_info.Comments.Any()) {
                lstComments.Items.Add("(keine Kommentare)");
            }
        }
        private void BtnAddComment_Click(object? sender, EventArgs e) {
            if (_info == null) return;
            var user = SessionContext.CurrentUser; // Erklärung: aktuell eingeloggter Benutzer
            if (user == null) {
                MessageBox.Show("Kein Benutzer angemeldet.");
                return;
            }
            var text = txtNewComment.Text.Trim(); // Erklärung: neuen Kommentar-Text holen
            if (string.IsNullOrWhiteSpace(text)) {
                MessageBox.Show("Kommentar darf nicht leer sein.");
                return;
            }
            var comment = new Comment {
                InformationId = _info.Id,
                Text = text,
                CreatedAt = DateTime.UtcNow,
                CreatedByUserId = user.Id
            };
            _info.Comments.Add(comment);                     // Erklärung: Kommentar in Navigation hinzufügen
            Program.DbContext.Comments.Add(comment);     // Erklärung: Kommentar in DbContext registrieren
            txtNewComment.Clear();                         // Erklärung: Eingabefeld leeren
            RefreshCommentsList();                        // Erklärung: Liste aktualisieren
        }
    }
}