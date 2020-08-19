/*
 * Created by SharpDevelop.
 * User: IT-ANDER
 * Date: 20/03/2019
 * Time: 8:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace CetakSEP
{
	partial class FormAlert
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox icon;
		private System.Windows.Forms.Timer icon_delay;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonAlert;
		
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlert));
			this.icon = new System.Windows.Forms.PictureBox();
			this.icon_delay = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.buttonAlert = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
			this.SuspendLayout();
			// 
			// icon
			// 
			this.icon.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.icon.BackColor = System.Drawing.Color.LightBlue;
			this.icon.Enabled = false;
			this.icon.Image = ((System.Drawing.Image)(resources.GetObject("icon.Image")));
			this.icon.Location = new System.Drawing.Point(113, 4);
			this.icon.Margin = new System.Windows.Forms.Padding(1);
			this.icon.Name = "icon";
			this.icon.Size = new System.Drawing.Size(244, 171);
			this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.icon.TabIndex = 0;
			this.icon.TabStop = false;
			// 
			// icon_delay
			// 
			this.icon_delay.Enabled = true;
			this.icon_delay.Interval = 6000;
			this.icon_delay.Tick += new System.EventHandler(this.icon_delay_Tick);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label1.Location = new System.Drawing.Point(91, 149);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(289, 63);
			this.label1.TabIndex = 1;
			this.label1.Text = "Berhasil membuat SEP, silahkan ambil SEP dari printer cetak SEP dibawah ! kemudia" +
	"n klik OK ";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// buttonAlert
			// 
			this.buttonAlert.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.buttonAlert.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonAlert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAlert.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonAlert.Location = new System.Drawing.Point(187, 234);
			this.buttonAlert.Name = "buttonAlert";
			this.buttonAlert.Size = new System.Drawing.Size(96, 45);
			this.buttonAlert.TabIndex = 2;
			this.buttonAlert.Text = "OK";
			this.buttonAlert.UseVisualStyleBackColor = false;
			this.buttonAlert.Click += new System.EventHandler(this.ButtonAlertClick);
			// 
			// FormAlert
			// 
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.CancelButton = this.buttonAlert;
			this.ClientSize = new System.Drawing.Size(464, 307);
			this.Controls.Add(this.buttonAlert);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.icon);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormAlert";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.formAlertLoad);
			((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
