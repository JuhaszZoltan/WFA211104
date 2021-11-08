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
    public partial class FrmParkereso : Form
    {
        public string ConnectionString { get; private set; }
        public string KivVaros { get; private set; }
        public string KivFajta { get; private set; }
        public string KivSuly { get; private set; }
        public string KivNem { get; private set; }

        public FrmParkereso(string cs, string varos, string fajta, string suly, string nem)
        {
            ConnectionString = cs;
            KivVaros = varos;
            KivFajta = fajta;
            KivSuly = suly;
            KivNem = nem;
            InitializeComponent();
        }

        private void FrmParkereso_Load(object sender, EventArgs e)
        {
            SetUI();

            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                var r = new SqlCommand(
                    "SELECT Unikornis.Id, Fajta.Nev, Tenyeszto.Nev, Suly " +
                    "FROM Fajta " +
                    "INNER JOIN Unikornis ON Fajta.Id = FajtaId " +
                    "INNER JOIN Tenyeszto ON TulajdonosId = Tenyeszto.Id " +
                    $"WHERE Nem = {(KivNem == "csődör" ? 0 : 1)} " +
                    $"AND Varos LIKE '{KivVaros}';",
                    conn).ExecuteReader();

                while (r.Read()) dgvParok.Rows.Add(r[0], r[1], r[2], r[3] + " Kg");
            }


        }

        private void SetUI()
        {
            this.BackColor = KivNem == "csődör" ?
                Color.LightBlue :
                Color.LightPink;

            tbVaros.Text = KivVaros;
            tbFajta.Text = KivFajta;
            tbSuly.Text = KivSuly;
        }
    }
}
