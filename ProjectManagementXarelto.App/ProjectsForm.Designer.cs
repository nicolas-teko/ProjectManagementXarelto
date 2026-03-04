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
        private void InitializeComponent() {
            lblCurrentUser = new Label();
            dgvProjects = new DataGridView();
            btnNewProject = new Button();
            lblProjectOverview = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProjects).BeginInit();
            SuspendLayout();
            // 
            // lblCurrentUser
            // 
            lblCurrentUser.AutoSize = true;
            lblCurrentUser.Location = new Point(461, 9);
            lblCurrentUser.Name = "lblCurrentUser";
            lblCurrentUser.Size = new Size(116, 20);
            lblCurrentUser.TabIndex = 0;
            lblCurrentUser.Text = "Angemeldet als:";
            // 
            // dgvProjects
            // 
            dgvProjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProjects.Location = new Point(58, 123);
            dgvProjects.Name = "dgvProjects";
            dgvProjects.RowHeadersWidth = 51;
            dgvProjects.Size = new Size(670, 278);
            dgvProjects.TabIndex = 1;
            // 
            // btnNewProject
            // 
            btnNewProject.Location = new Point(589, 411);
            btnNewProject.Name = "btnNewProject";
            btnNewProject.Size = new Size(139, 27);
            btnNewProject.TabIndex = 2;
            btnNewProject.Text = "+ Neues Projekt";
            btnNewProject.UseVisualStyleBackColor = true;
            // 
            // lblProjectOverview
            // 
            lblProjectOverview.AutoSize = true;
            lblProjectOverview.Font = new Font("Segoe UI", 13F);
            lblProjectOverview.Location = new Point(58, 79);
            lblProjectOverview.Name = "lblProjectOverview";
            lblProjectOverview.Size = new Size(174, 30);
            lblProjectOverview.TabIndex = 3;
            lblProjectOverview.Text = "Projektübersicht:";
            // 
            // ProjectsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblProjectOverview);
            Controls.Add(btnNewProject);
            Controls.Add(dgvProjects);
            Controls.Add(lblCurrentUser);
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
    }
}