using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _41
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.passBox.AutoSize = false;
            this.passBox.Size = new Size(this.passBox.Size.Width, 32);
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logbutton_Click(object sender, EventArgs e)
        {
            int Count = 0;
            string query = "select count(*) from users where login ='" + logBox.Text + "' and pass = '" + passBox.Text + "';";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            cmDB.CommandTimeout = 60;
            try
            {
                conn.Open();
                Count = Convert.ToInt32(cmDB.ExecuteScalar());
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка авторизации. Попробуйте еще раз.");
                MessageBox.Show(ex.Message);
            }
            if (Count > 0)
            {
                Items Win = new Items();
                Win.Show();
                this.Hide();
            }
        }
    }
}
