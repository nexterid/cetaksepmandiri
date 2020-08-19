/*
 * Created by SharpDevelop.
 * User: Nexter3
 * Date: 23/07/2018
 * Time: 14:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CetakSEP.model
{
	public class Hasil
		{
		    public string no_reg { get; set; }
		    public DateTime tgl_reg { get; set; }
		    public string no_SJP { get; set; }
		    public string no_RM { get; set; }
		    public string no_telp { get; set; }
		    public string nama_pasien { get; set; }
		    public string alamat { get; set; }
		    public string nama_sub_unit { get; set; }
		    public string nama_pegawai { get; set; }
		    public string antrian { get; set; }
		    public string no_kartu { get; set; }
		    public string alamat_lengkap { get; set; }
			public string kd_poli_dpjp { get; set; }				    
		}
		
		public class getDataReg
		{
		    public bool ok { get; set; }
		    public Hasil hasil { get; set; }
		    public string pesan { get; set; }
		}
		
		//Class untuk buat Rujukan
		public class MetaData
		{
		    public string code { get; set; }
		    public string message { get; set; }
		}
		
		public class Diagnosa
		{
		    public string kode { get; set; }
		    public string nama { get; set; }
		}
		
		public class Pelayanan
		{
		    public string kode { get; set; }
		    public string nama { get; set; }
		}
		
		public class Peserta
		{
		    public string noKartu { get; set; }
		}
				
		public class PoliRujukan
		{
		    public string kode { get; set; }
		    public string nama { get; set; }
		}
		
		public class ProvPerujuk
		{
		    public string kode { get; set; }
		    public string nama { get; set; }
		    public string jenis_faskes { get; set; }
		}
		
		public class Rujukan
		{
		    public Diagnosa diagnosa { get; set; }
		    public Pelayanan pelayanan { get; set; }
		    public string noKunjungan { get; set; }
		    public PesertaRujukan peserta { get; set; }
		    public PoliRujukan poliRujukan { get; set; }
		    public ProvPerujuk provPerujuk { get; set; }
		    public string tglKunjungan { get; set; }
		    public string noRujukanBpjs { get; set; }
		    public string kodeDPJP { get; set; }
		}
				
		public class Response
		{
		    public Rujukan rujukan { get; set; }
		}
					
		public class getRujukanClass
		{
		    public MetaData metaData { get; set; }
		    public Response response { get; set; }
		}			
					
		public class rujukanInternalClass
		{
		    public MetaData metaData { get; set; }
		    public Response response { get; set; }
		}
		//class untuk buat SEP
		public class MetaDataSEP
		{
		    public string code { get; set; }
		    public string message { get; set; }
		}
		
		public class PesertaSEP
		{
		    public string asuransi { get; set; }
		    public string hakKelas { get; set; }
		    public string jnsPeserta { get; set; }
		    public string kelamin { get; set; }
		    public string nama { get; set; }
		    public string noKartu { get; set; }
		    public string noMr { get; set; }
		    public DateTime tglLahir { get; set; }
		}
		
		public class Sep
		{
		    public string PPKPerujuk { get; set; }
		    public string catatan { get; set; }
		    public string diagnosa { get; set; }
		    public string jnsPelayanan { get; set; }
		    public string kelasRawat { get; set; }
		    public string noSep { get; set; }
		    public string penjamin { get; set; }
		    public PesertaSEP peserta { get; set; }
		    public string poli { get; set; }
		    public string poliEksekutif { get; set; }
		    public DateTime tglSep { get; set; }
		}
		
		public class ResponseSEP
		{
		    public Sep sep { get; set; }
		}			
		
		public class buatSEPClass
		{
		    public MetaDataSEP metaData { get; set; }
		    public ResponseSEP response { get; set; }
		}
		//Class Cari SEP
		public class MetaDataCariSEP
		{
		    public string code { get; set; }
		    public string message { get; set; }
		}
		
		public class PesertaCariSEP
		{
		    public object asuransi { get; set; }
		    public string hakKelas { get; set; }
		    public string jnsPeserta { get; set; }
		    public string kelamin { get; set; }
		    public string nama { get; set; }
		    public string noKartu { get; set; }
		    public string noMr { get; set; }
		    public DateTime tglLahir { get; set; }
		}
		
		public class ResponseCariSEP
		{
		    public string catatan { get; set; }
		    public string diagnosa { get; set; }
		    public string jnsPelayanan { get; set; }
		    public string kelasRawat { get; set; }
		    public string noSep { get; set; }
		    public object penjamin { get; set; }
		    public PesertaCariSEP peserta { get; set; }
		    public string poli { get; set; }
		    public string poliEksekutif { get; set; }
		    public DateTime tglSep { get; set; }
		}
		
		public class cariSEPclass
		{
		    public MetaDataCariSEP metaData { get; set; }
		    public ResponseCariSEP response { get; set; }
		}
		//End of Class
		
		
		//class untuk rujukan lis
		public class Cob
		{
		    public object nmAsuransi { get; set; }
		    public object noAsuransi { get; set; }
		    public object tglTAT { get; set; }
		    public object tglTMT { get; set; }
		}
		
		public class HakKelas
		{
		    public string keterangan { get; set; }
		    public string kode { get; set; }
		}
		
		public class Informasi
		{
		    public string dinsos { get; set; }
		    public string noSKTM { get; set; }
		    public string prolanisPRB { get; set; }
		}
		
		public class JenisPeserta
		{
		    public string keterangan { get; set; }
		    public string kode { get; set; }
		}
		
		public class Mr
		{
		    public string noMR { get; set; }
		    public string noTelepon { get; set; }
		}
		
		public class ProvUmum
		{
		    public string kdProvider { get; set; }
		    public string nmProvider { get; set; }
		}
		
		public class StatusPeserta
		{
		    public string keterangan { get; set; }
		    public string kode { get; set; }
		}
		
		public class Umur
		{
		    public string umurSaatPelayanan { get; set; }
		    public string umurSekarang { get; set; }
		}
		
		public class PesertaList
		{
		    public Cob cob { get; set; }
		    public HakKelas hakKelas { get; set; }
		    public Informasi informasi { get; set; }
		    public JenisPeserta jenisPeserta { get; set; }
		    public Mr mr { get; set; }
		    public string nama { get; set; }
		    public string nik { get; set; }
		    public string noKartu { get; set; }
		    public string pisa { get; set; }
		    public ProvUmum provUmum { get; set; }
		    public string sex { get; set; }
		    public StatusPeserta statusPeserta { get; set; }
		    public string tglCetakKartu { get; set; }
		    public string tglLahir { get; set; }
		    public string tglTAT { get; set; }
		    public string tglTMT { get; set; }
		    public Umur umur { get; set; }
		}
		
		public class Rujukanlist
		{
		    public Diagnosa diagnosa { get; set; }
		    public string keluhan { get; set; }
		    public string noKunjungan { get; set; }
		    public Pelayanan pelayanan { get; set; }
		    public PesertaList peserta { get; set; }
		    public PoliRujukan poliRujukan { get; set; }
		    public ProvPerujuk provPerujuk { get; set; }
		    public string tglKunjungan { get; set; }
		}
		
		public class ResponseList
		{
//		    public string asalFaskes { get; set; }
		    public Rujukanlist[] rujukan { get; set; }
		}
		
		public class getRujukanListClass
		{
		    public MetaData metaData { get; set; }
		    public ResponseList response { get; set; }
		}
		
		public class getPesertaCariKartuClass
		{
		    public MetaData metaData { get; set; }
		    public ResponsePeserta response { get; set; }
		}
		
		public class ResponsePeserta
		{
		    public PesertaCariKartu peserta { get; set; }
		}
		
		public class PesertaCariKartu
		{
		    public Cob cob { get; set; }
		    public HakKelas hakKelas { get; set; }
		    public Informasi informasi { get; set; }
		    public JenisPeserta jenisPeserta { get; set; }
		    public Mr mr { get; set; }
		    public string nama { get; set; }
		    public string nik { get; set; }
		    public string noKartu { get; set; }
		    public string pisa { get; set; }
		    public ProvUmum provUmum { get; set; }
		    public string sex { get; set; }
		    public StatusPeserta statusPeserta { get; set; }
		    public string tglCetakKartu { get; set; }
		    public string tglLahir { get; set; }
		    public string tglTAT { get; set; }
		    public string tglTMT { get; set; }
		    public Umur umur { get; set; }
		}		
		
		public class PesertaRujukan
		{
		    public Cob cob { get; set; }
		    public HakKelas hakKelas { get; set; }
		    public Informasi informasi { get; set; }
		    public JenisPeserta jenisPeserta { get; set; }
		    public Mr mr { get; set; }
		    public string nama { get; set; }
		    public string nik { get; set; }
		    public string noKartu { get; set; }
		    public string pisa { get; set; }
		    public ProvUmum provUmum { get; set; }
		    public string sex { get; set; }
		    public StatusPeserta statusPeserta { get; set; }
		    public string tglCetakKartu { get; set; }
		    public string tglLahir { get; set; }
		    public string tglTAT { get; set; }
		    public string tglTMT { get; set; }
		    public Umur umur { get; set; }
		}		
}
