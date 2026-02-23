namespace ProjectManagementXarelto.App {
    partial class InformationCreateForm {
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
            lblCreateInformationText = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // txtInfoText
            // 
            txtInfoText.Location = new Point(70, 61);
            txtInfoText.Multiline = true;
            txtInfoText.Name = "txtInfoText";
            txtInfoText.Size = new Size(600, 122);
            txtInfoText.TabIndex = 22;
            // 
            // lblCreateInformationText
            // 
            lblCreateInformationText.AutoSize = true;
            lblCreateInformationText.Location = new Point(70, 29);
            lblCreateInformationText.Name = "lblCreateInformationText";
            lblCreateInformationText.Size = new Size(90, 20);
            lblCreateInformationText.TabIndex = 23;
            lblCreateInformationText.Text = "Information:";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(449, 393);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(132, 29);
            btnCancel.TabIndex = 25;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(600, 393);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(131, 29);
            btnSave.TabIndex = 26;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // InformationCreateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(lblCreateInformationText);
            Controls.Add(txtInfoText);
            Name = "InformationCreateForm";
            Text = "InformationCreateForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInfoText;
        private Label lblCreateInformationText;
        private Button btnCancel;
        private Button btnSave;
    }
}