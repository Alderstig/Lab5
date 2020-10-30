namespace Lab5WindowsForms
{
    partial class Form1
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxoutput = new System.Windows.Forms.TextBox();
            this.buttonExtract = new System.Windows.Forms.Button();
            this.labelLinkCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(1159, 1001);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(161, 49);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save images";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(12, 26);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(1152, 31);
            this.textBoxInput.TabIndex = 1;
            this.textBoxInput.Text = "Input link i.e \'google.com\'";
            this.textBoxInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxInput_KeyDown);
            // 
            // textBoxoutput
            // 
            this.textBoxoutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxoutput.Location = new System.Drawing.Point(12, 71);
            this.textBoxoutput.Multiline = true;
            this.textBoxoutput.Name = "textBoxoutput";
            this.textBoxoutput.ReadOnly = true;
            this.textBoxoutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxoutput.Size = new System.Drawing.Size(1308, 898);
            this.textBoxoutput.TabIndex = 2;
            // 
            // buttonExtract
            // 
            this.buttonExtract.Location = new System.Drawing.Point(1170, 26);
            this.buttonExtract.Name = "buttonExtract";
            this.buttonExtract.Size = new System.Drawing.Size(161, 39);
            this.buttonExtract.TabIndex = 3;
            this.buttonExtract.Text = "Extract";
            this.buttonExtract.UseVisualStyleBackColor = true;
            this.buttonExtract.Click += new System.EventHandler(this.buttonExtract_Click);
            // 
            // labelLinkCount
            // 
            this.labelLinkCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelLinkCount.AutoSize = true;
            this.labelLinkCount.Location = new System.Drawing.Point(7, 1001);
            this.labelLinkCount.Name = "labelLinkCount";
            this.labelLinkCount.Size = new System.Drawing.Size(408, 25);
            this.labelLinkCount.TabIndex = 4;
            this.labelLinkCount.Text = "Number of images found in input link: N/A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 1062);
            this.Controls.Add(this.labelLinkCount);
            this.Controls.Add(this.buttonExtract);
            this.Controls.Add(this.textBoxoutput);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.buttonSave);
            this.MinimumSize = new System.Drawing.Size(1378, 1133);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImageScraper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxoutput;
        private System.Windows.Forms.Button buttonExtract;
        private System.Windows.Forms.Label labelLinkCount;
    }
}

