
namespace MethodeOhneEreignis
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtZahl1 = new System.Windows.Forms.TextBox();
			this.txtZahl2 = new System.Windows.Forms.TextBox();
			this.lblErgebnis = new System.Windows.Forms.Label();
			this.btnPlus = new System.Windows.Forms.Button();
			this.btnDivision = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtZahl1
			// 
			this.txtZahl1.Location = new System.Drawing.Point(12, 12);
			this.txtZahl1.Name = "txtZahl1";
			this.txtZahl1.Size = new System.Drawing.Size(100, 20);
			this.txtZahl1.TabIndex = 0;
			// 
			// txtZahl2
			// 
			this.txtZahl2.Location = new System.Drawing.Point(208, 13);
			this.txtZahl2.Name = "txtZahl2";
			this.txtZahl2.Size = new System.Drawing.Size(100, 20);
			this.txtZahl2.TabIndex = 1;
			// 
			// lblErgebnis
			// 
			this.lblErgebnis.AutoSize = true;
			this.lblErgebnis.Location = new System.Drawing.Point(342, 16);
			this.lblErgebnis.Name = "lblErgebnis";
			this.lblErgebnis.Size = new System.Drawing.Size(35, 13);
			this.lblErgebnis.TabIndex = 2;
			this.lblErgebnis.Text = "label1";
			// 
			// btnPlus
			// 
			this.btnPlus.Location = new System.Drawing.Point(129, 10);
			this.btnPlus.Name = "btnPlus";
			this.btnPlus.Size = new System.Drawing.Size(58, 23);
			this.btnPlus.TabIndex = 3;
			this.btnPlus.Text = "+";
			this.btnPlus.UseVisualStyleBackColor = true;
			this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
			// 
			// btnDivision
			// 
			this.btnDivision.Location = new System.Drawing.Point(129, 40);
			this.btnDivision.Name = "btnDivision";
			this.btnDivision.Size = new System.Drawing.Size(58, 23);
			this.btnDivision.TabIndex = 4;
			this.btnDivision.Text = "/";
			this.btnDivision.UseVisualStyleBackColor = true;
			this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(458, 77);
			this.Controls.Add(this.btnDivision);
			this.Controls.Add(this.btnPlus);
			this.Controls.Add(this.lblErgebnis);
			this.Controls.Add(this.txtZahl2);
			this.Controls.Add(this.txtZahl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtZahl1;
		private System.Windows.Forms.TextBox txtZahl2;
		private System.Windows.Forms.Label lblErgebnis;
		private System.Windows.Forms.Button btnPlus;
		private System.Windows.Forms.Button btnDivision;
	}
}

