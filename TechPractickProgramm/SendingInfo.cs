using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TechPractickProgramm
{
    public partial class SendingInfo : Form
    {
        private int idSending;
        public SendingInfo(int id)
        {
            idSending = id;
            InitializeComponent();
        }

        private void SendingInfo_Load(object sender, EventArgs e)
        {
            using (DBManager db = new DBManager())
            {
                string query = $"Select s.barCode as 'Штрихкод', " +
           $"CONCAT(trim(sen.firstName), ' ' ,trim(sen.lastName), ' ' ,trim(sen.partonymic)) as 'Отправитель'," +
           $"CONCAT(trim(rec.firstName), ' ' ,trim(rec.lastName), ' ' ,trim(rec.partonymic)) as 'Получатель', " +
           $"s.weight as 'Вес', s.cost as 'Стоимость отправки', Types.typeName From Sendings s " +
           $"join Clients rec on rec.idClient = s.idRecipient join Clients sen on sen.idClient = s.idSender " +
           $"join Types on Types.idType = s.idType";
                SqlCommand sqlCommand = new SqlCommand(query, db.connection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    senderInfo.Text = sqlDataReader.GetString(1).ToString();
                    RecipientInfo.Text = sqlDataReader.GetString(2).ToString();
                    typeInfo.Text = sqlDataReader.GetString(5).ToString();
                    costInfo.Text = sqlDataReader.GetDouble(4).ToString();
                    weightInfo.Text = sqlDataReader.GetDouble(3).ToString();
                    barCodeInfo.Text = sqlDataReader.GetString(0).ToString();
                }
                sqlDataReader.Close();
                query = $"Select Op.idOperation, Tp.typeOperationName as 'Наименование', Op.date as 'Дата' " +
                    $"From Operations Op join TypeOperations Tp on Tp.idTypeOperation = Op.idTypeOperation " +
                    $"where Op.idSending = {idSending}";
                db.LoadDataToDataGrid(query, operationsSendingdataGrid);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void completeOperationBtn_Click(object sender, EventArgs e)
        {
            using (DBManager db = new DBManager())
            {
                string query = $"Select Max(Operations.idTypeOperation) From Operations where Operations.idSending = {idSending}";
                int idLastOperation = Convert.ToInt32(db.ExecuteScalar(query));
                if (idLastOperation < 5)
                {
                    ++idLastOperation;
                    query = $"Insert into Operations Values({idLastOperation},{idSending},'{DateTime.Now.ToString("yyyy/MM/dd")}')";
                    db.ExecuteNonQuery(query);
                    query = $"Select Op.idOperation, Tp.typeOperationName as 'Наименование', Op.date as 'Дата' " +
                   $"From Operations Op join TypeOperations Tp on Tp.idTypeOperation = Op.idTypeOperation " +
                   $"where Op.idSending = {idSending}";
                    db.LoadDataToDataGrid(query, operationsSendingdataGrid);
                }
                else MessageBox.Show("Все операции по данной посылке выполнены");
            }
        }
    }
}
