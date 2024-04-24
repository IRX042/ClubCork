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
			this.buttonMinusz = new System.Windows.Forms.Button();
			this.buttonPlusz = new System.Windows.Forms.Button();
			this.textBoxRaktar = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonTorles = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.buttonBeolvasas = new System.Windows.Forms.Button();
			this.buttonMentes = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.buttonKeszites = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
			this.textBoxSKU.TextChanged += new System.EventHandler(this.textBoxSKU_TextChanged);
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
			this.listBox1.Location = new System.Drawing.Point(15, 76);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(472, 368);
			this.listBox1.TabIndex = 11;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// textBoxNev
			// 
			this.textBoxNev.Location = new System.Drawing.Point(85, 6);
			this.textBoxNev.Name = "textBoxNev";
			this.textBoxNev.Size = new System.Drawing.Size(402, 20);
			this.textBoxNev.TabIndex = 10;
			this.textBoxNev.TextChanged += new System.EventHandler(this.textBoxNev_TextChanged);
			// 
			// buttonMinusz
			// 
			this.buttonMinusz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonMinusz.Location = new System.Drawing.Point(725, 94);
			this.buttonMinusz.Name = "buttonMinusz";
			this.buttonMinusz.Size = new System.Drawing.Size(34, 23);
			this.buttonMinusz.TabIndex = 18;
			this.buttonMinusz.Text = "-";
			this.buttonMinusz.UseVisualStyleBackColor = true;
			this.buttonMinusz.Click += new System.EventHandler(this.buttonMinusz_Click);
			// 
			// buttonPlusz
			// 
			this.buttonPlusz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonPlusz.Location = new System.Drawing.Point(725, 65);
			this.buttonPlusz.Name = "buttonPlusz";
			this.buttonPlusz.Size = new System.Drawing.Size(34, 23);
			this.buttonPlusz.TabIndex = 17;
			this.buttonPlusz.Text = "+";
			this.buttonPlusz.UseVisualStyleBackColor = true;
			this.buttonPlusz.Click += new System.EventHandler(this.buttonPlusz_Click);
			// 
			// textBoxRaktar
			// 
			this.textBoxRaktar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxRaktar.Enabled = false;
			this.textBoxRaktar.Location = new System.Drawing.Point(608, 79);
			this.textBoxRaktar.Name = "textBoxRaktar";
			this.textBoxRaktar.Size = new System.Drawing.Size(100, 20);
			this.textBoxRaktar.TabIndex = 16;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label1.Location = new System.Drawing.Point(504, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 17);
			this.label1.TabIndex = 15;
			this.label1.Text = "Raktárkészlet:";
			// 
			// buttonTorles
			// 
			this.buttonTorles.Location = new System.Drawing.Point(507, 279);
			this.buttonTorles.Name = "buttonTorles";
			this.buttonTorles.Size = new System.Drawing.Size(80, 23);
			this.buttonTorles.TabIndex = 24;
			this.buttonTorles.Text = "Törlés";
			this.buttonTorles.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label4.Location = new System.Drawing.Point(504, 172);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(71, 17);
			this.label4.TabIndex = 23;
			this.label4.Text = "Vonalkód:";
			// 
			// buttonBeolvasas
			// 
			this.buttonBeolvasas.Location = new System.Drawing.Point(507, 221);
			this.buttonBeolvasas.Name = "buttonBeolvasas";
			this.buttonBeolvasas.Size = new System.Drawing.Size(80, 23);
			this.buttonBeolvasas.TabIndex = 22;
			this.buttonBeolvasas.Text = "Beolvasás";
			this.buttonBeolvasas.UseVisualStyleBackColor = true;
			// 
			// buttonMentes
			// 
			this.buttonMentes.Location = new System.Drawing.Point(507, 250);
			this.buttonMentes.Name = "buttonMentes";
			this.buttonMentes.Size = new System.Drawing.Size(80, 23);
			this.buttonMentes.TabIndex = 21;
			this.buttonMentes.Text = "Mentés";
			this.buttonMentes.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(593, 181);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(166, 112);
			this.pictureBox1.TabIndex = 20;
			this.pictureBox1.TabStop = false;
			// 
			// buttonKeszites
			// 
			this.buttonKeszites.Location = new System.Drawing.Point(507, 192);
			this.buttonKeszites.Name = "buttonKeszites";
			this.buttonKeszites.Size = new System.Drawing.Size(80, 23);
			this.buttonKeszites.TabIndex = 19;
			this.buttonKeszites.Text = "Készítés";
			this.buttonKeszites.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 461);
			this.Controls.Add(this.buttonTorles);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.buttonBeolvasas);
			this.Controls.Add(this.buttonMentes);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.buttonKeszites);
			this.Controls.Add(this.buttonMinusz);
			this.Controls.Add(this.buttonPlusz);
			this.Controls.Add(this.textBoxRaktar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxSKU);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.textBoxNev);
			this.MaximumSize = new System.Drawing.Size(800, 500);
			this.MinimumSize = new System.Drawing.Size(800, 500);
			this.Name = "Form1";
			this.Text = "Kliensalkalmazás";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxSKU;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.TextBox textBoxNev;
		private System.Windows.Forms.Button buttonMinusz;
		private System.Windows.Forms.Button buttonPlusz;
		private System.Windows.Forms.TextBox textBoxRaktar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonTorles;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button buttonBeolvasas;
		private System.Windows.Forms.Button buttonMentes;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button buttonKeszites;
	}
}

