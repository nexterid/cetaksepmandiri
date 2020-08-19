/*
 * Created by SharpDevelop.
 * User: IT-ANDER
 * Date: 18/03/2019
 * Time: 11:33
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
	/// Description of RujukanRSForm.
	/// </summary>
	public partial class RujukanRSForm : Form
	{
		
		string rest;
		RestClient client = new RestClient();
		public static string noKartu_bpjs, kode_polidpjp, textNoRujukan;
		
		public RujukanRSForm()
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
				
				var request = new RestRequest("/rujukan/rs/list/peserta/" + noKartu_bpjs + "", Method.GET);
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
			        	
			        	tabeldata.Rows.Add(noRujukan, tglRujukan, nama,kodepoli, namaPoli, dokter);
			        	
			        	dataGridViewRujukanRS.DataSource = tabeldata;
			        	
//			        	this.dataGridViewRujukan.Columns["noRujukan"].HeaderText = "No Rujukan";
				        this.dataGridViewRujukanRS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				        this.dataGridViewRujukanRS.Columns[1].Width = 200;
				        this.dataGridViewRujukanRS.Columns[2].Width = 150;
				        this.dataGridViewRujukanRS.Columns[4].Width = 80;
				        this.dataGridViewRujukanRS.Columns[5].Width = 200;
				        this.dataGridViewRujukanRS.DefaultCellStyle.Font = new Font("Segoe UI", 12);
				        this.dataGridViewRujukanRS.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
			        }
		        			        
                }
                else
                {               	
//                	MessageBox.Show(balasan.metaData.message, "Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);    
					var tabeldata = new DataTable();
                	tabeldata.Columns.Add("No Rujukan", typeof(string));
			        tabeldata.Columns.Add("Tgl Rujukan", typeof(string));
			        tabeldata.Columns.Add("Nama Pasien", typeof(string));
			        tabeldata.Columns.Add("Kode", typeof(string));
			        tabeldata.Columns.Add("Nama Poli", typeof(string));
			        tabeldata.Columns.Add("Asal Rujukan", typeof(string));
			        
			        dataGridViewRujukanRS.DataSource = tabeldata;
			        this.dataGridViewRujukanRS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			        this.dataGridViewRujukanRS.Columns[1].Width = 200;
			        this.dataGridViewRujukanRS.Columns[2].Width = 150;
			        this.dataGridViewRujukanRS.Columns[4].Width = 80;
			        this.dataGridViewRujukanRS.Columns[5].Width = 200;
			        this.dataGridViewRujukanRS.DefaultCellStyle.Font = new Font("Segoe UI", 12);
			        this.dataGridViewRujukanRS.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
			        
			        labelWarning.Visible=true;
                }
				
			}
			catch(Exception ex)
			{				
				MessageBox.Show("Error saat mencari data rujukan: " + ex.Message, "Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
				this.Close();
			}
			
		}	
		
		void DataGridViewRujukanRSClick(object sender, MouseEventArgs e)
		{
			getDataGridValue();
		}
		
		private void getDataGridValue()
		{
			var i = dataGridViewRujukanRS.CurrentRow.Index;
			if (dataGridViewRujukanRS.Rows.Count > 0 )
			{
				var norujukan = dataGridViewRujukanRS.Rows[i].Cells[1].Value.ToString();	
				var kodepoli = dataGridViewRujukanRS.Rows[i].Cells[4].Value.ToString();	
				if(kode_polidpjp == kodepoli ){
					textNoRujukan = norujukan;
					this.Close();
				}else{
					MessageBox.Show("Maaf Poli Rujukan yang anda pilih tidak sesuai dengan poli pendaftaran saat ini !","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
				}				
			}
		}
		
		void ButtonKembali2Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
