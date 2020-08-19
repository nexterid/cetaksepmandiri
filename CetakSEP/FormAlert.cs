/*
 * Created by SharpDevelop.
 * User: IT-ANDER
 * Date: 20/03/2019
 * Time: 8:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CetakSEP
{
	/// <summary>
	/// Description of FormAlert.
	/// </summary>
	public partial class FormAlert : Form
	{
		public FormAlert()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		private void formAlertLoad(object sender, EventArgs e)
		{
			icon_delay.Start();
			icon.Enabled=true;
		}
		
		private void icon_delay_Tick(object sender, EventArgs e)
		{
			icon.Enabled=false;
			icon_delay.Stop();
			this.Close();
		}
		void ButtonAlertClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
