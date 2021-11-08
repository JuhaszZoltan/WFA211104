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

namespace WFA211104
{
    public partial class FrmMain : Form
    {

        string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;" +
            "Initial Catalog=UniMenes;";
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            DGVFeltolt();
        }

        private void DGVFeltolt()
        {
            dgvMain.Rows.Clear();
            using (var c = new SqlConnection(connectionString))
            {
                c.Open();

                var r = new SqlCommand(
                    "SELECT Unikornis.Id, Fajta.Nev, Tenyeszto.Nev, Varos, Suly, Nem " +
                    "FROM Fajta " +
                    "INNER JOIN Unikornis ON Fajta.Id = FajtaId " +
                    "INNER JOIN Tenyeszto ON TulajdonosId = Tenyeszto.Id;", c)
                    .ExecuteReader();

                while (r.Read())
                {
                    dgvMain.Rows.Add(
                        r[0], r[1], r[2], r[3], r[4] + " Kg",
                        r.GetBoolean(5) ? "csődör" : "kanca");
                }
            }
        }

        private void TsmiBejelentes_Click(object sender, EventArgs e)
        {
            var frm = new FrmAdatlap(connectionString);
            frm.ShowDialog();
            DGVFeltolt();
        }

        private void DgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            string fajta = dgvMain[1, e.RowIndex].Value.ToString();
            string varos = dgvMain[3, e.RowIndex].Value.ToString();
            string suly =  dgvMain[4, e.RowIndex].Value.ToString();
            string nem =   dgvMain[5, e.RowIndex].Value.ToString();

            var frm = new FrmParkereso(connectionString, varos, fajta, suly, nem);
            frm.ShowDialog();
        }
    }
}
