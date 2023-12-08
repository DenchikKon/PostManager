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
    public partial class UpdateType : Form
    {
        private int idType;
        public UpdateType(int id)
        {
            idType = id;
            InitializeComponent();
        }

        private void updateTypeBtn_Click(object sender, EventArgs e)
        {
            if (updateTypeNameTB.Text != "" && int.TryParse(updateTypePercentTB.Text, out int percent))
            {
                using (DBManager db = new DBManager())
                {
                    string query = $"Update Types Set [percent] = {percent}, typeName = N'{updateTypeNameTB.Text.Trim()}' where idType = {idType}";
                    db.ExecuteNonQuery(query);
                    this.Close();
                }
            }
            else MessageBox.Show("Требует корректно заполнить все поля");
        }

        private void UpdateType_Load(object sender, EventArgs e)
        {
            using (DBManager db = new DBManager())
            {
                string query = $"Select typeName from Types where idType = {idType}";
                updateTypeNameTB.Text = db.ExecuteScalar(query);
                query = $"Select [percent] from Types where idType = {idType}";
                updateTypePercentTB.Text = db.ExecuteScalar(query);
            }
        }

        private void updateTypePercentTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsNumber(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
