namespace MStoPP
{
    partial class Form
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
            this.impTxtBtn = new System.Windows.Forms.Button();
            this.impTextBox = new System.Windows.Forms.TextBox();
            this.expBtn = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.dynStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // impTxtBtn
            // 
            this.impTxtBtn.Location = new System.Drawing.Point(529, 31);
            this.impTxtBtn.Name = "impTxtBtn";
            this.impTxtBtn.Size = new System.Drawing.Size(97, 30);
            this.impTxtBtn.TabIndex = 0;
            this.impTxtBtn.Text = "Import TXT";
            this.impTxtBtn.UseVisualStyleBackColor = true;
            this.impTxtBtn.Click += new System.EventHandler(this.impTxtBtn_Click);
            // 
            // impTextBox
            // 
            this.impTextBox.Location = new System.Drawing.Point(12, 35);
            this.impTextBox.Name = "impTextBox";
            this.impTextBox.Size = new System.Drawing.Size(511, 22);
            this.impTextBox.TabIndex = 1;
            this.impTextBox.TextChanged += new System.EventHandler(this.impTextBox_TextChanged);
            // 
            // expBtn
            // 
            this.expBtn.Enabled = false;
            this.expBtn.Location = new System.Drawing.Point(529, 79);
            this.expBtn.Name = "expBtn";
            this.expBtn.Size = new System.Drawing.Size(97, 40);
            this.expBtn.TabIndex = 2;
            this.expBtn.Text = "Export";
            this.expBtn.UseVisualStyleBackColor = true;
            this.expBtn.Click += new System.EventHandler(this.expBtn_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dynStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 136);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(638, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "Status";
            // 
            // dynStatusLabel
            // 
            this.dynStatusLabel.Name = "dynStatusLabel";
            this.dynStatusLabel.Size = new System.Drawing.Size(0, 16);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 158);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.expBtn);
            this.Controls.Add(this.impTextBox);
            this.Controls.Add(this.impTxtBtn);
            this.MaximizeBox = false;
            this.Name = "Form";
            this.Text = "MediaShout to ProPresenter Converter";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button impTxtBtn;
        private System.Windows.Forms.TextBox impTextBox;
        private System.Windows.Forms.Button expBtn;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel dynStatusLabel;
    }
}

