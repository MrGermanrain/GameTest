namespace WindowsFormsApplication2
{
    partial class loadForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loadForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.saveBox = new System.Windows.Forms.RichTextBox();
            this.doneButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(188, 36);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Monster Game";
            // 
            // saveBox
            // 
            this.saveBox.Location = new System.Drawing.Point(12, 48);
            this.saveBox.Name = "saveBox";
            this.saveBox.Size = new System.Drawing.Size(188, 98);
            this.saveBox.TabIndex = 2;
            this.saveBox.Text = "Paste your save here!";
            this.saveBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(12, 152);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(188, 23);
            this.doneButton.TabIndex = 3;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            // 
            // loadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(522, 323);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.saveBox);
            this.Controls.Add(this.headerLabel);
            this.Name = "loadForm";
            this.Text = "Load Game";
            this.Load += new System.EventHandler(this.loadForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.RichTextBox saveBox;
        private System.Windows.Forms.Button doneButton;
    }
}