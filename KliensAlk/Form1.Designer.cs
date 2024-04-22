namespace KliensAlk
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
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxSKU = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.textBoxNev = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 35);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 13);
			this.label3.TabIndex = 14;
			this.label3.Text = "Termék SKU:";
			// 
			// textBoxSKU
			// 
			this.textBoxSKU.Location = new System.Drawing.Point(85, 32);
			this.textBoxSKU.Name = "textBoxSKU";
			this.textBoxSKU.Size = new System.Drawing.Size(402, 20);
			this.textBoxSKU.TabIndex = 13;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 13);
			this.label2.TabIndex = 12;
			this.label2.Text = "Termék név:";
			// 
			// listBox1
			// 
			this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(15, 65);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(472, 342);
			this.listBox1.TabIndex = 11;
			// 
			// textBoxNev
			// 
			this.textBoxNev.Location = new System.Drawing.Point(85, 6);
			this.textBoxNev.Name = "textBoxNev";
			this.textBoxNev.Size = new System.Drawing.Size(402, 20);
			this.textBoxNev.TabIndex = 10;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxSKU);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.textBoxNev);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxSKU;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.TextBox textBoxNev;
	}
}

