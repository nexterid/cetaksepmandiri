/*
 * Created by SharpDevelop.
 * User: IT-ANDER
 * Date: 18/03/2019
 * Time: 8:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using RestSharp;
using Newtonsoft.Json;
using System.IO;

namespace CetakSEP
{
	/// <summary>
	/// Description of RujukanForm.
	/// </summary>
	public partial class RujukanForm : Form
	{
					
		string rest;
		RestClient client = new RestClient();
		public static string noKartu_bpjs,kode_polidpjp, textNoRujukan;
		
		public RujukanForm()
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
		
		private void readSetting()
        {
 			Pengaturan config = JsonConvert.DeserializeObject<Pengaturan>(File.ReadAllText(@".\config.json"));
 			rest = config.rest;
 			client = new RestClient(rest);
        }
		
	
		void RujukanFormLod(object sender, EventArgs e)
		{
			showGrid();	
		}
		
		private void showGrid()
		{
			try
			{
				
				var request = new RestRequest("/rujukan/list/peserta/" + noKartu_bpjs + "", Method.GET);
//	            var queryResult = client.Execute<model.getDataReg>(request).Data;
	            
	            var result = client.Execute(request);
                var content = result.Content;
                var balasan = JsonConvert.DeserializeObject<model.getRujukanListClass>(content);	
	             
	            if (balasan.metaData.code=="200")
                {                	
            		//buat datatable untuk menampung data dari api
                	var tabeldata = new DataTable();
                	tabeldata.Columns.Add("No Rujukan", typeof(string));
			        tabeldata.Columns.Add("Tgl Rujukan", typeof(string));
			        tabeldata.Columns.Add("Nama Pasien", typeof(string));
			        tabeldata.Columns.Add("Kode", typeof(string));
			        tabeldata.Columns.Add("Nama Poli", typeof(string));
			        tabeldata.Columns.Add("Asal Rujukan", typeof(string));	

			        for (int i = 0; i < balasan.response.rujukan.Length; i++ )
			        {
			        	var data= balasan.response.rujukan[i];
			        	var noRujukan = data.noKunjungan;
			        	var tglRujukan = data.tglKunjungan;
			        	var nama = data.peserta.nama;
			        	var kodepoli = data.poliRujukan.kode;
			        	var namaPoli = data.poliRujukan.nama;
			        	var dokter = data.provPerujuk.nama;
			        	
			        	tabeldata.Rows.Add(noRujukan, tglRujukan, nama, kodepoli, namaPoli, dokter);
			        	
			        	dataGridViewRujukan.DataSource = tabeldata;
			        	
//			        	this.dataGridViewRujukan.Columns["noRujukan"].HeaderText = "No Rujukan";
				        this.dataGridViewRujukan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				        this.dataGridViewRujukan.Columns[1].Width = 200;
				        this.dataGridViewRujukan.Columns[2].Width = 150;
				        this.dataGridViewRujukan.Columns[4].Width = 80;
				        this.dataGridViewRujukan.Columns[5].Width = 200;
				        this.dataGridViewRujukan.DefaultCellStyle.Font = new Font("Segoe UI", 12);
				        this.dataGridViewRujukan.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
			        }
		        			        
                }
                else
                {
//                	MessageBox.Show(balasan.metaData.message, "Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					labelWarning.Visible = true;
					var tabeldata = new DataTable();
                	tabeldata.Columns.Add("No Rujukan", typeof(string));
			        tabeldata.Columns.Add("Tgl Rujukan", typeof(string));
			        tabeldata.Columns.Add("Nama Pasien", typeof(string));
			        tabeldata.Columns.Add("Kode", typeof(string));
			        tabeldata.Columns.Add("Nama Poli", typeof(string));
			        tabeldata.Columns.Add("Asal Rujukan", typeof(string));
			        
			        dataGridViewRujukan.DataSource = tabeldata;
			        this.dataGridViewRujukan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			        this.dataGridViewRujukan.Columns[1].Width = 200;
			        this.dataGridViewRujukan.Columns[2].Width = 150;
			        this.dataGridViewRujukan.Columns[4].Width = 80;
			        this.dataGridViewRujukan.Columns[5].Width = 200;
			        this.dataGridViewRujukan.DefaultCellStyle.Font = new Font("Segoe UI", 12);
			        this.dataGridViewRujukan.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);			        
                }
				
			}
			catch(Exception ex)
			{
				MessageBox.Show("Error saat mencari data rujukan: " + ex.Message, "Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			
		}
		
		void DataGridViewRujukanClick(object sender, MouseEventArgs e)
		{
			getDataGridValue();
//			MessageBox.Show("masuk sini gan");
		}
		
		private void getDataGridValue()
		{
			var i = dataGridViewRujukan.CurrentRow.Index;
			if (dataGridViewRujukan.Rows.Count > 0 )
			{
				var norujukan = dataGridViewRujukan.Rows[i].Cells[1].Value.ToString();	
				var kodepoli = dataGridViewRujukan.Rows[i].Cells[4].Value.ToString();	
				if(kode_polidpjp == kodepoli ){
					textNoRujukan = norujukan;
					this.Close();
				}else{
					MessageBox.Show("Maaf Poli Rujukan yang anda pilih tidak sesuai dengan poli pendaftaran saat ini !","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
				}								
			}
		}
		
		void ButtonKembaliClick(object sender, EventArgs e)
		{
			this.Close();
		}		
		
	}
}
