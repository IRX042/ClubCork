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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(188)))), ((int)(((byte)(168)))));
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(43)))), ((int)(((byte)(44)))));
			this.label3.Location = new System.Drawing.Point(16, 43);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 18);
			this.label3.TabIndex = 14;
			this.label3.Text = "Termék SKU:";
			// 
			// textBoxSKU
			// 
			this.textBoxSKU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(188)))), ((int)(((byte)(168)))));
			this.textBoxSKU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxSKU.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxSKU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(43)))), ((int)(((byte)(44)))));
			this.textBoxSKU.Location = new System.Drawing.Point(113, 40);
			this.textBoxSKU.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.textBoxSKU.Name = "textBoxSKU";
			this.textBoxSKU.Size = new System.Drawing.Size(535, 23);
			this.textBoxSKU.TabIndex = 13;
			this.textBoxSKU.TextChanged += new System.EventHandler(this.textBoxSKU_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(188)))), ((int)(((byte)(168)))));
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(43)))), ((int)(((byte)(44)))));
			this.label2.Location = new System.Drawing.Point(16, 11);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(92, 18);
			this.label2.TabIndex = 12;
			this.label2.Text = "Termék név:";
			// 
			// listBox1
			// 
			this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(188)))), ((int)(((byte)(168)))));
			this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(43)))), ((int)(((byte)(44)))));
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 16;
			this.listBox1.Location = new System.Drawing.Point(20, 93);
			this.listBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(628, 450);
			this.listBox1.TabIndex = 11;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// textBoxNev
			// 
			this.textBoxNev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(188)))), ((int)(((byte)(168)))));
			this.textBoxNev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxNev.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxNev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(43)))), ((int)(((byte)(44)))));
			this.textBoxNev.Location = new System.Drawing.Point(113, 8);
			this.textBoxNev.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.textBoxNev.Name = "textBoxNev";
			this.textBoxNev.Size = new System.Drawing.Size(535, 23);
			this.textBoxNev.TabIndex = 10;
			this.textBoxNev.TextChanged += new System.EventHandler(this.textBoxNev_TextChanged);
			// 
			// buttonMinusz
			// 
			this.buttonMinusz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonMinusz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(188)))), ((int)(((byte)(168)))));
			this.buttonMinusz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonMinusz.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonMinusz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(43)))), ((int)(((byte)(44)))));
			this.buttonMinusz.Location = new System.Drawing.Point(936, 223);
			this.buttonMinusz.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.buttonMinusz.Name = "buttonMinusz";
			this.buttonMinusz.Size = new System.Drawing.Size(45, 29);
			this.buttonMinusz.TabIndex = 18;
			this.buttonMinusz.Text = "-";
			this.buttonMinusz.UseVisualStyleBackColor = false;
			this.buttonMinusz.Click += new System.EventHandler(this.buttonMinusz_Click);
			// 
			// buttonPlusz
			// 
			this.buttonPlusz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonPlusz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(188)))), ((int)(((byte)(168)))));
			this.buttonPlusz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonPlusz.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonPlusz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(43)))), ((int)(((byte)(44)))));
			this.buttonPlusz.Location = new System.Drawing.Point(936, 188);
			this.buttonPlusz.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.buttonPlusz.Name = "buttonPlusz";
			this.buttonPlusz.Size = new System.Drawing.Size(45, 29);
			this.buttonPlusz.TabIndex = 17;
			this.buttonPlusz.Text = "+";
			this.buttonPlusz.UseVisualStyleBackColor = false;
			this.buttonPlusz.Click += new System.EventHandler(this.buttonPlusz_Click);
			// 
			// textBoxRaktar
			// 
			this.textBoxRaktar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxRaktar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(188)))), ((int)(((byte)(168)))));
			this.textBoxRaktar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxRaktar.Enabled = false;
			this.textBoxRaktar.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxRaktar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(43)))), ((int)(((byte)(44)))));
			this.textBoxRaktar.Location = new System.Drawing.Point(821, 204);
			this.textBoxRaktar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.textBoxRaktar.Name = "textBoxRaktar";
			this.textBoxRaktar.Size = new System.Drawing.Size(110, 26);
			this.textBoxRaktar.TabIndex = 16;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(188)))), ((int)(((byte)(168)))));
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(43)))), ((int)(((byte)(44)))));
			this.label1.Location = new System.Drawing.Point(692, 206);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 21);
			this.label1.TabIndex = 15;
			this.label1.Text = "Raktárkészlet:";
			// 
			// buttonTorles
			// 
			this.buttonTorles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(188)))), ((int)(((byte)(168)))));
			this.buttonTorles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonTorles.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonTorles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(43)))), ((int)(((byte)(44)))));
			this.buttonTorles.Location = new System.Drawing.Point(696, 423);
			this.buttonTorles.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.buttonTorles.Name = "buttonTorles";
			this.buttonTorles.Size = new System.Drawing.Size(107, 29);
			this.buttonTorles.TabIndex = 24;
			this.buttonTorles.Text = "Törlés";
			this.buttonTorles.UseVisualStyleBackColor = false;
			this.buttonTorles.Click += new System.EventHandler(this.buttonTorles_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(188)))), ((int)(((byte)(168)))));
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(43)))), ((int)(((byte)(44)))));
			this.label4.Location = new System.Drawing.Point(692, 292);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(87, 21);
			this.label4.TabIndex = 23;
			this.label4.Text = "Vonalkód:";
			// 
			// buttonBeolvasas
			// 
			this.buttonBeolvasas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(188)))), ((int)(((byte)(168)))));
			this.buttonBeolvasas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonBeolvasas.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonBeolvasas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(43)))), ((int)(((byte)(44)))));
			this.buttonBeolvasas.Location = new System.Drawing.Point(696, 352);
			this.buttonBeolvasas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.buttonBeolvasas.Name = "buttonBeolvasas";
			this.buttonBeolvasas.Size = new System.Drawing.Size(107, 29);
			this.buttonBeolvasas.TabIndex = 22;
			this.buttonBeolvasas.Text = "Beolvasás";
			this.buttonBeolvasas.UseVisualStyleBackColor = false;
			this.buttonBeolvasas.Click += new System.EventHandler(this.buttonBeolvasas_Click);
			// 
			// buttonMentes
			// 
			this.buttonMentes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(188)))), ((int)(((byte)(168)))));
			this.buttonMentes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonMentes.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonMentes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(43)))), ((int)(((byte)(44)))));
			this.buttonMentes.Location = new System.Drawing.Point(696, 388);
			this.buttonMentes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.buttonMentes.Name = "buttonMentes";
			this.buttonMentes.Size = new System.Drawing.Size(107, 29);
			this.buttonMentes.TabIndex = 21;
			this.buttonMentes.Text = "Mentés";
			this.buttonMentes.UseVisualStyleBackColor = false;
			this.buttonMentes.Click += new System.EventHandler(this.buttonMentes_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(188)))), ((int)(((byte)(168)))));
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(821, 317);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(160, 100);
			this.pictureBox1.TabIndex = 20;
			this.pictureBox1.TabStop = false;
			// 
			// buttonKeszites
			// 
			this.buttonKeszites.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(188)))), ((int)(((byte)(168)))));
			this.buttonKeszites.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonKeszites.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonKeszites.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(43)))), ((int)(((byte)(44)))));
			this.buttonKeszites.Location = new System.Drawing.Point(696, 317);
			this.buttonKeszites.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.buttonKeszites.Name = "buttonKeszites";
			this.buttonKeszites.Size = new System.Drawing.Size(107, 29);
			this.buttonKeszites.TabIndex = 19;
			this.buttonKeszites.Text = "Készítés";
			this.buttonKeszites.UseVisualStyleBackColor = false;
			this.buttonKeszites.Click += new System.EventHandler(this.buttonKeszites_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(930, 8);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(100, 100);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 26;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(679, 8);
			this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(252, 100);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 27;
			this.pictureBox3.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(188)))), ((int)(((byte)(168)))));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(1045, 568);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
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
			this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(43)))), ((int)(((byte)(44)))));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MaximumSize = new System.Drawing.Size(1061, 607);
			this.MinimumSize = new System.Drawing.Size(1061, 607);
			this.Name = "Form1";
			this.Text = "Clubcork™ Raktárkészlet kezelő";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
	}
}

