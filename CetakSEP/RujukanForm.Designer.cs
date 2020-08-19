/*
 * Created by SharpDevelop.
 * User: IT-ANDER
 * Date: 18/03/2019
 * Time: 8:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace CetakSEP
{
	partial class RujukanForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridViewRujukan;
		private System.Windows.Forms.Button buttonKembali;
		private System.Windows.Forms.DataGridViewButtonColumn ColumnAksi;
		private System.Windows.Forms.Label labelWarning;
		
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RujukanForm));
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridViewRujukan = new System.Windows.Forms.DataGridView();
			this.ColumnAksi = new System.Windows.Forms.DataGridViewButtonColumn();
			this.buttonKembali = new System.Windows.Forms.Button();
			this.labelWarning = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewRujukan)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Italic);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(708, 35);
			this.label1.TabIndex = 0;
			this.label1.Text = "Silahkan pilih rujukan dari faskes yang masih berlaku sesuai poli yang anda tuju " +
	"!";
			// 
			// dataGridViewRujukan
			// 
			this.dataGridViewRujukan.AllowUserToAddRows = false;
			this.dataGridViewRujukan.AllowUserToDeleteRows = false;
			this.dataGridViewRujukan.AllowUserToResizeColumns = false;
			this.dataGridViewRujukan.AllowUserToResizeRows = false;
			this.dataGridViewRujukan.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridViewRujukan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridViewRujukan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewRujukan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.ColumnAksi});
			this.dataGridViewRujukan.Location = new System.Drawing.Point(12, 47);
			this.dataGridViewRujukan.Name = "dataGridViewRujukan";
			this.dataGridViewRujukan.RowHeadersWidth = 4;
			this.dataGridViewRujukan.RowTemplate.Height = 35;
			this.dataGridViewRujukan.Size = new System.Drawing.Size(1035, 273);
			this.dataGridViewRujukan.TabIndex = 1;
			this.dataGridViewRujukan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGridViewRujukanClick);
			// 
			// ColumnAksi
			// 
			this.ColumnAksi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CadetBlue;
			this.ColumnAksi.DefaultCellStyle = dataGridViewCellStyle1;
			this.ColumnAksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ColumnAksi.HeaderText = "Aksi";
			this.ColumnAksi.Name = "ColumnAksi";
			this.ColumnAksi.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.ColumnAksi.Text = "Pilih";
			this.ColumnAksi.UseColumnTextForButtonValue = true;
			this.ColumnAksi.Width = 70;
			// 
			// buttonKembali
			// 
			this.buttonKembali.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonKembali.BackColor = System.Drawing.SystemColors.Highlight;
			this.buttonKembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonKembali.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			this.buttonKembali.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonKembali.Location = new System.Drawing.Point(908, 337);
			this.buttonKembali.Name = "buttonKembali";
			this.buttonKembali.Size = new System.Drawing.Size(139, 50);
			this.buttonKembali.TabIndex = 2;
			this.buttonKembali.Text = "Kembali";
			this.buttonKembali.UseVisualStyleBackColor = false;
			this.buttonKembali.Click += new System.EventHandler(this.ButtonKembaliClick);
			// 
			// labelWarning
			// 
			this.labelWarning.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic);
			this.labelWarning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.labelWarning.Location = new System.Drawing.Point(12, 349);
			this.labelWarning.Name = "labelWarning";
			this.labelWarning.Size = new System.Drawing.Size(342, 29);
			this.labelWarning.TabIndex = 4;
			this.labelWarning.Text = "*) Maaf data Rujukan tidak ditemukan !";
			this.labelWarning.Visible = false;
			// 
			// RujukanForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.ClientSize = new System.Drawing.Size(1059, 410);
			this.ControlBox = false;
			this.Controls.Add(this.labelWarning);
			this.Controls.Add(this.buttonKembali);
			this.Controls.Add(this.dataGridViewRujukan);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "RujukanForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RUJUKAN FASKES";
			this.Load += new System.EventHandler(this.RujukanFormLod);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewRujukan)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
