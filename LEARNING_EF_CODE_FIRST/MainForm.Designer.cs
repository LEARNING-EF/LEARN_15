namespace LEARNING_EF_CODE_FIRST
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;

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
			this.solution1Button = new System.Windows.Forms.Button();
			this.solution2Button = new System.Windows.Forms.Button();
			this.solution4Button = new System.Windows.Forms.Button();
			this.solution3Button = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// solution1Button
			// 
			this.solution1Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.solution1Button.Location = new System.Drawing.Point(12, 12);
			this.solution1Button.Name = "solution1Button";
			this.solution1Button.Size = new System.Drawing.Size(260, 23);
			this.solution1Button.TabIndex = 0;
			this.solution1Button.Text = "Solution (1)";
			this.solution1Button.UseVisualStyleBackColor = true;
			this.solution1Button.Click += new System.EventHandler(this.Solution1Button_Click);
			// 
			// solution2Button
			// 
			this.solution2Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.solution2Button.Location = new System.Drawing.Point(12, 41);
			this.solution2Button.Name = "solution2Button";
			this.solution2Button.Size = new System.Drawing.Size(260, 23);
			this.solution2Button.TabIndex = 1;
			this.solution2Button.Text = "Solution (2)";
			this.solution2Button.UseVisualStyleBackColor = true;
			this.solution2Button.Click += new System.EventHandler(this.Solution2Button_Click);
			// 
			// solution4Button
			// 
			this.solution4Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.solution4Button.Location = new System.Drawing.Point(12, 99);
			this.solution4Button.Name = "solution4Button";
			this.solution4Button.Size = new System.Drawing.Size(260, 23);
			this.solution4Button.TabIndex = 3;
			this.solution4Button.Text = "Solution (4)";
			this.solution4Button.UseVisualStyleBackColor = true;
			this.solution4Button.Click += new System.EventHandler(this.Solution4Button_Click);
			// 
			// solution3Button
			// 
			this.solution3Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.solution3Button.Location = new System.Drawing.Point(12, 70);
			this.solution3Button.Name = "solution3Button";
			this.solution3Button.Size = new System.Drawing.Size(260, 23);
			this.solution3Button.TabIndex = 2;
			this.solution3Button.Text = "Solution (3)";
			this.solution3Button.UseVisualStyleBackColor = true;
			this.solution3Button.Click += new System.EventHandler(this.Solution3Button_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.solution4Button);
			this.Controls.Add(this.solution3Button);
			this.Controls.Add(this.solution2Button);
			this.Controls.Add(this.solution1Button);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Main";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button solution1Button;
		private System.Windows.Forms.Button solution2Button;
		private System.Windows.Forms.Button solution4Button;
		private System.Windows.Forms.Button solution3Button;
	}
}
