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

namespace Videoteka
{
    public partial class Login : Form
    {
        public Login()
        {            
            InitializeComponent();
            labelIme.BackColor = System.Drawing.Color.Transparent;
            labelLozinka.BackColor = System.Drawing.Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Videoteka;Integrated Security=True");
            connection.Open();

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Osoba INNER JOIN Administrator ON Osoba.OsobaID = Administrator.OsobaID WHERE Administrator.Username = @user AND Administrator.Passwors = @pass", connection);

            cmd.Parameters.AddWithValue("@user", textBoxUsername.Text);
            cmd.Parameters.AddWithValue("@pass", textBoxPassword.Text);

            adapter.SelectCommand = cmd;
            adapter.Fill(table);

            connection.Close();

            if (table.Rows.Count > 0)
            {
                Menu menu = new Menu();
                this.Hide();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Unijeli ste pogrešne podatke !");
            }

        }
    }
}
