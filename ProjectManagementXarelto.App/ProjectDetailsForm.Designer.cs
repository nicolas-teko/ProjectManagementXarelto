namespace ProjectManagementXarelto.App {
    partial class ProjectDetailsForm {
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
            lblProjectName = new Label();
            lblCustomerName = new Label();
            lblProjectLead = new Label();
            txtInitialDescription = new TextBox();
            lstInformations = new ListBox();
            lblDetailsInformationen = new Label();
            lblDetailsDescription = new Label();
            btnNewInformation = new Button();
            lblTagFilter = new Label();
            txtTagFilter = new TextBox();
            btnApplyTagFilter = new Button();
            btnClearTagFilter = new Button();
            SuspendLayout();
            // 
            // lblProjectName
            // 
            lblProjectName.AutoSize = true;
            lblProjectName.Font = new Font("Segoe UI", 13F);
            lblProjectName.Location = new Point(86, 35);
            lblProjectName.Name = "lblProjectName";
            lblProjectName.Size = new Size(71, 30);
            lblProjectName.TabIndex = 0;
            lblProjectName.Text = "label1";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(86, 76);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(50, 20);
            lblCustomerName.TabIndex = 1;
            lblCustomerName.Text = "label1";
            // 
            // lblProjectLead
            // 
            lblProjectLead.AutoSize = true;
            lblProjectLead.Location = new Point(86, 108);
            lblProjectLead.Name = "lblProjectLead";
            lblProjectLead.Size = new Size(50, 20);
            lblProjectLead.TabIndex = 2;
            lblProjectLead.Text = "label2";
            // 
            // txtInitialDescription
            // 
            txtInitialDescription.Location = new Point(86, 170);
            txtInitialDescription.Multiline = true;
            txtInitialDescription.Name = "txtInitialDescription";
            txtInitialDescription.ReadOnly = true;
            txtInitialDescription.ScrollBars = ScrollBars.Horizontal;
            txtInitialDescription.Size = new Size(605, 77);
            txtInitialDescription.TabIndex = 3;
            // 
            // lstInformations
            // 
            lstInformations.AccessibleName = "";
            lstInformations.FormattingEnabled = true;
            lstInformations.Location = new Point(87, 305);
            lstInformations.Name = "lstInformations";
            lstInformations.Size = new Size(604, 84);
            lstInformations.TabIndex = 4;
            // 
            // lblDetailsInformationen
            // 
            lblDetailsInformationen.AutoSize = true;
            lblDetailsInformationen.Location = new Point(86, 273);
            lblDetailsInformationen.Name = "lblDetailsInformationen";
            lblDetailsInformationen.Size = new Size(106, 20);
            lblDetailsInformationen.TabIndex = 5;
            lblDetailsInformationen.Text = "Informationen:";
            // 
            // lblDetailsDescription
            // 
            lblDetailsDescription.AutoSize = true;
            lblDetailsDescription.Location = new Point(86, 147);
            lblDetailsDescription.Name = "lblDetailsDescription";
            lblDetailsDescription.Size = new Size(147, 20);
            lblDetailsDescription.TabIndex = 6;
            lblDetailsDescription.Text = "Projektbeschreibung:";
            // 
            // btnNewInformation
            // 
            btnNewInformation.Location = new Point(541, 397);
            btnNewInformation.Name = "btnNewInformation";
            btnNewInformation.Size = new Size(150, 29);
            btnNewInformation.TabIndex = 7;
            btnNewInformation.Text = "+ Neue Information";
            btnNewInformation.UseVisualStyleBackColor = true;
            // 
            // lblTagFilter
            // 
            lblTagFilter.AutoSize = true;
            lblTagFilter.Location = new Point(383, 273);
            lblTagFilter.Name = "lblTagFilter";
            lblTagFilter.Size = new Size(78, 20);
            lblTagFilter.TabIndex = 8;
            lblTagFilter.Text = "Tag Suche:";
            // 
            // txtTagFilter
            // 
            txtTagFilter.Location = new Point(467, 270);
            txtTagFilter.Name = "txtTagFilter";
            txtTagFilter.Size = new Size(149, 27);
            txtTagFilter.TabIndex = 9;
            // 
            // btnApplyTagFilter
            // 
            btnApplyTagFilter.Location = new Point(622, 270);
            btnApplyTagFilter.Name = "btnApplyTagFilter";
            btnApplyTagFilter.Size = new Size(32, 27);
            btnApplyTagFilter.TabIndex = 10;
            btnApplyTagFilter.Text = "A";
            btnApplyTagFilter.UseVisualStyleBackColor = true;
            // 
            // btnClearTagFilter
            // 
            btnClearTagFilter.Location = new Point(659, 270);
            btnClearTagFilter.Name = "btnClearTagFilter";
            btnClearTagFilter.Size = new Size(32, 27);
            btnClearTagFilter.TabIndex = 11;
            btnClearTagFilter.Text = "D";
            btnClearTagFilter.UseVisualStyleBackColor = true;
            // 
            // ProjectDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClearTagFilter);
            Controls.Add(btnApplyTagFilter);
            Controls.Add(txtTagFilter);
            Controls.Add(lblTagFilter);
            Controls.Add(btnNewInformation);
            Controls.Add(lblDetailsDescription);
            Controls.Add(lblDetailsInformationen);
            Controls.Add(lstInformations);
            Controls.Add(txtInitialDescription);
            Controls.Add(lblProjectLead);
            Controls.Add(lblCustomerName);
            Controls.Add(lblProjectName);
            Name = "ProjectDetailsForm";
            Text = "ProjectDetailsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProjectName;
        private Label lblCustomerName;
        private Label lblProjectLead;
        private TextBox txtInitialDescription;
        private ListBox lstInformations;
        private Label lblDetailsInformationen;
        private Label lblDetailsDescription;
        private Button btnNewInformation;
        private Label lblTagFilter;
        private TextBox txtTagFilter;
        private Button btnApplyTagFilter;
        private Button btnClearTagFilter;
    }
}