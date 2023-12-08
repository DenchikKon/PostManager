using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace TechPractickProgramm
{
    internal class DBManager : IDisposable
    {
        public SqlConnection connection = null;
        public string mainClientQuery = $"Select c.idClient, CONCAT(trim(c.firstName), ' ' ,trim(c.lastName), ' ' ,trim(c.partonymic))" +
            $" as 'ФИО Клиента', c.address as Адрес From Clients c";
        public string mainTypeQuery = $"Select t.idType, t.typeName as 'Наименование', t.[percent] as 'Налог(%)' From Types t";
        public string mainSendingQuery = $"Select s.idSending, s.barCode as 'Штрихкод', " +
            $"CONCAT(trim(sen.firstName), ' ' ,trim(sen.lastName), ' ' ,trim(sen.partonymic)) as 'Отправитель'," +
            $"CONCAT(trim(rec.firstName), ' ' ,trim(rec.lastName), ' ' ,trim(rec.partonymic)) as 'Получатель', " +
            $"s.weight as 'Вес', s.cost as 'Стоимость отправки' From Sendings s " +
            $"join Clients rec on rec.idClient = s.idRecipient join Clients sen on sen.idClient = s.idSender";
        public DBManager()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["texPractickDB"].ConnectionString);
            if (connection.State != ConnectionState.Open)
                connection.Open();
        }
        public void LoadDataToComboBox(String query, ComboBox comboBox, string displayMember, string valueMember)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            comboBox.DataSource = dataTable;
            comboBox.DisplayMember = $"{displayMember}";
            comboBox.ValueMember = $"{valueMember}";
            comboBox.SelectedIndex = -1;

        }
        public void LoadDataToDataGrid(string query, DataGridView dataGrid)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGrid.DataSource = dataTable;
            dataGrid.Columns[0].Visible = false;
        }
        public void ExecuteNonQuery(string query)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.ExecuteNonQuery();
            }
            catch(Exception ex) { MessageBox.Show("Невозможно удалить данную запись"); }
        }
        public string ExecuteScalar(string query)
        {
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            return sqlCommand.ExecuteScalar()?.ToString();
        }
        public void Dispose()
        {
            connection.Close();
        }
    }
}

