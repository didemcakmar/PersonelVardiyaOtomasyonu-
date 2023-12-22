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

		private void personeller_Click(object sender, EventArgs e)
		{
			personel mainForm = new personel();
			mainForm.Show();

		}

		private void vardiyalar_Click(object sender, EventArgs e)
		{
			vardiya mainForm = new vardiya();
			mainForm.Show();

		}

		private void izinler_Click(object sender, EventArgs e)
		{
			izinler mainForm = new izinler();
			mainForm.Show();

		}

		private void yöneticiler_Click(object sender, EventArgs e)
		{
			yonetici mainForm = new yonetici();
			mainForm.Show();

		}
	}
}
