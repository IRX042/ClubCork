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
			this.textBoxNev = new System.Windows.Forms.TextBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxRaktar = new System.Windows.Forms.TextBox();
			this.buttonPlusz = new System.Windows.Forms.Button();
			this.buttonMinusz = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.buttonKeszites = new System.Windows.Forms.Button();
			this.textBoxSKU = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.buttonMentes = new System.Windows.Forms.Button();
			this.buttonBeolvasas = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBoxNev
			// 
			this.textBoxNev.Location = new System.Drawing.Point(129, 32);
			this.textBoxNev.Name = "textBoxNev";
			this.textBoxNev.Size = new System.Drawing.Size(402, 20);
			this.textBoxNev.TabIndex = 0;
			this.textBoxNev.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// listBox1
			// 
			this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(59, 84);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(472, 355);
			this.listBox1.TabIndex = 1;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label1.Location = new System.Drawing.Point(589, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "Raktárkészlet:";
			// 
			// textBoxRaktar
			// 
			this.textBoxRaktar.Enabled = false;
			this.textBoxRaktar.Location = new System.Drawing.Point(693, 58);
			this.textBoxRaktar.Name = "textBoxRaktar";
			this.textBoxRaktar.Size = new System.Drawing.Size(100, 20);
			this.textBoxRaktar.TabIndex = 3;
			// 
			// buttonPlusz
			// 
			this.buttonPlusz.Location = new System.Drawing.Point(810, 44);
			this.buttonPlusz.Name = "buttonPlusz";
			this.buttonPlusz.Size = new System.Drawing.Size(34, 23);
			this.buttonPlusz.TabIndex = 4;
			this.buttonPlusz.Text = "+";
			this.buttonPlusz.UseVisualStyleBackColor = true;
			this.buttonPlusz.Click += new System.EventHandler(this.button1_Click);
			// 
			// buttonMinusz
			// 
			this.buttonMinusz.Location = new System.Drawing.Point(810, 73);
			this.buttonMinusz.Name = "buttonMinusz";
			this.buttonMinusz.Size = new System.Drawing.Size(34, 23);
			this.buttonMinusz.TabIndex = 5;
			this.buttonMinusz.Text = "-";
			this.buttonMinusz.UseVisualStyleBackColor = true;
			this.buttonMinusz.Click += new System.EventHandler(this.button2_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(56, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Termék név:";
			// 
			// buttonKeszites
			// 
			this.buttonKeszites.Location = new System.Drawing.Point(694, 189);
			this.buttonKeszites.Name = "buttonKeszites";
			this.buttonKeszites.Size = new System.Drawing.Size(80, 23);
			this.buttonKeszites.TabIndex = 7;
			this.buttonKeszites.Text = "Készítés";
			this.buttonKeszites.UseVisualStyleBackColor = true;
			this.buttonKeszites.Click += new System.EventHandler(this.buttonKeszites_Click);
			// 
			// textBoxSKU
			// 
			this.textBoxSKU.Location = new System.Drawing.Point(129, 58);
			this.textBoxSKU.Name = "textBoxSKU";
			this.textBoxSKU.Size = new System.Drawing.Size(402, 20);
			this.textBoxSKU.TabIndex = 8;
			this.textBoxSKU.Text = "123456";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(56, 61);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "Termék SKU:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(592, 218);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(431, 162);
			this.pictureBox1.TabIndex = 10;
			this.pictureBox1.TabStop = false;
			// 
			// buttonMentes
			// 
			this.buttonMentes.Location = new System.Drawing.Point(780, 189);
			this.buttonMentes.Name = "buttonMentes";
			this.buttonMentes.Size = new System.Drawing.Size(80, 23);
			this.buttonMentes.TabIndex = 11;
			this.buttonMentes.Text = "Mentés";
			this.buttonMentes.UseVisualStyleBackColor = true;
			this.buttonMentes.Click += new System.EventHandler(this.buttonMentes_Click);
			// 
			// buttonBeolvasas
			// 
			this.buttonBeolvasas.Location = new System.Drawing.Point(866, 189);
			this.buttonBeolvasas.Name = "buttonBeolvasas";
			this.buttonBeolvasas.Size = new System.Drawing.Size(80, 23);
			this.buttonBeolvasas.TabIndex = 12;
			this.buttonBeolvasas.Text = "Beolvasás";
			this.buttonBeolvasas.UseVisualStyleBackColor = true;
			this.buttonBeolvasas.Click += new System.EventHandler(this.buttonBeolvasas_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label4.Location = new System.Drawing.Point(589, 192);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(71, 17);
			this.label4.TabIndex = 13;
			this.label4.Text = "Vonalkód:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1078, 450);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.buttonBeolvasas);
			this.Controls.Add(this.buttonMentes);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxSKU);
			this.Controls.Add(this.buttonKeszites);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.buttonMinusz);
			this.Controls.Add(this.buttonPlusz);
			this.Controls.Add(this.textBoxRaktar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.textBoxNev);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxNev;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxRaktar;
		private System.Windows.Forms.Button buttonPlusz;
		private System.Windows.Forms.Button buttonMinusz;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonKeszites;
		private System.Windows.Forms.TextBox textBoxSKU;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button buttonMentes;
		private System.Windows.Forms.Button buttonBeolvasas;
		private System.Windows.Forms.Label label4;
	}
}

