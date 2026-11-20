using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_8._3
{
    public partial class Form1 : Form
    {
        StudentRepository repository = new StudentRepository();

        public Form1()
        {
            InitializeComponent();

            btnElaveEt.Click += btnElaveEt_Click;
            TelebeleriYukle();
        }

        private void TelebeleriYukle()
        {
            dgvTelebeler.DataSource = null;
            dgvTelebeler.DataSource = repository.GetAll();
        }

        private void btnElaveEt_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text.Trim();
            string soyad = txtSoyad.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (ad == "" || soyad == "")
            {
                MessageBox.Show("Ad ve soyad bos ola bilmez!");
                return;
            }

            if (!int.TryParse(txtYas.Text, out int yas))
            {
                MessageBox.Show("Yasi duzgun daxil edin!");
                return;
            }

            try
            {
                Student student = new Student
                {
                    FirstName = ad,
                    LastName = soyad,
                    Age = yas,
                    Email = email
                };

                repository.Add(student);

                MessageBox.Show("Telebe ugurla elave edildi!");

                TelebeleriYukle();

                txtAd.Clear();
                txtSoyad.Clear();
                txtYas.Clear();
                txtEmail.Clear();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("Bu e-poct artiq movcuddur!");
                }
                else
                {
                    MessageBox.Show("Xeta: " + ex.Message);
                }
            }
        }
    }
}
