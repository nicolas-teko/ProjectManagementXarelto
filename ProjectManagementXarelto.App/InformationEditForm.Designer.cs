namespace ProjectManagementXarelto.App {
    partial class InformationEditForm {
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
            txtInfoText = new TextBox();
            lblEditInformationText = new Label();
            lblMeta = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            lstLinks = new ListBox();
            lstTags = new ListBox();
            lblEditInfoURLs = new Label();
            lblEditInfoTags = new Label();
            txtNewUrl = new TextBox();
            txtNewTag = new TextBox();
            cmbLinkType = new ComboBox();
            btnAddLink = new Button();
            btnRemoveLink = new Button();
            btnAddTag = new Button();
            btnRemoveTag = new Button();
            lblCommentsTitle = new Label();
            txtNewComment = new TextBox();
            btnAddComment = new Button();
            lstComments = new ListBox();
            SuspendLayout();
            // 
            // txtInfoText
            // 
            txtInfoText.Location = new Point(99, 42);
            txtInfoText.Multiline = true;
            txtInfoText.Name = "txtInfoText";
            txtInfoText.Size = new Size(600, 76);
            txtInfoText.TabIndex = 0;
            // 
            // lblEditInformationText
            // 
            lblEditInformationText.AutoSize = true;
            lblEditInformationText.Location = new Point(103, 19);
            lblEditInformationText.Name = "lblEditInformationText";
            lblEditInformationText.Size = new Size(90, 20);
            lblEditInformationText.TabIndex = 1;
            lblEditInformationText.Text = "Information:";
            // 
            // lblMeta
            // 
            lblMeta.AutoSize = true;
            lblMeta.Location = new Point(561, 19);
            lblMeta.Name = "lblMeta";
            lblMeta.Size = new Size(50, 20);
            lblMeta.TabIndex = 2;
            lblMeta.Text = "label1";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(479, 409);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(132, 29);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(630, 409);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(131, 29);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // lstLinks
            // 
            lstLinks.FormattingEnabled = true;
            lstLinks.Location = new Point(104, 267);
            lstLinks.Name = "lstLinks";
            lstLinks.Size = new Size(280, 44);
            lstLinks.TabIndex = 11;
            // 
            // lstTags
            // 
            lstTags.FormattingEnabled = true;
            lstTags.Location = new Point(420, 267);
            lstTags.Name = "lstTags";
            lstTags.Size = new Size(280, 44);
            lstTags.TabIndex = 12;
            // 
            // lblEditInfoURLs
            // 
            lblEditInfoURLs.AutoSize = true;
            lblEditInfoURLs.Location = new Point(103, 244);
            lblEditInfoURLs.Name = "lblEditInfoURLs";
            lblEditInfoURLs.Size = new Size(161, 20);
            lblEditInfoURLs.TabIndex = 13;
            lblEditInfoURLs.Text = "Dokumente und Bilder:";
            // 
            // lblEditInfoTags
            // 
            lblEditInfoTags.AutoSize = true;
            lblEditInfoTags.Location = new Point(420, 244);
            lblEditInfoTags.Name = "lblEditInfoTags";
            lblEditInfoTags.Size = new Size(41, 20);
            lblEditInfoTags.TabIndex = 14;
            lblEditInfoTags.Text = "Tags:";
            // 
            // txtNewUrl
            // 
            txtNewUrl.Location = new Point(104, 349);
            txtNewUrl.Name = "txtNewUrl";
            txtNewUrl.Size = new Size(280, 27);
            txtNewUrl.TabIndex = 15;
            // 
            // txtNewTag
            // 
            txtNewTag.Location = new Point(420, 317);
            txtNewTag.Name = "txtNewTag";
            txtNewTag.Size = new Size(280, 27);
            txtNewTag.TabIndex = 16;
            // 
            // cmbLinkType
            // 
            cmbLinkType.FormattingEnabled = true;
            cmbLinkType.Location = new Point(104, 317);
            cmbLinkType.Name = "cmbLinkType";
            cmbLinkType.Size = new Size(280, 28);
            cmbLinkType.TabIndex = 17;
            // 
            // btnAddLink
            // 
            btnAddLink.Location = new Point(320, 382);
            btnAddLink.Name = "btnAddLink";
            btnAddLink.Size = new Size(29, 29);
            btnAddLink.TabIndex = 18;
            btnAddLink.Text = "+";
            btnAddLink.UseVisualStyleBackColor = true;
            // 
            // btnRemoveLink
            // 
            btnRemoveLink.Location = new Point(355, 382);
            btnRemoveLink.Name = "btnRemoveLink";
            btnRemoveLink.Size = new Size(29, 29);
            btnRemoveLink.TabIndex = 19;
            btnRemoveLink.Text = "-";
            btnRemoveLink.UseVisualStyleBackColor = true;
            // 
            // btnAddTag
            // 
            btnAddTag.Location = new Point(639, 349);
            btnAddTag.Name = "btnAddTag";
            btnAddTag.Size = new Size(31, 29);
            btnAddTag.TabIndex = 20;
            btnAddTag.Text = "+";
            btnAddTag.UseVisualStyleBackColor = true;
            // 
            // btnRemoveTag
            // 
            btnRemoveTag.Font = new Font("Segoe UI", 9F);
            btnRemoveTag.Location = new Point(676, 349);
            btnRemoveTag.Name = "btnRemoveTag";
            btnRemoveTag.Size = new Size(28, 29);
            btnRemoveTag.TabIndex = 21;
            btnRemoveTag.Text = "-";
            btnRemoveTag.UseVisualStyleBackColor = true;
            // 
            // lblCommentsTitle
            // 
            lblCommentsTitle.AutoSize = true;
            lblCommentsTitle.Location = new Point(99, 121);
            lblCommentsTitle.Name = "lblCommentsTitle";
            lblCommentsTitle.Size = new Size(98, 20);
            lblCommentsTitle.TabIndex = 22;
            lblCommentsTitle.Text = "Kommentare:";
            // 
            // txtNewComment
            // 
            txtNewComment.Location = new Point(104, 208);
            txtNewComment.Name = "txtNewComment";
            txtNewComment.Size = new Size(507, 27);
            txtNewComment.TabIndex = 24;
            txtNewComment.Text = "Kommentar schreiben...";
            // 
            // btnAddComment
            // 
            btnAddComment.Location = new Point(617, 208);
            btnAddComment.Name = "btnAddComment";
            btnAddComment.Size = new Size(82, 27);
            btnAddComment.TabIndex = 25;
            btnAddComment.Text = "+";
            btnAddComment.UseVisualStyleBackColor = true;
            // 
            // lstComments
            // 
            lstComments.FormattingEnabled = true;
            lstComments.Location = new Point(103, 144);
            lstComments.Name = "lstComments";
            lstComments.Size = new Size(596, 64);
            lstComments.TabIndex = 26;
            // 
            // InformationEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstComments);
            Controls.Add(btnAddComment);
            Controls.Add(txtNewComment);
            Controls.Add(lblCommentsTitle);
            Controls.Add(btnRemoveTag);
            Controls.Add(btnAddTag);
            Controls.Add(btnRemoveLink);
            Controls.Add(btnAddLink);
            Controls.Add(cmbLinkType);
            Controls.Add(txtNewTag);
            Controls.Add(txtNewUrl);
            Controls.Add(lblEditInfoTags);
            Controls.Add(lblEditInfoURLs);
            Controls.Add(lstTags);
            Controls.Add(lstLinks);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(lblMeta);
            Controls.Add(lblEditInformationText);
            Controls.Add(txtInfoText);
            Name = "InformationEditForm";
            Text = "InformationEditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInfoText;
        private Label lblEditInformationText;
        private Label lblMeta;
        private Button btnCancel;
        private Button btnSave;
        private ListBox lstLinks;
        private ListBox lstTags;
        private Label lblEditInfoURLs;
        private Label lblEditInfoTags;
        private TextBox txtNewUrl;
        private TextBox txtNewTag;
        private ComboBox cmbLinkType;
        private Button btnAddLink;
        private Button btnRemoveLink;
        private Button btnAddTag;
        private Button btnRemoveTag;
        private Label lblCommentsTitle;
        private TextBox txtNewComment;
        private Button btnAddComment;
        private ListBox lstComments;
    }
}