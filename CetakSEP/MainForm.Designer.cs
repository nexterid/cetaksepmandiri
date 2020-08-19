/*
 * Created by SharpDevelop.
 * User: zen
 * Date: 07/07/2018
 * Time: 08.55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace CetakSEP
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Button buttonRM;
		private System.Windows.Forms.TextBox textBoxRM;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxRujukan;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dgvSEP;
		private System.Windows.Forms.Button buttonBuatSEP;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnbatal;
		private System.Windows.Forms.Button buttonRS;
		private System.Windows.Forms.Button buttonFaskes;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label labelKraton;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.buttonRM = new System.Windows.Forms.Button();
			this.textBoxRM = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.label6 = new System.Windows.Forms.Label();
			this.buttonRS = new System.Windows.Forms.Button();
			this.buttonFaskes = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.btnbatal = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dgvSEP = new System.Windows.Forms.DataGridView();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			this.buttonBuatSEP = new System.Windows.Forms.Button();
			this.textBoxRujukan = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.labelKraton = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.tabPage2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSEP)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabControl1.Location = new System.Drawing.Point(0, 120);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1074, 530);
			this.tabControl1.TabIndex = 2;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.tabPage1.Controls.Add(this.linkLabel1);
			this.tabPage1.Controls.Add(this.pictureBox3);
			this.tabPage1.Controls.Add(this.buttonRM);
			this.tabPage1.Controls.Add(this.textBoxRM);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1066, 504);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Input No RM";
			// 
			// linkLabel1
			// 
			this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.linkLabel1.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLabel1.LinkColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.linkLabel1.Location = new System.Drawing.Point(6, 476);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(71, 23);
			this.linkLabel1.TabIndex = 21;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Setting";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1LinkClicked);
			// 
			// pictureBox3
			// 
			this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox3.ErrorImage = null;
			this.pictureBox3.Image = global::CetakSEP.Properties.Resources.RSUD_KRATON;
			this.pictureBox3.Location = new System.Drawing.Point(824, 8);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(105, 65);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 20;
			this.pictureBox3.TabStop = false;
			// 
			// buttonRM
			// 
			this.buttonRM.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonRM.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.buttonRM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonRM.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonRM.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonRM.Location = new System.Drawing.Point(460, 120);
			this.buttonRM.Name = "buttonRM";
			this.buttonRM.Size = new System.Drawing.Size(143, 50);
			this.buttonRM.TabIndex = 3;
			this.buttonRM.Text = "CARI";
			this.buttonRM.UseVisualStyleBackColor = false;
			this.buttonRM.Click += new System.EventHandler(this.ButtonRMClick);
			// 
			// textBoxRM
			// 
			this.textBoxRM.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textBoxRM.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxRM.Location = new System.Drawing.Point(324, 58);
			this.textBoxRM.MaxLength = 6;
			this.textBoxRM.Name = "textBoxRM";
			this.textBoxRM.Size = new System.Drawing.Size(403, 35);
			this.textBoxRM.TabIndex = 1;
			this.textBoxRM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxRM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxRMKeyPress);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(3, 3);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(1057, 46);
			this.label2.TabIndex = 0;
			this.label2.Text = "MASUKAN / SCAN NOMOR RM";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.tabPage2.Controls.Add(this.label6);
			this.tabPage2.Controls.Add(this.buttonRS);
			this.tabPage2.Controls.Add(this.buttonFaskes);
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Controls.Add(this.btnbatal);
			this.tabPage2.Controls.Add(this.panel1);
			this.tabPage2.Controls.Add(this.pictureBox2);
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Controls.Add(this.buttonBuatSEP);
			this.tabPage2.Controls.Add(this.textBoxRujukan);
			this.tabPage2.Controls.Add(this.label3);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1066, 504);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Input No Rujukan";
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label6.Location = new System.Drawing.Point(735, 305);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(303, 54);
			this.label6.TabIndex = 24;
			this.label6.Text = "Gunakan Fasilitas cari Rujukan bila Anda tidak Membawa No Rujukan dari Faskes/ RS" +
	"";
			// 
			// buttonRS
			// 
			this.buttonRS.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonRS.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.buttonRS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonRS.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
			this.buttonRS.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonRS.Location = new System.Drawing.Point(900, 242);
			this.buttonRS.Name = "buttonRS";
			this.buttonRS.Size = new System.Drawing.Size(112, 35);
			this.buttonRS.TabIndex = 23;
			this.buttonRS.Text = "RujukanRS";
			this.buttonRS.UseVisualStyleBackColor = false;
			this.buttonRS.Click += new System.EventHandler(this.ButtonRSClick);
			// 
			// buttonFaskes
			// 
			this.buttonFaskes.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonFaskes.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.buttonFaskes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonFaskes.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
			this.buttonFaskes.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonFaskes.Location = new System.Drawing.Point(735, 242);
			this.buttonFaskes.Name = "buttonFaskes";
			this.buttonFaskes.Size = new System.Drawing.Size(126, 35);
			this.buttonFaskes.TabIndex = 22;
			this.buttonFaskes.Text = "RujukanFaskes";
			this.buttonFaskes.UseVisualStyleBackColor = false;
			this.buttonFaskes.Click += new System.EventHandler(this.ButtonFaskesClick);
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F);
			this.label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.label5.Location = new System.Drawing.Point(735, 165);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(303, 46);
			this.label5.TabIndex = 21;
			this.label5.Text = "Cari Rujukan";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnbatal
			// 
			this.btnbatal.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnbatal.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnbatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnbatal.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
			this.btnbatal.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.btnbatal.Location = new System.Drawing.Point(467, 305);
			this.btnbatal.Name = "btnbatal";
			this.btnbatal.Size = new System.Drawing.Size(125, 50);
			this.btnbatal.TabIndex = 12;
			this.btnbatal.Text = "BATAL";
			this.btnbatal.UseVisualStyleBackColor = false;
			this.btnbatal.Click += new System.EventHandler(this.BtnbatalClick);
			// 
			// panel1
			// 
			this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panel1.Controls.Add(this.dgvSEP);
			this.panel1.Location = new System.Drawing.Point(8, 73);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1030, 89);
			this.panel1.TabIndex = 20;
			// 
			// dgvSEP
			// 
			this.dgvSEP.AllowUserToAddRows = false;
			this.dgvSEP.AllowUserToDeleteRows = false;
			this.dgvSEP.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
			this.dgvSEP.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			this.dgvSEP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgvSEP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSEP.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvSEP.Location = new System.Drawing.Point(0, 0);
			this.dgvSEP.Name = "dgvSEP";
			this.dgvSEP.ReadOnly = true;
			this.dgvSEP.RowHeadersWidth = 5;
			this.dgvSEP.Size = new System.Drawing.Size(1030, 89);
			this.dgvSEP.TabIndex = 8;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox2.ErrorImage = null;
			this.pictureBox2.Image = global::CetakSEP.Properties.Resources.RSUD_KRATON;
			this.pictureBox2.Location = new System.Drawing.Point(824, 6);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(105, 65);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 19;
			this.pictureBox2.TabStop = false;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(3, 3);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(1057, 40);
			this.label4.TabIndex = 13;
			this.label4.Text = "DATA REGISTRASI RAWAT JALAN PASIEN";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// buttonBuatSEP
			// 
			this.buttonBuatSEP.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonBuatSEP.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.buttonBuatSEP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonBuatSEP.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonBuatSEP.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonBuatSEP.Location = new System.Drawing.Point(263, 305);
			this.buttonBuatSEP.Name = "buttonBuatSEP";
			this.buttonBuatSEP.Size = new System.Drawing.Size(135, 50);
			this.buttonBuatSEP.TabIndex = 12;
			this.buttonBuatSEP.Text = "CETAK SEP";
			this.buttonBuatSEP.UseVisualStyleBackColor = false;
			this.buttonBuatSEP.Click += new System.EventHandler(this.ButtonBuatSEPClick);
			// 
			// textBoxRujukan
			// 
			this.textBoxRujukan.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textBoxRujukan.BackColor = System.Drawing.Color.White;
			this.textBoxRujukan.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxRujukan.Location = new System.Drawing.Point(194, 242);
			this.textBoxRujukan.MaxLength = 0;
			this.textBoxRujukan.Name = "textBoxRujukan";
			this.textBoxRujukan.Size = new System.Drawing.Size(456, 35);
			this.textBoxRujukan.TabIndex = 0;
			this.textBoxRujukan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxRujukan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxRujukanKeyPress);
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(121, 160);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(637, 56);
			this.label3.TabIndex = 9;
			this.label3.Text = "Masukkan / Scan Nomor Rujukan";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1074, 145);
			this.label1.TabIndex = 1;
			this.label1.Text = "CETAK SEP BPJS";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelKraton
			// 
			this.labelKraton.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelKraton.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.labelKraton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.labelKraton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelKraton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.labelKraton.Location = new System.Drawing.Point(362, 108);
			this.labelKraton.Name = "labelKraton";
			this.labelKraton.Size = new System.Drawing.Size(351, 23);
			this.labelKraton.TabIndex = 3;
			this.labelKraton.Text = "RSUD KRATON KAB. PEKALONGAN";
			this.labelKraton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(1074, 652);
			this.Controls.Add(this.labelKraton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tabControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CetakSEP";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvSEP)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
