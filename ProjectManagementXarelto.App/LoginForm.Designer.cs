namespace ProjectManagementXarelto.App
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            btnManger = new Button();
            btnLead = new Button();
            label_Benutzer = new Label();
            SuspendLayout();
            // 
            // btnManger
            // 
            btnManger.Location = new Point(192, 235);
            btnManger.Name = "btnManger";
            btnManger.Size = new Size(141, 41);
            btnManger.TabIndex = 0;
            btnManger.Text = "Projekt Mitarbeiter";
            btnManger.UseVisualStyleBackColor = true;
            btnManger.Click += btnManager_Click;
            // 
            // btnLead
            // 
            btnLead.Location = new Point(432, 235);
            btnLead.Name = "btnLead";
            btnLead.Size = new Size(134, 41);
            btnLead.TabIndex = 1;
            btnLead.Text = "Projektleiter";
            btnLead.UseVisualStyleBackColor = true;
            btnLead.Click += btnLead_Click;
            // 
            // label_Benutzer
            // 
            label_Benutzer.AutoSize = true;
            label_Benutzer.Font = new Font("Segoe UI", 18F);
            label_Benutzer.Location = new Point(267, 106);
            label_Benutzer.Name = "label_Benutzer";
            label_Benutzer.Size = new Size(253, 41); 
            label_Benutzer.TabIndex = 2;
            label_Benutzer.Text = "Benutzer Auswahl";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label_Benutzer);
            Controls.Add(btnManger);
            Controls.Add(btnLead);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnManger;
        private Button btnLead;
        private Label label_Benutzer;
    }
}
