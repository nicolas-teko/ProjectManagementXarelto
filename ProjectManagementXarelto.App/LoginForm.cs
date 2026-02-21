using ProjectManagementXarelto.Core.Common;
using ProjectManagementXarelto.Core.Models;

namespace ProjectManagementXarelto.App
{
    public partial class LoginForm : Form {
        public LoginForm() {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e) {

        }

        private void btnLead_Click(object sender, EventArgs e) {
            var user = Program.DbContext.Users
                .First(u => u.Role == RoleType.ProjectLead);    // Hole den Benutzer aus der Datenbank, der die Rolle "Projektleiter" hat

            SessionContext.CurrentUser = user;                 // Speichere den Benutzer als aktuell eingeloggten User

            OpenProjectsForm();                                // Öffne das nächste Fenster (Projektübersicht) und verstecke die Login-Form
        }

        private void btnManager_Click(object sender, EventArgs e) {

            var user = Program.DbContext.Users
                .First(u => u.Role == RoleType.ProjectManager); // Hole den Benutzer aus der Datenbank, der die Rolle "Projektmanager" hat

            SessionContext.CurrentUser = user;                  // Speichere den Benutzer als aktuell eingeloggten User

            OpenProjectsForm();                                 // Öffne das nächste Fenster (Projektübersicht) und verstecke die Login-Form

        private void OpenProjectsForm() {
            var form = new ProjectsForm();  // Neues Fenster erzeugen
            form.Show();                    // Fenster anzeigen
            this.Hide();                    // LoginForm verstecken
        }

    }
    }
}
