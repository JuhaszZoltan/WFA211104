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
    public partial class FrmAdatlap : Form
    {
        string connectionString;
        public FrmAdatlap(string connectionString)
        {
            this.connectionString = connectionString;
            InitializeComponent();
        }

        private void FrmAdatlap_Load(object sender, EventArgs e)
        {
            using (var c = new SqlConnection(connectionString))
            {
                c.Open();
                var r = new SqlCommand(
                    "SELECT Nev FROM Fajta;", c)
                    .ExecuteReader();
                while (r.Read()) cbFajtak.Items.Add(r[0]);
                r.Close();
                r = new SqlCommand(
                    "SELECT Nev FROM Tenyeszto;", c)
                    .ExecuteReader();
                while (r.Read()) cbTulajok.Items.Add(r[0]);
            }
            cbFajtak.SelectedIndex = 0;
            cbTulajok.SelectedIndex = 0;
        }

        private void CbFajtak_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbFajtak.Text)
            {
                case "ninja": 
                    pbUni.Image = Properties.Resources.ninja;
                    return;
                case "robot":
                    pbUni.Image = Properties.Resources.robot;
                    return;
                case "dapper":
                    pbUni.Image = Properties.Resources.dapper;
                    return;
                case "nyan":
                    pbUni.Image = Properties.Resources.nyan;
                    return;
                case "zombie":
                    pbUni.Image = Properties.Resources.zombie;
                    return;
                case "hipster":
                    pbUni.Image = Properties.Resources.hipster;
                    return;
            }
        }

        private void BtmInsert_Click(object sender, EventArgs e)
        {

        }
    }
}
