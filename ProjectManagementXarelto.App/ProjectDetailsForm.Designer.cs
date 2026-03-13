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
        private void InitializeComponent()
        {
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
            lbl_open_Info = new Label();
            SuspendLayout();
            // 
            // lblProjectName
            // 
            lblProjectName.AutoSize = true;
            lblProjectName.Font = new Font("Segoe UI", 13F);
            lblProjectName.Location = new Point(75, 26);
            lblProjectName.Name = "lblProjectName";
            lblProjectName.Size = new Size(59, 25);
            lblProjectName.TabIndex = 0;
            lblProjectName.Text = "label1";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(75, 57);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(38, 15);
            lblCustomerName.TabIndex = 1;
            lblCustomerName.Text = "label1";
            // 
            // lblProjectLead
            // 
            lblProjectLead.AutoSize = true;
            lblProjectLead.Location = new Point(75, 81);
            lblProjectLead.Name = "lblProjectLead";
            lblProjectLead.Size = new Size(38, 15);
            lblProjectLead.TabIndex = 2;
            lblProjectLead.Text = "label2";
            // 
            // txtInitialDescription
            // 
            txtInitialDescription.Location = new Point(75, 128);
            txtInitialDescription.Margin = new Padding(3, 2, 3, 2);
            txtInitialDescription.Multiline = true;
            txtInitialDescription.Name = "txtInitialDescription";
            txtInitialDescription.ReadOnly = true;
            txtInitialDescription.ScrollBars = ScrollBars.Horizontal;
            txtInitialDescription.Size = new Size(530, 59);
            txtInitialDescription.TabIndex = 3;
            // 
            // lstInformations
            // 
            lstInformations.AccessibleName = "";
            lstInformations.FormattingEnabled = true;
            lstInformations.HorizontalScrollbar = true;
            lstInformations.ItemHeight = 15;
            lstInformations.Location = new Point(76, 229);
            lstInformations.Margin = new Padding(3, 2, 3, 2);
            lstInformations.Name = "lstInformations";
            lstInformations.Size = new Size(529, 64);
            lstInformations.TabIndex = 4;
            // 
            // lblDetailsInformationen
            // 
            lblDetailsInformationen.AutoSize = true;
            lblDetailsInformationen.Location = new Point(75, 205);
            lblDetailsInformationen.Name = "lblDetailsInformationen";
            lblDetailsInformationen.Size = new Size(86, 15);
            lblDetailsInformationen.TabIndex = 5;
            lblDetailsInformationen.Text = "Informationen:";
            // 
            // lblDetailsDescription
            // 
            lblDetailsDescription.AutoSize = true;
            lblDetailsDescription.Location = new Point(75, 110);
            lblDetailsDescription.Name = "lblDetailsDescription";
            lblDetailsDescription.Size = new Size(119, 15);
            lblDetailsDescription.TabIndex = 6;
            lblDetailsDescription.Text = "Projektbeschreibung:";
            // 
            // btnNewInformation
            // 
            btnNewInformation.Location = new Point(473, 298);
            btnNewInformation.Margin = new Padding(3, 2, 3, 2);
            btnNewInformation.Name = "btnNewInformation";
            btnNewInformation.Size = new Size(131, 22);
            btnNewInformation.TabIndex = 7;
            btnNewInformation.Text = "+ Neue Information";
            btnNewInformation.UseVisualStyleBackColor = true;
            // 
            // lblTagFilter
            // 
            lblTagFilter.AutoSize = true;
            lblTagFilter.Location = new Point(300, 205);
            lblTagFilter.Name = "lblTagFilter";
            lblTagFilter.Size = new Size(64, 15);
            lblTagFilter.TabIndex = 8;
            lblTagFilter.Text = "Tag Suche:";
            // 
            // txtTagFilter
            // 
            txtTagFilter.Location = new Point(366, 202);
            txtTagFilter.Margin = new Padding(3, 2, 3, 2);
            txtTagFilter.Name = "txtTagFilter";
            txtTagFilter.Size = new Size(131, 23);
            txtTagFilter.TabIndex = 9;
            // 
            // btnApplyTagFilter
            // 
            btnApplyTagFilter.Location = new Point(505, 202);
            btnApplyTagFilter.Margin = new Padding(3, 2, 3, 2);
            btnApplyTagFilter.Name = "btnApplyTagFilter";
            btnApplyTagFilter.Size = new Size(48, 20);
            btnApplyTagFilter.TabIndex = 10;
            btnApplyTagFilter.Text = "Filter";
            btnApplyTagFilter.UseVisualStyleBackColor = true;
            // 
            // btnClearTagFilter
            // 
            btnClearTagFilter.Location = new Point(558, 202);
            btnClearTagFilter.Margin = new Padding(3, 2, 3, 2);
            btnClearTagFilter.Name = "btnClearTagFilter";
            btnClearTagFilter.Size = new Size(46, 20);
            btnClearTagFilter.TabIndex = 11;
            btnClearTagFilter.Text = "Clear";
            btnClearTagFilter.UseVisualStyleBackColor = true;
            // 
            // lbl_open_Info
            // 
            lbl_open_Info.AutoSize = true;
            lbl_open_Info.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_open_Info.Location = new Point(76, 302);
            lbl_open_Info.Name = "lbl_open_Info";
            lbl_open_Info.Size = new Size(204, 15);
            lbl_open_Info.TabIndex = 12;
            lbl_open_Info.Text = "Doppelklick um Information zu öffnen";
            // 
            // ProjectDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 376);
            Controls.Add(lbl_open_Info);
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
            Margin = new Padding(3, 2, 3, 2);
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
        private Label lbl_open_Info;
    }
}