using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechPractickProgramm
{
    public partial class UpdateClient : Form
    {
        private int idClient;
        public UpdateClient(int id)
        {
            idClient = id;
            InitializeComponent();
        }

        private void updateClientFirstNameTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsLetter(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void updateClientLastNameTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsLetter(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void updateClientPatronymicTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsLetter(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void UpdateClient_Load(object sender, EventArgs e)
        {
            using (DBManager db = new DBManager())
            {
                string query = $"Select firstName,lastName, partonymic ,address From Clients where idClient = {idClient}";
                SqlCommand sqlCommand = new SqlCommand(query,db.connection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    updateClientFirstNameTB.Text = sqlDataReader.GetString(0);
                    updateClientLastNameTB.Text = sqlDataReader.GetString(1);
                    updateClientPatronymicTB.Text = sqlDataReader.GetString(2);
                    updateClientAddressTB.Text = sqlDataReader.GetString(3);
                }
                    
            }
        }

        private void updateClientBtn_Click(object sender, EventArgs e)
        {
            if (updateClientFirstNameTB.Text != "" && updateClientLastNameTB.Text != "" && updateClientPatronymicTB.Text != ""
               && updateClientAddressTB.Text != "")
            {
                using (DBManager db = new DBManager())
                {
                    string query = $"Update Clients Set firstName = N'{updateClientFirstNameTB.Text.Trim()}', " +
                        $"lastName = N'{updateClientLastNameTB.Text.Trim()}', partonymic = N'{updateClientPatronymicTB.Text.Trim()}'," +
                        $" address = N'{updateClientAddressTB.Text.Trim()}' where idClient = {idClient}";
                    db.ExecuteNonQuery(query);
                    this.Close();
                }
            }
            else MessageBox.Show("Требуется заполнить все поля");
        }
    }
}
