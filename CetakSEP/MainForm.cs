/*
 * Created by SharpDevelop.
 * User: zen
 * Date: 07/07/2018
 * Time: 08.55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json;
using GemBox.Spreadsheet;
using System.IO;
using System.Text;


namespace CetakSEP
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		string rest;
		RestClient client = new RestClient();
		
//		string global = new Global();
		string namaprinter;
		string noRM;
		string noSEP;
		string no_SJP;
		string tglSEPstring;
		string noRegistrasi;
		string noKartu;
		string norujukanbpjs;
		string kodeDpjp;
		string poli;
		string faskes1;
		string jenisfaskes;
		string antrian;
		string diagnosaAwal;
		string kodeDiagnosa;
		//string diagnosaUtama;
		//string tindakan;
		string nama;
		string tglLahir;
		string jnsKelamin;
		string alamat;
		string noTelp;
		string peserta;
		//string cob;
		string jnsRawat;
		string klsTanggungan;
		string catatan;
		string tglKunjungan;
		string ppkRujukan;
		string kodepoli;
		string noKartu_pasien;
		string tgl_reg;
		string kodepoli_dpjp;
		string pesertaPrb;
		//string penjamin;	
		
		public MainForm()
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
 			namaprinter = config.namaprinter;
 			rest = config.rest;
 			client = new RestClient(rest);
        }
		
		void MainFormLoad(object sender, EventArgs e)
		{
			textBoxRM.Focus();
		}
		
		public static void EnableTab(TabPage page, bool enable)
		{
		    EnableControls(page.Controls, enable);
		}
		
		private static void EnableControls(Control.ControlCollection ctls, bool enable)
		{
		    foreach (Control ctl in ctls)
		    {
		        ctl.Enabled = enable;
		        EnableControls(ctl.Controls, enable);
		    }
		}
		
		//button cari no RM di klik 
		void ButtonRMClick(object sender, EventArgs e)
		{
			if(textBoxRM.Text == ""){
				MessageBox.Show("Silahkan Masukan No RM / input form tidak boleh kosong !", "Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}			
			else if (textBoxRM.Text.Length < 6)
			{
				MessageBox.Show("Nomor yang anda masukkan kurang dari 6 digit. Mohon periksa kembali.", "Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			else
			{
				noRM = textBoxRM.Text;
				getDataRegistrasi();
			}
			
		}
		
		//masukan no RM di enter
		void TextBoxRMKeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
			
			if (e.KeyChar == (char)13)
            {
					if(textBoxRM.Text == ""){
						MessageBox.Show("Silahkan Masukan No RM / input form tidak boleh kosong !", "Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					}			
					else if (textBoxRM.Text.Length < 6)
					{
						MessageBox.Show("Nomor yang anda masukkan kurang dari 6 digit. Mohon periksa kembali.", "Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					}
					else
					{
						noRM = textBoxRM.Text;
						getDataRegistrasi();
					}
            }
		}
		
		//button buat SEP di klik
		void ButtonBuatSEPClick(object sender, EventArgs e)
		{
			var txtNoRujukan=textBoxRujukan.Text;
			if(txtNoRujukan == "")
			{
				MessageBox.Show("Silahkan Masukan Nomor Rujukan Anda", "Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}	
			else if(txtNoRujukan.Length==6)
			{
				//MessageBox.Show("ini kode rujukan internal");
				cariRujukanInternal();
				//set tab
//				EnableTab(tabControl1.TabPages[tabControl1.SelectedIndex = 0], true);
//	            EnableTab(tabControl1.TabPages[tabControl1.SelectedIndex = 1], false);
//	            tabControl1.SelectedIndex = 0;
	            //kosongkan isian
//	            textBoxRM.Text = "";
	            textBoxRujukan.Text = "";
				
			}else{
				//MessageBox.Show("ini kode rujukan external");
				getRujukan();
				//Set Tab
//	            EnableTab(tabControl1.TabPages[tabControl1.SelectedIndex = 0], true);
//	            EnableTab(tabControl1.TabPages[tabControl1.SelectedIndex = 1], false);
//	            tabControl1.SelectedIndex = 0;
	            //kosongkan isian
//	            textBoxRM.Text = "";
	            textBoxRujukan.Text = "";
			}					
	
		}
		
		//form input rujukan di enter
		void TextBoxRujukanKeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13)
            {
				var str=textBoxRujukan.Text;
				if(str == "")
				{
					MessageBox.Show("Silahkan Masukan Nomor Rujukan Anda", "Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
				}	
				else if(str.Length==6)
				{
//					MessageBox.Show("ini kode rujukan internal");
					cariRujukanInternal();
					//set tab
//					EnableTab(tabControl1.TabPages[tabControl1.SelectedIndex = 0], true);
//		            EnableTab(tabControl1.TabPages[tabControl1.SelectedIndex = 1], false);
//		            tabControl1.SelectedIndex = 0;
		            //kosongkan isian
//		            textBoxRM.Text = "";
		            textBoxRujukan.Text = "";
					
				}else{
					getRujukan();
//						//Set Tab
//		            EnableTab(tabControl1.TabPages[tabControl1.SelectedIndex = 0], true);
//		            EnableTab(tabControl1.TabPages[tabControl1.SelectedIndex = 1], false);
//		            tabControl1.SelectedIndex = 0;
		            //kosongkan isian
//		            textBoxRM.Text = "";
		            textBoxRujukan.Text = "";
				}
				
			}
		}
		
		//Method untuk get data registrasi ke BPJS
		private void getDataRegistrasi()
        {
            try
            {
                var request = new RestRequest("/data/registrasi/" + noRM + "", Method.GET);
                var queryResult = client.Execute<model.getDataReg>(request).Data;
                
                if (queryResult.ok == true)
                {
                	//pindah tab
		            EnableTab(tabControl1.TabPages[tabControl1.SelectedIndex = 0], false);
		            EnableTab(tabControl1.TabPages[tabControl1.SelectedIndex = 1], true);
		            tabControl1.SelectedIndex = 1;
            		//buat datatable untuk menampung data dari api
                	var tabeldata = new DataTable();
                	tabeldata.Columns.Add("NO REG", typeof(string));
			        tabeldata.Columns.Add("TANGGAL REG", typeof(string));
			        tabeldata.Columns.Add("NAMA PASIEN", typeof(string));
			        tabeldata.Columns.Add("ALAMAT", typeof(string));
			        tabeldata.Columns.Add("NAMA POLI", typeof(string));
			        tabeldata.Columns.Add("DOKTER", typeof(string));
			        
			        noRegistrasi = queryResult.hasil.no_reg;
			        
			        var tglreg = queryResult.hasil.tgl_reg.ToString("dd-MMM-yyyy");
			        tgl_reg = queryResult.hasil.tgl_reg.ToString("yyyy-MM-dd");
			        
			        nama = queryResult.hasil.nama_pasien;
			        var alamatpendek = queryResult.hasil.alamat;
			        alamat = queryResult.hasil.alamat_lengkap;
			        var namapoli = queryResult.hasil.kd_poli_dpjp+" - "+queryResult.hasil.nama_sub_unit;
			        var dokter = queryResult.hasil.nama_pegawai;
			        antrian = queryResult.hasil.antrian;
			        no_SJP = queryResult.hasil.no_SJP;
			        noTelp = queryResult.hasil.no_telp;
			        noKartu_pasien= queryResult.hasil.no_kartu;
			        kodepoli_dpjp = queryResult.hasil.kd_poli_dpjp;

			        tabeldata.Rows.Add(noRegistrasi, tglreg, nama, alamatpendek, namapoli, dokter);
			        
			        dgvSEP.DataSource = tabeldata;
			        this.dgvSEP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			        this.dgvSEP.DefaultCellStyle.Font = new Font("Segoe UI", 12);
			        this.dgvSEP.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);

			        textBoxRujukan.Focus();
			        
                }
                else
                {
                	MessageBox.Show(queryResult.pesan, "Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                	textBoxRM.Text = "";
                }
            }
            catch (Exception ex)
            {
            	MessageBox.Show(ex.Message);
            }
        }
		//Method untuk mendapatkan data rujukan BPJS
		private void getRujukan()
		{
			try
            {
                var request = new RestRequest("/rujukan/"+textBoxRujukan.Text+"", Method.GET);
                var result = client.Execute(request);
                var content = result.Content;
                //parsing json dengan Newtonsoft.Json.Net
                var balasan = JsonConvert.DeserializeObject<model.getRujukanClass>(content);
                
                if (balasan.metaData.code=="200")
                {	        
			        faskes1 = balasan.response.rujukan.provPerujuk.nama;
			        jnsRawat = balasan.response.rujukan.pelayanan.nama;
			        kodeDiagnosa = balasan.response.rujukan.diagnosa.kode;
			        tglKunjungan = balasan.response.rujukan.tglKunjungan;
			        ppkRujukan = balasan.response.rujukan.provPerujuk.kode;
			        kodepoli = balasan.response.rujukan.poliRujukan.kode;
			        noKartu = balasan.response.rujukan.peserta.noKartu;			      
			        
			        // cek apakah rujukan ini sudah pernah membuat surat kontrol ulang 
			        var request1 = new RestRequest("/rujukan/bpjs/"+textBoxRujukan.Text+"", Method.GET);
	                var result1 = client.Execute(request1);
	                var content1 = result1.Content;
	                //parsing json dengan Newtonsoft.Json.Net
	                var balasan1 = JsonConvert.DeserializeObject<model.getRujukanClass>(content1);
	                
	                if(balasan1.metaData.code=="201")
	                {
	                	MessageBox.Show(balasan1.metaData.message, "Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
	                }else{
	                	
	                	if(noKartu_pasien == noKartu){
	                		//tampilkan peserta PRB
	                		getCariKartuRujukan();
	                		
				        	//cek sudah punya sep atau belum
					        if (no_SJP == null )
					        {
					        	buatSEP();
					        }
					        else if(no_SJP=="-"){
					        	buatSEP();
					        }					        
					        else
					        {
					        	cariSEP();
						    }
				        }else{
				        	MessageBox.Show("Maaf nomor kartu rujukan tidak sama dengan nomor kartu pasien", "Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
				        }
	                }
                }else {
            		var requestrs = new RestRequest("/rujukan/rs/"+textBoxRujukan.Text+"", Method.GET);
	                var resultrs = client.Execute(requestrs);
	                var contentrs = resultrs.Content;
	                var balasanrs = JsonConvert.DeserializeObject<model.getRujukanClass>(contentrs);
	                if(balasanrs.metaData.code=="200"){
	                	faskes1 = balasanrs.response.rujukan.provPerujuk.nama;
	                	ppkRujukan = balasanrs.response.rujukan.provPerujuk.kode;
	                	jnsRawat = balasanrs.response.rujukan.pelayanan.nama;
	                	noKartu = balasanrs.response.rujukan.peserta.noKartu;
	                	kodeDiagnosa = balasanrs.response.rujukan.diagnosa.kode;
			        	tglKunjungan = balasanrs.response.rujukan.tglKunjungan;
			        	
	                	if(noKartu_pasien == noKartu){
			        		//ambil nama faskes pertama dan peserta PRB
				            getSepKartuPeserta();
				            
	                		if (no_SJP == null){
					        	buatSEP();
	                		}
	                		else if(no_SJP == "-"){
	                			buatSEP();
	                		}
	                		else {
					        	cariSEP();
					        }
	                	} else {
	                		MessageBox.Show("Maaf nomor kartu rujukan tidak sama dengan nomor kartu pasien", "Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
	                	}
	                }else{
	                	MessageBox.Show(balasan.metaData.message,"Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
	                }
                	
                }
				
            }
            catch (Exception ex)
            {
            	MessageBox.Show(ex.Message);
            }
		}
		
		//Method untuk mendapatkan data rujukan internal BPJS
		private void cariRujukanInternal()
		{
			try
            {
				var txtNoRujukan= textBoxRujukan.Text;
                var request = new RestRequest("/rujukaninternal", Method.POST);
                //string json= "{\"no_rujukan\":\""+txtNoRujukan+"\","+"\"tgl_reg\":\""+tglKunjungan+"\"}";
				//request.AddParameter("application/json", json, ParameterType.RequestBody);
                request.AddParameter("no_rujukan", txtNoRujukan);
                request.AddParameter("tgl_reg", tgl_reg);  
				var result = client.Execute(request);				
                var content = result.Content;
                //parsing json dengan Newtonsoft.Json.Net
                var balasan = JsonConvert.DeserializeObject<model.rujukanInternalClass>(content);  
                if (balasan.metaData.code=="200")
                {	                        	
                	faskes1 = balasan.response.rujukan.provPerujuk.nama;
			        jenisfaskes = balasan.response.rujukan.provPerujuk.jenis_faskes;
			        jnsRawat = balasan.response.rujukan.pelayanan.nama;
			        kodeDiagnosa = balasan.response.rujukan.diagnosa.kode;
			        tglKunjungan = balasan.response.rujukan.tglKunjungan;
			        ppkRujukan = balasan.response.rujukan.provPerujuk.kode;
			        kodepoli = balasan.response.rujukan.poliRujukan.kode;
			        noKartu = balasan.response.rujukan.peserta.noKartu;
			        norujukanbpjs = balasan.response.rujukan.noRujukanBpjs;
			        kodeDpjp = balasan.response.rujukan.kodeDPJP;
			        try
			        {
			        	//cek no rujukan bpjs valid atau tidak
		        		var request1 = new RestRequest("/rujukan/"+norujukanbpjs+"", Method.GET);
		                var result1 = client.Execute(request1);
		                var content1 = result1.Content;
		                var balasan1 = JsonConvert.DeserializeObject<model.getRujukanClass>(content1);
		                if (balasan1.metaData.code=="200"){
		                	if(noKartu_pasien == noKartu){	
								// tampilkan peserta PRB
								getCariKartuRujukan();
								
		                		if (no_SJP == null){
						        	buatSEPInternal();
		                		}
		                		else if(no_SJP == "-"){
		                			buatSEPInternal();
		                		}
		                		else {
						        	cariSEPInternal();
//		                			MessageBox.Show("cari sep internal");
						        }
		                	} else {
		                		MessageBox.Show("Maaf nomor kartu rujukan tidak sama dengan nomor kartu pasien", "Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
		                	}
		                	
		                } else {
		                	var requestrs = new RestRequest("/rujukan/rs/"+norujukanbpjs+"", Method.GET);
			                var resultrs = client.Execute(requestrs);
			                var contentrs = resultrs.Content;
			                var balasanrs = JsonConvert.DeserializeObject<model.getRujukanClass>(contentrs);
			                if(balasanrs.metaData.code=="200"){
			                	if(noKartu_pasien == noKartu){
			                		//ambil nama faskes pertama
				                	getSepKartuPeserta();
				                	
			                		if (no_SJP == null){
							        	buatSEPInternal();
			                		}
			                		else if(no_SJP == "-"){
			                			buatSEPInternal();
			                		}
			                		else {
							        	cariSEPInternal();
							        }
			                	} else {
			                		MessageBox.Show("Maaf nomor kartu rujukan tidak sama dengan nomor kartu pasien", "Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
			                	}
			                }else{
			                	//cari berdasarkan sep
			                	var requestsep = new RestRequest("/sep/"+norujukanbpjs+"", Method.GET);
				                var resultsep = client.Execute(requestsep);
				                var contentsep = resultsep.Content;
				                var balasansep = JsonConvert.DeserializeObject<model.cariSEPclass>(contentsep);
				                if(balasansep.metaData.code=="200"){
				                	jnsRawat = "Rawat Jalan";
				                	var noKartuSep = balasansep.response.peserta.noKartu;				                	
				                	if(noKartu_pasien == noKartuSep){
				                		//ambil nama faskes pertama
				                		getSepKartuPeserta();
	
				                		if (no_SJP == null){
								        	buatSEPInternal();
				                		}
				                		else if(no_SJP == "-"){
				                			buatSEPInternal();
				                		}
				                		else {
								        	cariSEPInternal();
								        }
				                	} else {
				                		MessageBox.Show("Maaf nomor kartu rujukan tidak sama dengan nomor kartu pasien", "Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
				                	}
				                }else{
				                	MessageBox.Show("Nomor SEP Rawat Inap Sebelumnya Tidak Ditemukan, Silahkan Hubungi Petugas Untuk Pembuatan SEP", "Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
				                }			                	
			                }
		                	
		                }
			        }
			        catch (Exception ex)
		            {
		            	MessageBox.Show(ex.Message);
		            }	
                }
                else
                {
                	MessageBox.Show(balasan.metaData.message, "Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					//MessageBox.Show(txtNoRujukan);
                }
				
            }
            catch (Exception ex)
            {
            	MessageBox.Show(ex.Message);
            }
		}
		
		private void getSepKartuPeserta()
		{
			string tglnow = DateTime.Now.ToString("yyyy-MM-dd");
        	var requestkartu = new RestRequest("/peserta/nokartu/"+noKartu+"/tglsep/"+tglnow+"", Method.GET);
            var resultkartu = client.Execute(requestkartu);
            var contentkartu = resultkartu.Content;
            var balasankartu = JsonConvert.DeserializeObject<model.getPesertaCariKartuClass>(contentkartu);
            faskes1 = balasankartu.response.peserta.provUmum.nmProvider;   
            pesertaPrb = "*Peserta "+balasankartu.response.peserta.informasi.prolanisPRB;
		}		
		
		private void getCariKartuRujukan()
		{
			string tglnow = DateTime.Now.ToString("yyyy-MM-dd");
        	var requestkartu = new RestRequest("/peserta/nokartu/"+noKartu+"/tglsep/"+tglnow+"", Method.GET);
            var resultkartu = client.Execute(requestkartu);
            var contentkartu = resultkartu.Content;
            var balasankartu = JsonConvert.DeserializeObject<model.getPesertaCariKartuClass>(contentkartu);              
            pesertaPrb = "*Peserta "+balasankartu.response.peserta.informasi.prolanisPRB;
		}		
		//Method untuk insert SEP ke BPJS
		private void buatSEP()
		{

			try
                {
					string tglnow = DateTime.Now.ToString("yyyy-MM-dd");
					var request = new RestRequest("/sep/insert", Method.POST);
					string json ="{" +
						"\"request\": {" +
								"\"t_sep\": { "+
									"\"noKartu\": \""+noKartu+"\","+ 
			           				"\"tglSep\": \""+tglnow+"\","+
									"\"ppkPelayanan\": \"1105R001\","+
			            			"\"jnsPelayanan\": \"2\", "+
			            			"\"klsRawat\": \"3\","+
			            			"\"noMR\": \""+noRM+"\","+
						            "\"catatan\": \"-\","+ 
						            "\"diagAwal\": \""+kodeDiagnosa+"\","+ 
						            "\"noTelp\": \""+noTelp+"\","+
						            "\"user\": \"admin\", "+
						            "\"rujukan\": { "+
						                "\"asalRujukan\": \"1\","+
						                "\"tglRujukan\": \""+tglKunjungan+"\","+ 
						                "\"noRujukan\": \""+textBoxRujukan.Text+"\","+
						                "\"ppkRujukan\": \""+ppkRujukan+"\" "+
						            "}, "+
						            "\"poli\": { "+
						                "\"tujuan\": \""+kodepoli+"\","+
						                "\"eksekutif\": \"0\" "+
						            "},"+
						            "\"katarak\": {"+
						                "\"katarak\": \"0\""+ 
						            "},"+
						            "\"skdp\": {"+    
						                "\"noSurat\": \"0\","+
						                "\"kodeDPJP\": \"0\""+
						            "},"+
						            "\"cob\": { \"cob\": \"0\" },"+
						            "\"jaminan\": { "+
						                "\"lakaLantas\": \"0\", "+
						                "\"penjamin\": {"+
						                    "\"penjamin\": \"0\", "+
						                    "\"tglKejadian\": \"0000-00-00\","+ 
						                    "\"keterangan\": \"0\", "+
						                    "\"suplesi\": {"+
						                         "\"suplesi\": \"0\", "+
						                          "\"noSepSuplesi\": \"0\","+ 
						                          "\"lokasiLaka\": {"+
						                              "\"kdPropinsi\": \"00\","+ 
						                              "\"kdKabupaten\": \"0000\","+ 
						                              "\"kdKecamatan\": \"0000\", "+
						                          "}, "+
						                    "}, "+
						                "}, "+
						            "}"+
						        "}"+
						    "}"+
						"}";
					request.AddParameter("application/json", json, ParameterType.RequestBody);
					var result = client.Execute(request);
					
	                var content = result.Content;
	                //parsing json dengan Newtonsoft.Json.Net
	                var balasan = JsonConvert.DeserializeObject<model.buatSEPClass>(content);
	                
	                if (balasan.metaData.code=="201")
	                {
	                	MessageBox.Show("Error saat membuat SEP. Keterangan : " + balasan.metaData.message, "Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
	                	//MessageBox.Show(json,"INI BUAT SEP DARI RUJUKAN LUAR");
	                }
	                else if (balasan.metaData.code == "200")
	                {
	                    noSEP = balasan.response.sep.noSep;
	                    tglSEPstring = balasan.response.sep.tglSep.ToString("dd-MM-yyyy");
	                    noKartu = balasan.response.sep.peserta.noKartu;
	                    poli = balasan.response.sep.poli;
	                    diagnosaAwal = balasan.response.sep.diagnosa;
	                    jnsKelamin = balasan.response.sep.peserta.kelamin;
	                    tglLahir = balasan.response.sep.peserta.tglLahir.ToString("dd-MM-yyyy");
	                    peserta = balasan.response.sep.peserta.jnsPeserta;
	                    klsTanggungan = balasan.response.sep.peserta.hakKelas;
	                    //catatan -> sementara tembak dulu gan
	                    catatan = balasan.response.sep.catatan;
	                    updateRegister();
	                    updateAsalRujukan();
	                    cetakSEP();
	                }
	                else 
	                {
	                	MessageBox.Show("Error saat membuat SEP. Keterangan: " + balasan.metaData.message,  "Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
	                }

				}
			
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		
		//Method untuk insert SEP dari rujukan internal ke BPJS
		private void buatSEPInternal()
		{
			try
                {					
					var norujukan=textBoxRujukan.Text;					
					var no_skdp = norujukan.Substring(0,6);
					string tglnow = DateTime.Now.ToString("yyyy-MM-dd");
					var request = new RestRequest("/sep/insert", Method.POST);
					string json = "{ " +
						"\"request\": { " +
							"\"t_sep\": { " +
									"\"noKartu\": \""+noKartu+"\", " +
									"\"tglSep\": \""+tglnow+"\", " +
									"\"ppkPelayanan\": \"1105R001\"," +
									"\"jnsPelayanan\": \"2\", " +
									"\"klsRawat\": \"3\", " +
									"\"noMR\": \""+noRM+"\", " +
									"\"catatan\": \"SKDP TERLAMPIR DARI RSUD KRATON\", " +
									"\"diagAwal\": \""+kodeDiagnosa+"\", " +
									"\"noTelp\": \""+noTelp+"\"," +
									"\"user\": \"Pasien\", " +
									"\"rujukan\": { " +
										"\"asalRujukan\": \""+jenisfaskes+"\"," +
										"\"tglRujukan\": \""+tglKunjungan+"\", " +
										"\"noRujukan\": \""+norujukanbpjs+"\"," +
										"\"ppkRujukan\": \""+ppkRujukan+"\" " +
									"}," +						
									"\"poli\": { " +
										"\"tujuan\": \""+kodepoli+"\"," +
										"\"eksekutif\": \"0\" " +
									"}," +
									 "\"katarak\": {"+
						                "\"katarak\": \"0\""+ 
						            "},"+
						            "\"skdp\": {"+    
						                "\"noSurat\": \""+no_skdp+"\","+
						                "\"kodeDPJP\": \""+kodeDpjp+"\""+
						            "},"+
									"\"cob\": {" +
										"\"cob\": \"0\" " +
									"}," +
									 "\"jaminan\": { "+
					                "\"lakaLantas\": \"0\", "+
					                "\"penjamin\": {"+
					                    "\"penjamin\": \"0\", "+
					                    "\"tglKejadian\": \"0000-00-00\","+ 
					                    "\"keterangan\": \"0\", "+
					                    "\"suplesi\": {"+
					                         "\"suplesi\": \"0\", "+
					                          "\"noSepSuplesi\": \"0\","+ 
					                          "\"lokasiLaka\": {"+
					                              "\"kdPropinsi\": \"00\","+ 
					                              "\"kdKabupaten\": \"0000\","+ 
					                              "\"kdKecamatan\": \"0000\", "+
					                          "}, "+
					                    "}, "+
					                "}, "+
								"}" +
							"}" +
						"}" +
					"}";
					request.AddParameter("application/json", json, ParameterType.RequestBody);
					var result = client.Execute(request);
					
	                var content = result.Content;
	                //parsing json dengan Newtonsoft.Json.Net
	                var balasan = JsonConvert.DeserializeObject<model.buatSEPClass>(content);
	                
	               	//MessageBox.Show(json,"INI BUAT SEP DARI RUJUKAN INTERNAL");
	                if (balasan.metaData.code=="201")
	                {
	                	MessageBox.Show("Error saat membuat SEP. Keterangan: " + balasan.metaData.message, "Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                		//MessageBox.Show(json,"INI BUAT SEP DARI RUJUKAN INTERNAL");
	                }
	                else if (balasan.metaData.code == "200")
	                {
	                    noSEP = balasan.response.sep.noSep;
	                    tglSEPstring = balasan.response.sep.tglSep.ToString("dd-MM-yyyy");
	                    noKartu = balasan.response.sep.peserta.noKartu;
	                    poli = balasan.response.sep.poli;
	                    diagnosaAwal = balasan.response.sep.diagnosa;
	                    jnsKelamin = balasan.response.sep.peserta.kelamin;
	                    tglLahir = balasan.response.sep.peserta.tglLahir.ToString("dd-MM-yyyy");
	                    peserta = balasan.response.sep.peserta.jnsPeserta;
	                    klsTanggungan = balasan.response.sep.peserta.hakKelas;
	                    //catatan -> sementara tembak dulu gan
	                    catatan = balasan.response.sep.catatan;
	                    updateRegister();
	                    updateAsalRujukan();
	                    cetakSEP();
	                }
	                else 
	                {
	                	MessageBox.Show("Error saat membuat SEP. Keterangan: " + balasan.metaData.message,  "Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
	                }

				}
			
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		
		private void updateRegister()
		{
			var request = new RestRequest("/updateregister", Method.POST);
			string json = "{ \"no_RM\":\""+noRM+"\",\"no_reg\":\""+noRegistrasi+"\",\"no_sep\":\""+noSEP+"\"}";
			request.AddParameter("application/json", json, ParameterType.RequestBody);
			var result = client.Execute(request);
			
		}
		
		private void updateAsalRujukan()
		{
			var request = new RestRequest("/sep/insert/rujukan", Method.POST);
			request.AddParameter("no_reg", noRegistrasi);
            request.AddParameter("no_rujukan", norujukanbpjs);  
            request.AddParameter("provPerujuk", ppkRujukan);  
            request.AddParameter("kd_diagnosa", kodeDiagnosa);  
            request.AddParameter("diagnosa", diagnosaAwal);  
			var result = client.Execute(request);
			
		}
		
		//Cari SEP jika no_SJP sudah terisi
		private void cariSEP()
		{
			try
                {
					var request = new RestRequest("/sep/"+no_SJP+"", Method.GET);
					var result = client.Execute(request);
	                var content = result.Content;
	                //parsing json dengan Newtonsoft.Json.Net
	                var balasan = JsonConvert.DeserializeObject<model.cariSEPclass>(content);
	               
	                if (balasan.metaData.code=="201")
	                {
	                	buatSEP();
	                }
	                else if (balasan.metaData.code == "200")
	                {
	                	noSEP = balasan.response.noSep;
	                	tglSEPstring = balasan.response.tglSep.ToString("dd-MM-yyyy");
	                    noKartu = balasan.response.peserta.noKartu;
	                    poli = balasan.response.poli;
	                    diagnosaAwal = balasan.response.diagnosa;
	                    jnsKelamin = balasan.response.peserta.kelamin;
	                    tglLahir = balasan.response.peserta.tglLahir.ToString("dd-MM-yyyy");
	                    peserta = balasan.response.peserta.jnsPeserta;
	                    klsTanggungan = balasan.response.peserta.hakKelas;
	                    //catatan -> sementara tembak dulu gan
	                    catatan = balasan.response.catatan;
	                    cetakSEP();
	                }
	                else 
	                {
	                	MessageBox.Show(balasan.metaData.message,  "Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
	                }

				}
			
			catch (Exception ex)
			{
				MessageBox.Show("Error saat mencari SEP. Keterangan: " + ex.Message, "Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
		}
		
		//Cari SEP jika no_SJP sudah terisi dari rujukan internal
		private void cariSEPInternal()
		{
			try
                {
					var request = new RestRequest("/sep/"+no_SJP+"", Method.GET);
					var result = client.Execute(request);
	                var content = result.Content;
	                //parsing json dengan Newtonsoft.Json.Net
	                var balasan = JsonConvert.DeserializeObject<model.cariSEPclass>(content);
	               
	                if (balasan.metaData.code=="201")
	                {
	                	buatSEPInternal();
	                }
	                else if (balasan.metaData.code == "200")
	                {
	                	noSEP = balasan.response.noSep;
	                	tglSEPstring = balasan.response.tglSep.ToString("dd-MM-yyyy");
	                    noKartu = balasan.response.peserta.noKartu;
	                    poli = balasan.response.poli;
	                    diagnosaAwal = balasan.response.diagnosa;
	                    jnsKelamin = balasan.response.peserta.kelamin;
	                    tglLahir = balasan.response.peserta.tglLahir.ToString("dd-MM-yyyy");
	                    peserta = balasan.response.peserta.jnsPeserta;
	                    klsTanggungan = balasan.response.peserta.hakKelas;
	                    //catatan -> sementara tembak dulu gan
	                    catatan = balasan.response.catatan;
	                    cetakSEP();	                    
	                }
	                else 
	                {
	                	MessageBox.Show(balasan.metaData.message,  "Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
	                }

				}
			
			catch (Exception ex)
			{
				MessageBox.Show("Error saat mencari SEP. Keterangan: " + ex.Message, "Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
		}
		//Method untuk mencetak SEP
		private void cetakSEP()
		{			
			// If using Professional version, put your serial key below.
	        SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
	
	        ExcelFile ef = ExcelFile.Load(@".\Xls\TemplateSEP.xlsx");
	        ExcelWorksheet ws = ef.Worksheets[0];
	        string nomer = antrian;
	        string[] noAntrian = nomer.Split('.');
	        // Change the value of the cells
//	        ws.Cells["A25"].Value = pesertaPrb;
	        ws.Cells["C3"].Value = noSEP;
	        ws.Cells["J2"].Value = ": "+tglSEPstring;
//	        ws.Cells["C6"].Value = noRM;
	        ws.Cells["C7"].Value = noRegistrasi;
	        ws.Cells["C4"].Value = noKartu+"  (RM."+noRM+")";
	        ws.Cells["C5"].Value = poli;
	        ws.Cells["C6"].Value = faskes1;
	        ws.Cells["A1"].Value = "Antrian : "+noAntrian[0];
	        ws.Cells["C8"].Value = diagnosaAwal;
			ws.Cells["H3"].Value = nama;
			ws.Cells["H4"].Value = tglLahir;
			ws.Cells["H5"].Value = alamat;
			ws.Cells["H7"].Value = peserta;
			ws.Cells["J1"].Value = ": "+jnsRawat;
//			ws.Cells["H11"].Value = klsTanggungan;
			ws.Cells["H8"].Value = "Kelas -";
//			ws.Cells["H7"].Value = catatan;
			ws.Cells["I4"].Value = "Kelamin : "+jnsKelamin;
//			ws.Cells["I23"].Value = "Dicetak Oleh : Pasien";
			// Print options:
			var pengaturanPrinter = ws.PrintOptions;
	        pengaturanPrinter.Portrait = false;
	        pengaturanPrinter.NumberOfCopies = 1;	        
	        
	        var formAlert = new FormAlert();
	        //cetak ke printer tertentu
	        if (namaprinter == "Default Printer")
	        {
	        	ef.Print();	
	        	EnableTab(tabControl1.TabPages[tabControl1.SelectedIndex = 0], true);
	            EnableTab(tabControl1.TabPages[tabControl1.SelectedIndex = 1], false);
	            tabControl1.SelectedIndex = 0;
	            //kosongkan isian
	            textBoxRM.Text = "";
	            textBoxRujukan.Text = "";
	            formAlert.ShowDialog();
	        	
	        }
	        else if (namaprinter == "Print via Excel")
	        {
	        	ef.Save("SEP.xlsx");
				System.Diagnostics.Process.Start("SEP.xlsx");
				EnableTab(tabControl1.TabPages[tabControl1.SelectedIndex = 0], true);
	            EnableTab(tabControl1.TabPages[tabControl1.SelectedIndex = 1], false);
	            tabControl1.SelectedIndex = 0;
	            //kosongkan isian
	            textBoxRM.Text = "";
	            textBoxRujukan.Text = "";
	            formAlert.ShowDialog();
	        }
	        else 
	        {
	        	ef.Print(namaprinter);	        	
	        	EnableTab(tabControl1.TabPages[tabControl1.SelectedIndex = 0], true);
	            EnableTab(tabControl1.TabPages[tabControl1.SelectedIndex = 1], false);
	            tabControl1.SelectedIndex = 0;
	            //kosongkan isian
	            textBoxRM.Text = "";
	            textBoxRujukan.Text = "";
	            formAlert.ShowDialog();
	        }
			
		}
		

		void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			var frm = new FormSetting();
			frm.Show();
		}		
		
		
		void BtnbatalClick(object sender, EventArgs e)
		{
			//set tab
			EnableTab(tabControl1.TabPages[tabControl1.SelectedIndex = 0], true);
            EnableTab(tabControl1.TabPages[tabControl1.SelectedIndex = 1], false);
            tabControl1.SelectedIndex = 0;
            //kosongkan isian
            textBoxRM.Text = "";
            textBoxRujukan.Text = "";
		}
		
		void MainFormKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
	        {
				//set tab
				EnableTab(tabControl1.TabPages[tabControl1.SelectedIndex = 0], true);
	            EnableTab(tabControl1.TabPages[tabControl1.SelectedIndex = 1], false);
	            tabControl1.SelectedIndex = 0;
	            //kosongkan isian
	            textBoxRM.Text = "";
	            textBoxRujukan.Text = "";
	        }
			
		}
		void ButtonFaskesClick(object sender, EventArgs e)
		{	
			var formRujukan = new RujukanForm();			
			RujukanForm.noKartu_bpjs = noKartu_pasien;
			RujukanForm.kode_polidpjp = kodepoli_dpjp;
			formRujukan.ShowDialog();
			textBoxRujukan.Text = RujukanForm.textNoRujukan;
		}
		
		void ButtonRSClick(object sender, EventArgs e)
		{
			var formRujukanRS = new RujukanRSForm();
			RujukanRSForm.noKartu_bpjs = noKartu_pasien;
			RujukanRSForm.kode_polidpjp = kodepoli_dpjp;
			formRujukanRS.ShowDialog();
			textBoxRujukan.Text = RujukanRSForm.textNoRujukan;
		}		
		
	}
}
