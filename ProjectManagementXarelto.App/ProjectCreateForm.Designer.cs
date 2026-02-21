namespace ProjectManagementXarelto.App {
    partial class ProjectCreateForm {
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
            txtName = new TextBox();
            txtCustomer = new TextBox();
            txtInitialDescription = new TextBox();
            lblProjectLead = new Label();
            lblCreateProjectProjectName = new Label();
            lblCreateProjectCustomer = new Label();
            lblCreateProjectProjectlead = new Label();
            lblCreateProject_Description = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(75, 67);
            txtName.Name = "txtName";
            txtName.Size = new Size(318, 27);
            txtName.TabIndex = 0;
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new Point(75, 155);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(318, 27);
            txtCustomer.TabIndex = 1;
            // 
            // txtInitialDescription
            // 
            txtInitialDescription.Location = new Point(75, 320);
            txtInitialDescription.Name = "txtInitialDescription";
            txtInitialDescription.Size = new Size(555, 27);
            txtInitialDescription.TabIndex = 2;
            // 
            // lblProjectLead
            // 
            lblProjectLead.AutoSize = true;
            lblProjectLead.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblProjectLead.Location = new Point(75, 242);
            lblProjectLead.Name = "lblProjectLead";
            lblProjectLead.Size = new Size(96, 20);
            lblProjectLead.TabIndex = 3;
            lblProjectLead.Text = "aktueller User";
            // 
            // lblCreateProjectProjectName
            // 
            lblCreateProjectProjectName.AutoSize = true;
            lblCreateProjectProjectName.Location = new Point(75, 35);
            lblCreateProjectProjectName.Name = "lblCreateProjectProjectName";
            lblCreateProjectProjectName.Size = new Size(95, 20);
            lblCreateProjectProjectName.TabIndex = 4;
            lblCreateProjectProjectName.Text = "Projektname:";
            // 
            // lblCreateProjectCustomer
            // 
            lblCreateProjectCustomer.AutoSize = true;
            lblCreateProjectCustomer.Location = new Point(75, 125);
            lblCreateProjectCustomer.Name = "lblCreateProjectCustomer";
            lblCreateProjectCustomer.Size = new Size(54, 20);
            lblCreateProjectCustomer.TabIndex = 5;
            lblCreateProjectCustomer.Text = "Kunde:";
            // 
            // lblCreateProjectProjectlead
            // 
            lblCreateProjectProjectlead.AutoSize = true;
            lblCreateProjectProjectlead.Location = new Point(77, 212);
            lblCreateProjectProjectlead.Name = "lblCreateProjectProjectlead";
            lblCreateProjectProjectlead.Size = new Size(92, 20);
            lblCreateProjectProjectlead.TabIndex = 6;
            lblCreateProjectProjectlead.Text = "Projektleiter:";
            // 
            // lblCreateProject_Description
            // 
            lblCreateProject_Description.AutoSize = true;
            lblCreateProject_Description.Location = new Point(76, 288);
            lblCreateProject_Description.Name = "lblCreateProject_Description";
            lblCreateProject_Description.Size = new Size(147, 20);
            lblCreateProject_Description.TabIndex = 7;
            lblCreateProject_Description.Text = "Projektbeschreibung:";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(471, 408);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(125, 29);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(626, 408);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(131, 29);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // ProjectCreateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(lblCreateProject_Description);
            Controls.Add(lblCreateProjectProjectlead);
            Controls.Add(lblCreateProjectCustomer);
            Controls.Add(lblCreateProjectProjectName);
            Controls.Add(lblProjectLead);
            Controls.Add(txtInitialDescription);
            Controls.Add(txtCustomer);
            Controls.Add(txtName);
            Name = "ProjectCreateForm";
            Text = "ProjectCreateForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtCustomer;
        private TextBox txtInitialDescription;
        private Label lblProjectLead;
        private Label lblCreateProjectProjectName;
        private Label lblCreateProjectCustomer;
        private Label lblCreateProjectProjectlead;
        private Label lblCreateProject_Description;
        private Button btnCancel;
        private Button btnSave;
    }
}