using System;
using System.Data;
using System.Windows.Forms;

namespace PersonelVardiyaOtomasyonu
{
	public partial class personel_profil : Form
	{
		private DataTable vardiyaDataTable;

		public personel_profil()
		{
			InitializeComponent();
			vardiyaDataTable = new DataTable();
			InitializeDataGridView();
		}

		private void InitializeDataGridView()
		{
			
			dataGridViewVardiya.DataSource = vardiyaDataTable;
			dataGridViewVardiya.AllowUserToAddRows = false; 

			vardiyaDataTable.Columns.Add("Vardiya ID");
			vardiyaDataTable.Columns.Add("Sicil No");
			vardiyaDataTable.Columns.Add("Başlangıç Saati");
			vardiyaDataTable.Columns.Add("Bitiş Saati");
			vardiyaDataTable.Columns.Add("Gün");
			vardiyaDataTable.Columns.Add("Konum");
		}

		private void personel_profil_Load(object sender, EventArgs e)
		{
			
			LoadPersonelData();

		
			LoadVardiyaData();
		}

		private void LoadPersonelData()
		{
		
			labelAd.Text = "Ad: " + LoginEventsPersonel.ad;
			labelSoyad.Text = "Soyad: " + LoginEventsPersonel.soyad;
			labelkimlikno.Text = "Kimlik No: " + LoginEventsPersonel.kimlik_no;
			labelKadrotipi.Text = "Kadro: " + LoginEventsPersonel.kadro_tipi;
			labelGorevUnvani.Text = "Ünvan: " + LoginEventsPersonel.gorev_unvani;
			labelSicilNo.Text = "Sicil No: " + LoginEventsPersonel.sicil_no;
			labeltelefon.Text = "Telefon: " + LoginEventsPersonel.telefon;
			labelemail.Text = "Email: " + LoginEventsPersonel.email;
		}

		private void LoadVardiyaData()
		{
			
			string[] vardiyaBilgileri = { Vardiya.vard_id, Vardiya.pers_sicil, Vardiya.vard_bas_saat, Vardiya.vard_bit_saat, Vardiya.vard_gun, Vardiya.vard_konum };
			vardiyaDataTable.Rows.Add(vardiyaBilgileri);
		}
	}
}
