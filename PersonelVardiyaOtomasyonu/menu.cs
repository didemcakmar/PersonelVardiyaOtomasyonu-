using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelVardiyaOtomasyonu
{
	public partial class menu : Form
	{
		public menu()
		{
			InitializeComponent();
		}

		private void Personeller_Click(object sender, EventArgs e)
		{
			personel form = new personel();
			form.Show();
		}


		private void button3_Click(object sender, EventArgs e)
		{
			vardiya form = new vardiya();
			form.Show();
		}

		private void yönetici_Click(object sender, EventArgs e)
		{
			yonetici form = new yonetici();
			form.Show();
		}

		private void izin_Click(object sender, EventArgs e)
		{
			izin form = new izin();
			form.Show();
		}
	}
}
