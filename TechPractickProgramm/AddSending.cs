using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechPractickProgramm
{
    public partial class AddSending : Form
    {
        public AddSending()
        {
            InitializeComponent();
        }

        private void AddSending_Load(object sender, EventArgs e)
        {
            using (DBManager db = new DBManager())
            {
                chooseTypeSendingCB.SelectedIndexChanged -= chooseTypeSendingCB_SelectedIndexChanged;
                string query = $"Select c.idClient as 'Id', CONCAT(trim(c.firstName), ' ' ,trim(c.lastName), ' ' ,trim(c.partonymic))" +
            $" as 'FIO' From Clients c";
                db.LoadDataToComboBox(query, chooseRecipientSendingCB, "FIO", "Id");
                db.LoadDataToComboBox(query, chooseSenderSendingCB, "FIO", "Id");
                query = "Select idType, typeName From Types";
                db.LoadDataToComboBox(query, chooseTypeSendingCB, "typeName", "idType");
                chooseTypeSendingCB.SelectedIndexChanged += chooseTypeSendingCB_SelectedIndexChanged;
            }
        }

        private void chooseTypeSendingCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(chooseTypeSendingCB.SelectedIndex != -1)
                using (DBManager db = new DBManager())
                {
                    string query = $"Select [percent] From Types where idType = {chooseTypeSendingCB.SelectedValue.ToString()}";
                    percentInfo.Text = db.ExecuteScalar(query).Trim()+"%";
                }
        }

        private void addWeightSendingTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (double.TryParse(addWeightSendingTB.Text, out double weight))
                {
                    double percent = double.Parse(percentInfo.Text.Substring(0, percentInfo.Text.Length - 1));
                    double costPercent = ((weight * 10) * (percent/100));
                    double cost = (weight * 10) + costPercent;
                    addCostSendingTB.Text = cost.ToString();
                }
                else MessageBox.Show("Требуется выбрать числовое значение");
               
            }
        }

        private void addSendingBtn_Click(object sender, EventArgs e)
        {
            if(chooseRecipientSendingCB.SelectedIndex != -1 && chooseSenderSendingCB.SelectedIndex != -1 
                && chooseTypeSendingCB.SelectedIndex != -1 && addBarCodeSendingTB.Text != "" && 
                double.TryParse(addWeightSendingTB.Text,out double weight) && addCostSendingTB.Text != "")
            {
                if (addBarCodeSendingTB.Text.Length == 14)
                    if (chooseRecipientSendingCB.SelectedValue != chooseSenderSendingCB.SelectedValue)
                        using (DBManager db = new DBManager())
                        {
                            string query = $"Insert into Sendings " +
                                $"Values({chooseRecipientSendingCB.SelectedValue},{chooseSenderSendingCB.SelectedValue}," +
                                $"{chooseTypeSendingCB.SelectedValue},'{addBarCodeSendingTB.Text}',{weight.ToString().Replace(',','.')}," +
                                $"{addCostSendingTB.Text.Replace(',','.')})";
                            db.ExecuteNonQuery(query);
                            this.Close();
                        }
                    else MessageBox.Show("Невозможен одинаковый отправитель и получатель");
                else MessageBox.Show("Введите корректный штрихкод");
            }
            else MessageBox.Show("Требуется корректно заполнить все поля");
        }
    }
}
