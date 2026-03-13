namespace ProjectManagementXarelto.App {
    partial class ProjectsForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCurrentUser = new Label();
            dgvProjects = new DataGridView();
            btnNewProject = new Button();
            lblProjectOverview = new Label();
            lbl_open_project = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProjects).BeginInit();
            SuspendLayout();
            // 
            // lblCurrentUser
            // 
            lblCurrentUser.AutoSize = true;
            lblCurrentUser.Location = new Point(403, 7);
            lblCurrentUser.Name = "lblCurrentUser";
            lblCurrentUser.Size = new Size(92, 15);
            lblCurrentUser.TabIndex = 0;
            lblCurrentUser.Text = "Angemeldet als:";
            // 
            // dgvProjects
            // 
            dgvProjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProjects.Location = new Point(51, 92);
            dgvProjects.Margin = new Padding(3, 2, 3, 2);
            dgvProjects.Name = "dgvProjects";
            dgvProjects.RowHeadersWidth = 51;
            dgvProjects.Size = new Size(586, 208);
            dgvProjects.TabIndex = 1;
            // 
            // btnNewProject
            // 
            btnNewProject.Location = new Point(515, 308);
            btnNewProject.Margin = new Padding(3, 2, 3, 2);
            btnNewProject.Name = "btnNewProject";
            btnNewProject.Size = new Size(122, 20);
            btnNewProject.TabIndex = 2;
            btnNewProject.Text = "+ Neues Projekt";
            btnNewProject.UseVisualStyleBackColor = true;
            // 
            // lblProjectOverview
            // 
            lblProjectOverview.AutoSize = true;
            lblProjectOverview.Font = new Font("Segoe UI", 13F);
            lblProjectOverview.Location = new Point(51, 59);
            lblProjectOverview.Name = "lblProjectOverview";
            lblProjectOverview.Size = new Size(143, 25);
            lblProjectOverview.TabIndex = 3;
            lblProjectOverview.Text = "Projektübersicht:";
            // 
            // lbl_open_project
            // 
            lbl_open_project.AutoSize = true;
            lbl_open_project.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_open_project.Location = new Point(51, 308);
            lbl_open_project.Name = "lbl_open_project";
            lbl_open_project.Size = new Size(179, 15);
            lbl_open_project.TabIndex = 4;
            lbl_open_project.Text = "Doppelklick um Projekt zu öffnen";
            // 
            // ProjectsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 375);
            Controls.Add(lbl_open_project);
            Controls.Add(lblProjectOverview);
            Controls.Add(btnNewProject);
            Controls.Add(dgvProjects);
            Controls.Add(lblCurrentUser);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ProjectsForm";
            Text = "ProjectsForm";
            ((System.ComponentModel.ISupportInitialize)dgvProjects).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCurrentUser;
        private DataGridView dgvProjects;
        private Button btnNewProject;
        private Label lblProjectOverview;
        private Label lbl_open_project;
    }
}