/*
 * Created by SharpDevelop.
 * User: IT-ANDER
 * Date: 18/03/2019
 * Time: 11:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace CetakSEP
{
	partial class RujukanRSForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridViewRujukanRS;
		private System.Windows.Forms.Button buttonKembali2;
		private System.Windows.Forms.DataGridViewButtonColumn Aksi;
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
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridViewRujukanRS = new System.Windows.Forms.DataGridView();
			this.Aksi = new System.Windows.Forms.DataGridViewButtonColumn();
			this.buttonKembali2 = new System.Windows.Forms.Button();
			this.labelWarning = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewRujukanRS)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Italic);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(837, 36);
			this.label1.TabIndex = 0;
			this.label1.Text = "Silahkan pilih rujukan dari rumah sakit yang masih berlaku sesuai poli yang anda " +
	"tuju !";
			// 
			// dataGridViewRujukanRS
			// 
			this.dataGridViewRujukanRS.AllowUserToAddRows = false;
			this.dataGridViewRujukanRS.AllowUserToDeleteRows = false;
			this.dataGridViewRujukanRS.AllowUserToResizeColumns = false;
			this.dataGridViewRujukanRS.AllowUserToResizeRows = false;
			this.dataGridViewRujukanRS.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridViewRujukanRS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridViewRujukanRS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewRujukanRS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.Aksi});
			this.dataGridViewRujukanRS.Location = new System.Drawing.Point(12, 55);
			this.dataGridViewRujukanRS.Name = "dataGridViewRujukanRS";
			this.dataGridViewRujukanRS.RowHeadersWidth = 4;
			this.dataGridViewRujukanRS.RowTemplate.Height = 35;
			this.dataGridViewRujukanRS.Size = new System.Drawing.Size(1035, 273);
			this.dataGridViewRujukanRS.TabIndex = 1;
			this.dataGridViewRujukanRS.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGridViewRujukanRSClick);
			// 
			// Aksi
			// 
			this.Aksi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CadetBlue;
			this.Aksi.DefaultCellStyle = dataGridViewCellStyle1;
			this.Aksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Aksi.HeaderText = "Aksi";
			this.Aksi.Name = "Aksi";
			this.Aksi.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Aksi.Text = "Pilih";
			this.Aksi.UseColumnTextForButtonValue = true;
			this.Aksi.Width = 70;
			// 
			// buttonKembali2
			// 
			this.buttonKembali2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonKembali2.BackColor = System.Drawing.SystemColors.Highlight;
			this.buttonKembali2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonKembali2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			this.buttonKembali2.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonKembali2.Location = new System.Drawing.Point(908, 348);
			this.buttonKembali2.Name = "buttonKembali2";
			this.buttonKembali2.Size = new System.Drawing.Size(139, 50);
			this.buttonKembali2.TabIndex = 2;
			this.buttonKembali2.Text = "Kembali";
			this.buttonKembali2.UseVisualStyleBackColor = false;
			this.buttonKembali2.Click += new System.EventHandler(this.ButtonKembali2Click);
			// 
			// labelWarning
			// 
			this.labelWarning.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic);
			this.labelWarning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.labelWarning.Location = new System.Drawing.Point(13, 348);
			this.labelWarning.Name = "labelWarning";
			this.labelWarning.Size = new System.Drawing.Size(342, 29);
			this.labelWarning.TabIndex = 3;
			this.labelWarning.Text = "*) Maaf data Rujukan tidak ditemukan !";
			this.labelWarning.Visible = false;
			// 
			// RujukanRSForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.ClientSize = new System.Drawing.Size(1059, 410);
			this.ControlBox = false;
			this.Controls.Add(this.labelWarning);
			this.Controls.Add(this.buttonKembali2);
			this.Controls.Add(this.dataGridViewRujukanRS);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "RujukanRSForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RUJUKAN RUMAH SAKIT";
			this.Load += new System.EventHandler(this.RujukanFormLod);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewRujukanRS)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
