namespace lukys_spotdl.Forms
{
    partial class SettingsForm
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            lblConfigPath = new Label();
            txbConfigPath = new TextBox();
            btnSetConfigPath = new Button();
            grpBoxConfig = new GroupBox();
            btnValidateConfig = new Button();
            grpBoxSpotdl = new GroupBox();
            btnUpdateSpotdl = new Button();
            grpBoxConfig.SuspendLayout();
            grpBoxSpotdl.SuspendLayout();
            SuspendLayout();
            // 
            // lblConfigPath
            // 
            lblConfigPath.AutoSize = true;
            lblConfigPath.Location = new Point(10, 25);
            lblConfigPath.Name = "lblConfigPath";
            lblConfigPath.Size = new Size(130, 15);
            lblConfigPath.TabIndex = 0;
            lblConfigPath.Text = "Path to the config.json:";
            // 
            // txbConfigPath
            // 
            txbConfigPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbConfigPath.Location = new Point(10, 40);
            txbConfigPath.Name = "txbConfigPath";
            txbConfigPath.ReadOnly = true;
            txbConfigPath.Size = new Size(380, 23);
            txbConfigPath.TabIndex = 1;
            // 
            // btnSetConfigPath
            // 
            btnSetConfigPath.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSetConfigPath.Location = new Point(395, 39);
            btnSetConfigPath.Name = "btnSetConfigPath";
            btnSetConfigPath.Size = new Size(100, 25);
            btnSetConfigPath.TabIndex = 2;
            btnSetConfigPath.Text = "Choose Path";
            btnSetConfigPath.UseVisualStyleBackColor = true;
            btnSetConfigPath.Click += btnSetConfigPath_Click;
            // 
            // grpBoxConfig
            // 
            grpBoxConfig.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpBoxConfig.Controls.Add(btnValidateConfig);
            grpBoxConfig.Controls.Add(txbConfigPath);
            grpBoxConfig.Controls.Add(btnSetConfigPath);
            grpBoxConfig.Controls.Add(lblConfigPath);
            grpBoxConfig.Location = new Point(10, 10);
            grpBoxConfig.Name = "grpBoxConfig";
            grpBoxConfig.Size = new Size(505, 100);
            grpBoxConfig.TabIndex = 3;
            grpBoxConfig.TabStop = false;
            grpBoxConfig.Text = "Configuration:";
            // 
            // btnValidateConfig
            // 
            btnValidateConfig.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnValidateConfig.Location = new Point(10, 70);
            btnValidateConfig.Name = "btnValidateConfig";
            btnValidateConfig.Size = new Size(485, 23);
            btnValidateConfig.TabIndex = 3;
            btnValidateConfig.Text = "Validate Config";
            btnValidateConfig.UseVisualStyleBackColor = true;
            btnValidateConfig.Click += btnValidateConfig_Click;
            // 
            // grpBoxSpotdl
            // 
            grpBoxSpotdl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpBoxSpotdl.Controls.Add(btnUpdateSpotdl);
            grpBoxSpotdl.Location = new Point(10, 120);
            grpBoxSpotdl.Name = "grpBoxSpotdl";
            grpBoxSpotdl.Size = new Size(505, 55);
            grpBoxSpotdl.TabIndex = 4;
            grpBoxSpotdl.TabStop = false;
            grpBoxSpotdl.Text = "Spotdl:";
            // 
            // btnUpdateSpotdl
            // 
            btnUpdateSpotdl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnUpdateSpotdl.Location = new Point(10, 25);
            btnUpdateSpotdl.Name = "btnUpdateSpotdl";
            btnUpdateSpotdl.Size = new Size(485, 23);
            btnUpdateSpotdl.TabIndex = 3;
            btnUpdateSpotdl.Text = "Update Spotdl";
            btnUpdateSpotdl.UseVisualStyleBackColor = true;
            btnUpdateSpotdl.Click += btnUpdateSpotdl_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grpBoxSpotdl);
            Controls.Add(grpBoxConfig);
            Name = "SettingsForm";
            Size = new Size(525, 255);
            grpBoxConfig.ResumeLayout(false);
            grpBoxConfig.PerformLayout();
            grpBoxSpotdl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblConfigPath;
        private TextBox txbConfigPath;
        private Button btnSetConfigPath;
        private GroupBox grpBoxConfig;
        private Button btnValidateConfig;
        private GroupBox grpBoxSpotdl;
        private Button btnUpdateSpotdl;
    }
}
