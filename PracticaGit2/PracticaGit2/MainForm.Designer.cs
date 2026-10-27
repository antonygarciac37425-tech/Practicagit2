/*
 * Created by SharpDevelop.
 * User: CC2_PC18
 * Date: 27/10/2026
 * Time: 07:26 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PracticaGit2
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtNum1 = new System.Windows.Forms.TextBox();
			this.lblResultado = new System.Windows.Forms.Label();
			this.btnSuma = new System.Windows.Forms.Button();
			this.btnResta = new System.Windows.Forms.Button();
			this.btnMulti = new System.Windows.Forms.Button();
			this.btnDivid = new System.Windows.Forms.Button();
			this.txtNum2 = new System.Windows.Forms.TextBox();
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnModulo = new System.Windows.Forms.Button();
			this.btnFormula = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtNum1
			// 
			this.txtNum1.Location = new System.Drawing.Point(13, 12);
			this.txtNum1.Multiline = true;
			this.txtNum1.Name = "txtNum1";
			this.txtNum1.Size = new System.Drawing.Size(99, 48);
			this.txtNum1.TabIndex = 0;
			// 
			// lblResultado
			// 
			this.lblResultado.Location = new System.Drawing.Point(242, 12);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(100, 48);
			this.lblResultado.TabIndex = 1;
			// 
			// btnSuma
			// 
			this.btnSuma.Location = new System.Drawing.Point(13, 86);
			this.btnSuma.Name = "btnSuma";
			this.btnSuma.Size = new System.Drawing.Size(75, 58);
			this.btnSuma.TabIndex = 2;
			this.btnSuma.Text = "Sumar";
			this.btnSuma.UseVisualStyleBackColor = true;
			this.btnSuma.Click += new System.EventHandler(this.BtnSumaClick);
			// 
			// btnResta
			// 
			this.btnResta.Location = new System.Drawing.Point(108, 86);
			this.btnResta.Name = "btnResta";
			this.btnResta.Size = new System.Drawing.Size(75, 58);
			this.btnResta.TabIndex = 3;
			this.btnResta.Text = "Restar";
			this.btnResta.UseVisualStyleBackColor = true;
			this.btnResta.Click += new System.EventHandler(this.BtnRestaClick);
			// 
			// btnMulti
			// 
			this.btnMulti.Location = new System.Drawing.Point(206, 86);
			this.btnMulti.Name = "btnMulti";
			this.btnMulti.Size = new System.Drawing.Size(75, 58);
			this.btnMulti.TabIndex = 4;
			this.btnMulti.Text = "Multiplicar";
			this.btnMulti.UseVisualStyleBackColor = true;
			this.btnMulti.Click += new System.EventHandler(this.BtnMultiClick);
			// 
			// btnDivid
			// 
			this.btnDivid.Location = new System.Drawing.Point(308, 86);
			this.btnDivid.Name = "btnDivid";
			this.btnDivid.Size = new System.Drawing.Size(75, 58);
			this.btnDivid.TabIndex = 5;
			this.btnDivid.Text = "Dividir";
			this.btnDivid.UseVisualStyleBackColor = true;
			this.btnDivid.Click += new System.EventHandler(this.BtnDividClick);
			// 
			// txtNum2
			// 
			this.txtNum2.Location = new System.Drawing.Point(133, 12);
			this.txtNum2.Multiline = true;
			this.txtNum2.Name = "txtNum2";
			this.txtNum2.Size = new System.Drawing.Size(88, 48);
			this.txtNum2.TabIndex = 6;
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(13, 185);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 45);
			this.btnSalir.TabIndex = 7;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// btnModulo
			// 
			this.btnModulo.Location = new System.Drawing.Point(119, 185);
			this.btnModulo.Name = "btnModulo";
			this.btnModulo.Size = new System.Drawing.Size(86, 45);
			this.btnModulo.TabIndex = 8;
			this.btnModulo.Text = "Modulo";
			this.btnModulo.UseVisualStyleBackColor = true;
			this.btnModulo.Click += new System.EventHandler(this.BtnModuloClick);
			// 
			// btnFormula
			// 
			this.btnFormula.Location = new System.Drawing.Point(230, 185);
			this.btnFormula.Name = "btnFormula";
			this.btnFormula.Size = new System.Drawing.Size(77, 45);
			this.btnFormula.TabIndex = 9;
			this.btnFormula.Text = "Formula";
			this.btnFormula.UseVisualStyleBackColor = true;
			this.btnFormula.Click += new System.EventHandler(this.BtnFormulaClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(410, 251);
			this.Controls.Add(this.btnFormula);
			this.Controls.Add(this.btnModulo);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.txtNum2);
			this.Controls.Add(this.btnDivid);
			this.Controls.Add(this.btnMulti);
			this.Controls.Add(this.btnResta);
			this.Controls.Add(this.btnSuma);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.txtNum1);
			this.Name = "MainForm";
			this.Text = "FormFormula";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnFormula;
		private System.Windows.Forms.Button btnModulo;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.TextBox txtNum2;
		private System.Windows.Forms.Button btnDivid;
		private System.Windows.Forms.Button btnMulti;
		private System.Windows.Forms.Button btnResta;
		private System.Windows.Forms.Button btnSuma;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.TextBox txtNum1;
	}
}
