namespace elexFog
{
    partial class elexFog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(elexFog));
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.buttonPath = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.comboBoxAction = new System.Windows.Forms.ComboBox();
            this.linkLabelAuthor = new System.Windows.Forms.LinkLabel();
            this.pictureBoxComparision = new System.Windows.Forms.PictureBox();
            this.labelBefore = new System.Windows.Forms.Label();
            this.labelAfter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxComparision)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPath
            // 
            this.textBoxPath.Enabled = false;
            this.textBoxPath.Location = new System.Drawing.Point(80, 32);
            this.textBoxPath.MaximumSize = new System.Drawing.Size(200, 20);
            this.textBoxPath.MinimumSize = new System.Drawing.Size(200, 20);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(200, 20);
            this.textBoxPath.TabIndex = 0;
            this.textBoxPath.Text = "Select game path... ->";
            // 
            // buttonPath
            // 
            this.buttonPath.Location = new System.Drawing.Point(300, 32);
            this.buttonPath.Name = "buttonPath";
            this.buttonPath.Size = new System.Drawing.Size(40, 20);
            this.buttonPath.TabIndex = 1;
            this.buttonPath.Text = "...";
            this.buttonPath.UseVisualStyleBackColor = true;
            this.buttonPath.Click += new System.EventHandler(this.buttonPath_Click);
            // 
            // buttonApply
            // 
            this.buttonApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApply.Enabled = false;
            this.buttonApply.Location = new System.Drawing.Point(717, 32);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(64, 20);
            this.buttonApply.TabIndex = 4;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // comboBoxAction
            // 
            this.comboBoxAction.Enabled = false;
            this.comboBoxAction.FormattingEnabled = true;
            this.comboBoxAction.Items.AddRange(new object[] {
            "Remove Fog",
            "Adjust Fog",
            "Restore Defaults"});
            this.comboBoxAction.Location = new System.Drawing.Point(430, 32);
            this.comboBoxAction.Name = "comboBoxAction";
            this.comboBoxAction.Size = new System.Drawing.Size(120, 21);
            this.comboBoxAction.TabIndex = 5;
            this.comboBoxAction.SelectedIndexChanged += new System.EventHandler(this.comboBoxAction_SelectedIndexChanged);
            // 
            // linkLabelAuthor
            // 
            this.linkLabelAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelAuthor.AutoSize = true;
            this.linkLabelAuthor.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelAuthor.Location = new System.Drawing.Point(800, 500);
            this.linkLabelAuthor.Name = "linkLabelAuthor";
            this.linkLabelAuthor.Size = new System.Drawing.Size(60, 13);
            this.linkLabelAuthor.TabIndex = 6;
            this.linkLabelAuthor.TabStop = true;
            this.linkLabelAuthor.Text = "by Murzinio";
            this.linkLabelAuthor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAuthor_LinkClicked);
            // 
            // pictureBoxComparision
            // 
            this.pictureBoxComparision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxComparision.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxComparision.Image")));
            this.pictureBoxComparision.Location = new System.Drawing.Point(80, 100);
            this.pictureBoxComparision.Name = "pictureBoxComparision";
            this.pictureBoxComparision.Size = new System.Drawing.Size(700, 394);
            this.pictureBoxComparision.TabIndex = 7;
            this.pictureBoxComparision.TabStop = false;
            // 
            // labelBefore
            // 
            this.labelBefore.AutoSize = true;
            this.labelBefore.BackColor = System.Drawing.Color.Silver;
            this.labelBefore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBefore.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBefore.ForeColor = System.Drawing.Color.Black;
            this.labelBefore.Location = new System.Drawing.Point(80, 64);
            this.labelBefore.Name = "labelBefore";
            this.labelBefore.Size = new System.Drawing.Size(73, 28);
            this.labelBefore.TabIndex = 8;
            this.labelBefore.Text = "Before:";
            // 
            // labelAfter
            // 
            this.labelAfter.AutoSize = true;
            this.labelAfter.BackColor = System.Drawing.Color.Silver;
            this.labelAfter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAfter.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAfter.ForeColor = System.Drawing.Color.Black;
            this.labelAfter.Location = new System.Drawing.Point(430, 64);
            this.labelAfter.Name = "labelAfter";
            this.labelAfter.Size = new System.Drawing.Size(62, 28);
            this.labelAfter.TabIndex = 9;
            this.labelAfter.Text = "After:";
            // 
            // elexFog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 524);
            this.Controls.Add(this.labelAfter);
            this.Controls.Add(this.labelBefore);
            this.Controls.Add(this.pictureBoxComparision);
            this.Controls.Add(this.linkLabelAuthor);
            this.Controls.Add(this.comboBoxAction);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.buttonPath);
            this.Controls.Add(this.textBoxPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(900, 563);
            this.MinimumSize = new System.Drawing.Size(900, 563);
            this.Name = "elexFog";
            this.Text = "Elex Fog Tweaker";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxComparision)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button buttonPath;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.ComboBox comboBoxAction;
        private System.Windows.Forms.LinkLabel linkLabelAuthor;
        private System.Windows.Forms.PictureBox pictureBoxComparision;
        private System.Windows.Forms.Label labelBefore;
        private System.Windows.Forms.Label labelAfter;
    }
}

