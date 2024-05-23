using System.Data.SQLite;
using System.Data;

namespace AS2324.DiegoSucci._3g.verifica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "";
            string strConnessione = "";

            strConnessione = "Data Source=" + @"C:\Users\PC\Desktop\AS2324.DiegoSucci.3g.verifica\DB" + ";Version=3;";

            DataTable dtDati = new DataTable();

            query = "SELECT * FROM Gare";

            SQLiteDataAdapter da = new SQLiteDataAdapter(query, strConnessione);

            try
            {
                da.Fill(dtDati);

                dgvDati.DataSource = dtDati;
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "";
            string strConnessione = "";

            strConnessione = "Data Source=" + @"C:\Users\PC\Desktop\AS2324.DiegoSucci.3g.verifica\DB" + ";Version=3;";

            DataTable dtDati = new DataTable();

            query = "SELECT * FROM Squadre";

            SQLiteDataAdapter da = new SQLiteDataAdapter(query, strConnessione);

            try
            {
                da.Fill(dtDati);

                dgvDati.DataSource = dtDati;
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }
    }
}
