/*
 * Created by SharpDevelop.
 * User: zen
 * Date: 09/07/2018
 * Time: 13.18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Security.Cryptography;
using Newtonsoft.Json;
using System.IO;
using System.Text;

namespace CetakSEP
{
	/// <summary>
	/// Description of FormSetting.
	/// </summary>
	public partial class FormSetting : Form
	{
		public FormSetting()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			readSetting();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void FormSettingLoad(object sender, EventArgs e)
		{
			// Add list of installed printers found to the combo box.
		    // The pkInstalledPrinters string will be used to provide the display string.
		    String pkInstalledPrinters;
		    cbPrinter.Items.Add("Default Printer");
		    cbPrinter.Items.Add("Print via Excel");
		    for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++){
		        pkInstalledPrinters = PrinterSettings.InstalledPrinters[i];
		        cbPrinter.Items.Add(pkInstalledPrinters);
		    }
		}
		void ButtonSimpanClick(object sender, EventArgs e)
		{
			// serialize JSON to a string and then write string to a file
				var config = new Pengaturan
				{
					rest = textBoxRest.Text,
					namaprinter = cbPrinter.Text
				};
	 			File.WriteAllText(@".\config.json", JsonConvert.SerializeObject(config));
	 			MessageBox.Show("Setting tersimpan. Tutup dan buka kembali aplikasi untuk memperbarui setting.","Informasi");
		}
		private void readSetting()
        {
 			Pengaturan config = JsonConvert.DeserializeObject<Pengaturan>(File.ReadAllText(@".\config.json"));
 			cbPrinter.Text=config.namaprinter;
 			textBoxRest.Text = config.rest;
        }
				
		
		void textPasswordOnkeyPress(object sender, KeyPressEventArgs e)
		{			
			if(e.KeyChar==(char)13){
				var password = "adminkraton";
				if(textBox1.Text==password){
					panel1.Visible=true;
				}else{
					MessageBox.Show("maaf anda tidak bisa mengubah seting restserver dan printer","Info");
				}
			}
			
		}
	}
}
