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
        private void InitializeComponent()
        {
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
            lbl_open_link = new Label();
            SuspendLayout();
            // 
            // txtInfoText
            // 
            txtInfoText.Location = new Point(87, 32);
            txtInfoText.Margin = new Padding(3, 2, 3, 2);
            txtInfoText.Multiline = true;
            txtInfoText.Name = "txtInfoText";
            txtInfoText.Size = new Size(526, 50);
            txtInfoText.TabIndex = 0;
            // 
            // lblEditInformationText
            // 
            lblEditInformationText.AutoSize = true;
            lblEditInformationText.Location = new Point(87, 14);
            lblEditInformationText.Name = "lblEditInformationText";
            lblEditInformationText.Size = new Size(73, 15);
            lblEditInformationText.TabIndex = 1;
            lblEditInformationText.Text = "Information:";
            // 
            // lblMeta
            // 
            lblMeta.AutoSize = true;
            lblMeta.Location = new Point(280, 14);
            lblMeta.Name = "lblMeta";
            lblMeta.Size = new Size(38, 15);
            lblMeta.TabIndex = 2;
            lblMeta.Text = "label1";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(419, 307);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(116, 22);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(551, 307);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(115, 22);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // lstLinks
            // 
            lstLinks.FormattingEnabled = true;
            lstLinks.ItemHeight = 15;
            lstLinks.Location = new Point(87, 205);
            lstLinks.Margin = new Padding(3, 2, 3, 2);
            lstLinks.Name = "lstLinks";
            lstLinks.Size = new Size(246, 34);
            lstLinks.TabIndex = 11;
            // 
            // lstTags
            // 
            lstTags.FormattingEnabled = true;
            lstTags.ItemHeight = 15;
            lstTags.Location = new Point(368, 205);
            lstTags.Margin = new Padding(3, 2, 3, 2);
            lstTags.Name = "lstTags";
            lstTags.Size = new Size(246, 34);
            lstTags.TabIndex = 12;
            // 
            // lblEditInfoURLs
            // 
            lblEditInfoURLs.AutoSize = true;
            lblEditInfoURLs.Location = new Point(87, 188);
            lblEditInfoURLs.Name = "lblEditInfoURLs";
            lblEditInfoURLs.Size = new Size(129, 15);
            lblEditInfoURLs.TabIndex = 13;
            lblEditInfoURLs.Text = "Dokumente und Bilder:";
            // 
            // lblEditInfoTags
            // 
            lblEditInfoTags.AutoSize = true;
            lblEditInfoTags.Location = new Point(368, 188);
            lblEditInfoTags.Name = "lblEditInfoTags";
            lblEditInfoTags.Size = new Size(34, 15);
            lblEditInfoTags.TabIndex = 14;
            lblEditInfoTags.Text = "Tags:";
            // 
            // txtNewUrl
            // 
            txtNewUrl.Location = new Point(87, 266);
            txtNewUrl.Margin = new Padding(3, 2, 3, 2);
            txtNewUrl.Name = "txtNewUrl";
            txtNewUrl.Size = new Size(246, 23);
            txtNewUrl.TabIndex = 15;
            // 
            // txtNewTag
            // 
            txtNewTag.Location = new Point(368, 242);
            txtNewTag.Margin = new Padding(3, 2, 3, 2);
            txtNewTag.Name = "txtNewTag";
            txtNewTag.Size = new Size(246, 23);
            txtNewTag.TabIndex = 16;
            // 
            // cmbLinkType
            // 
            cmbLinkType.FormattingEnabled = true;
            cmbLinkType.Location = new Point(87, 242);
            cmbLinkType.Margin = new Padding(3, 2, 3, 2);
            cmbLinkType.Name = "cmbLinkType";
            cmbLinkType.Size = new Size(246, 23);
            cmbLinkType.TabIndex = 17;
            // 
            // btnAddLink
            // 
            btnAddLink.Location = new Point(280, 291);
            btnAddLink.Margin = new Padding(3, 2, 3, 2);
            btnAddLink.Name = "btnAddLink";
            btnAddLink.Size = new Size(25, 22);
            btnAddLink.TabIndex = 18;
            btnAddLink.Text = "+";
            btnAddLink.UseVisualStyleBackColor = true;
            // 
            // btnRemoveLink
            // 
            btnRemoveLink.Location = new Point(311, 291);
            btnRemoveLink.Margin = new Padding(3, 2, 3, 2);
            btnRemoveLink.Name = "btnRemoveLink";
            btnRemoveLink.Size = new Size(25, 22);
            btnRemoveLink.TabIndex = 19;
            btnRemoveLink.Text = "-";
            btnRemoveLink.UseVisualStyleBackColor = true;
            // 
            // btnAddTag
            // 
            btnAddTag.Location = new Point(559, 266);
            btnAddTag.Margin = new Padding(3, 2, 3, 2);
            btnAddTag.Name = "btnAddTag";
            btnAddTag.Size = new Size(27, 22);
            btnAddTag.TabIndex = 20;
            btnAddTag.Text = "+";
            btnAddTag.UseVisualStyleBackColor = true;
            // 
            // btnRemoveTag
            // 
            btnRemoveTag.Font = new Font("Segoe UI", 9F);
            btnRemoveTag.Location = new Point(592, 266);
            btnRemoveTag.Margin = new Padding(3, 2, 3, 2);
            btnRemoveTag.Name = "btnRemoveTag";
            btnRemoveTag.Size = new Size(24, 22);
            btnRemoveTag.TabIndex = 21;
            btnRemoveTag.Text = "-";
            btnRemoveTag.UseVisualStyleBackColor = true;
            // 
            // lblCommentsTitle
            // 
            lblCommentsTitle.AutoSize = true;
            lblCommentsTitle.Location = new Point(87, 91);
            lblCommentsTitle.Name = "lblCommentsTitle";
            lblCommentsTitle.Size = new Size(79, 15);
            lblCommentsTitle.TabIndex = 22;
            lblCommentsTitle.Text = "Kommentare:";
            // 
            // txtNewComment
            // 
            txtNewComment.Location = new Point(87, 160);
            txtNewComment.Margin = new Padding(3, 2, 3, 2);
            txtNewComment.Name = "txtNewComment";
            txtNewComment.Size = new Size(444, 23);
            txtNewComment.TabIndex = 24;
            // 
            // btnAddComment
            // 
            btnAddComment.Location = new Point(536, 160);
            btnAddComment.Margin = new Padding(3, 2, 3, 2);
            btnAddComment.Name = "btnAddComment";
            btnAddComment.Size = new Size(72, 20);
            btnAddComment.TabIndex = 25;
            btnAddComment.Text = "+";
            btnAddComment.UseVisualStyleBackColor = true;
            // 
            // lstComments
            // 
            lstComments.FormattingEnabled = true;
            lstComments.ItemHeight = 15;
            lstComments.Location = new Point(87, 108);
            lstComments.Margin = new Padding(3, 2, 3, 2);
            lstComments.Name = "lstComments";
            lstComments.Size = new Size(522, 49);
            lstComments.TabIndex = 26;
            // 
            // lbl_open_link
            // 
            lbl_open_link.AutoSize = true;
            lbl_open_link.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_open_link.Location = new Point(87, 295);
            lbl_open_link.Name = "lbl_open_link";
            lbl_open_link.Size = new Size(165, 15);
            lbl_open_link.TabIndex = 27;
            lbl_open_link.Text = "Doppelklick um Link zu öffnen";
            // 
            // InformationEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 361);
            Controls.Add(lbl_open_link);
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
            Margin = new Padding(3, 2, 3, 2);
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
        private Label lbl_open_link;
    }
}