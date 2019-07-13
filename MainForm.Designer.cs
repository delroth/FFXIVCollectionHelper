namespace FFXIVCollectHelper
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.monitoringExplanationLabel = new System.Windows.Forms.Label();
            this.monitoringProgressIndicator = new System.Windows.Forms.PictureBox();
            this.copyButton = new System.Windows.Forms.Button();
            this.importExplanationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.monitoringProgressIndicator)).BeginInit();
            this.SuspendLayout();
            // 
            // monitoringExplanationLabel
            // 
            this.monitoringExplanationLabel.AutoSize = true;
            this.monitoringExplanationLabel.Location = new System.Drawing.Point(34, 14);
            this.monitoringExplanationLabel.Name = "monitoringExplanationLabel";
            this.monitoringExplanationLabel.Size = new System.Drawing.Size(470, 13);
            this.monitoringExplanationLabel.TabIndex = 0;
            this.monitoringExplanationLabel.Text = "Monitoring for player information. If already logged into XIV, please log out. Th" +
    "en log into the game.";
            // 
            // monitoringProgressIndicator
            // 
            this.monitoringProgressIndicator.Image = global::FFXIVCollectHelper.Properties.Resources.spinner;
            this.monitoringProgressIndicator.Location = new System.Drawing.Point(12, 12);
            this.monitoringProgressIndicator.Name = "monitoringProgressIndicator";
            this.monitoringProgressIndicator.Size = new System.Drawing.Size(16, 16);
            this.monitoringProgressIndicator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.monitoringProgressIndicator.TabIndex = 1;
            this.monitoringProgressIndicator.TabStop = false;
            // 
            // copyButton
            // 
            this.copyButton.Enabled = false;
            this.copyButton.Location = new System.Drawing.Point(409, 60);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(110, 23);
            this.copyButton.TabIndex = 2;
            this.copyButton.Text = "Copy to clipboard";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.OnCopyButtonClicked);
            // 
            // importExplanationLabel
            // 
            this.importExplanationLabel.Enabled = false;
            this.importExplanationLabel.Location = new System.Drawing.Point(13, 60);
            this.importExplanationLabel.Name = "importExplanationLabel";
            this.importExplanationLabel.Size = new System.Drawing.Size(380, 46);
            this.importExplanationLabel.TabIndex = 3;
            this.importExplanationLabel.Text = "Once ready to import into collect.raelys.com, click the Copy button. Then, in you" +
    "r web browser, press F12 on the FFXIV Collect page, go to the \"Console\" tab, pas" +
    "te the import code, and press enter.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 115);
            this.Controls.Add(this.importExplanationLabel);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.monitoringProgressIndicator);
            this.Controls.Add(this.monitoringExplanationLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "FFXIV Collect Helper";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClose);
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.monitoringProgressIndicator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label monitoringExplanationLabel;
        private System.Windows.Forms.PictureBox monitoringProgressIndicator;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Label importExplanationLabel;
    }
}

