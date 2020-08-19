/*
 * Created by SharpDevelop.
 * User: zen
 * Date: 09/07/2018
 * Time: 13.18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace CetakSEP
{
	partial class FormSetting
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ComboBox cbPrinter;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button buttonSimpan;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxRest;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSetting));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxRest = new System.Windows.Forms.TextBox();
			this.cbPrinter = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.buttonSimpan = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.textBoxRest);
			this.panel1.Controls.Add(this.cbPrinter);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.buttonSimpan);
			this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel1.Location = new System.Drawing.Point(42, 137);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(425, 161);
			this.panel1.TabIndex = 11;
			this.panel1.Visible = false;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(8, 18);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(94, 27);
			this.label5.TabIndex = 22;
			this.label5.Text = "REST Server";
			// 
			// textBoxRest
			// 
			this.textBoxRest.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxRest.Location = new System.Drawing.Point(120, 17);
			this.textBoxRest.Name = "textBoxRest";
			this.textBoxRest.Size = new System.Drawing.Size(242, 23);
			this.textBoxRest.TabIndex = 21;
			// 
			// cbPrinter
			// 
			this.cbPrinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbPrinter.FormattingEnabled = true;
			this.cbPrinter.Location = new System.Drawing.Point(120, 59);
			this.cbPrinter.Name = "cbPrinter";
			this.cbPrinter.Size = new System.Drawing.Size(242, 23);
			this.cbPrinter.TabIndex = 14;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(6, 61);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(119, 20);
			this.label3.TabIndex = 11;
			this.label3.Text = "Pilih Printer SEP";
			// 
			// buttonSimpan
			// 
			this.buttonSimpan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSimpan.BackColor = System.Drawing.SystemColors.Highlight;
			this.buttonSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSimpan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSimpan.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonSimpan.Location = new System.Drawing.Point(254, 109);
			this.buttonSimpan.Name = "buttonSimpan";
			this.buttonSimpan.Size = new System.Drawing.Size(137, 31);
			this.buttonSimpan.TabIndex = 11;
			this.buttonSimpan.Text = "&Simpan";
			this.buttonSimpan.UseVisualStyleBackColor = false;
			this.buttonSimpan.Click += new System.EventHandler(this.ButtonSimpanClick);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(52, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(0, 62);
			this.label2.TabIndex = 10;
			this.label2.Text = "Password";
			this.label2.Visible = false;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.Highlight;
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(515, 51);
			this.label1.TabIndex = 12;
			this.label1.Text = "Setting Printer";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(190, 73);
			this.textBox1.Name = "textBox1";
			this.textBox1.PasswordChar = '*';
			this.textBox1.Size = new System.Drawing.Size(178, 23);
			this.textBox1.TabIndex = 13;
			this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPasswordOnkeyPress);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(59, 73);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 14;
			this.label4.Text = "Password";
			// 
			// FormSetting
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.ClientSize = new System.Drawing.Size(515, 310);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormSetting";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormSetting";
			this.Load += new System.EventHandler(this.FormSettingLoad);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
