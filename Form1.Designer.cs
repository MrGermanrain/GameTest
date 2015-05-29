namespace WindowsFormsApplication2
{
    partial class menuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(188, 36);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Monster Game";
            this.headerLabel.Click += new System.EventHandler(this.headerLabel_Click);
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(12, 48);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(93, 35);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "New Game";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(111, 48);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(89, 35);
            this.loadButton.TabIndex = 2;
            this.loadButton.Text = "Load Game";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(12, 284);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(93, 35);
            this.quitButton.TabIndex = 3;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "By Colin Koenig and Mac Feilmeier";
            // 
            // menuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(522, 323);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.headerLabel);
            this.Name = "menuForm";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Label label1;
    }
}

