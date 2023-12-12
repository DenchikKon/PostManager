using OfficeOpenXml;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Tulpep.NotificationWindow;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Windows.Forms.VisualStyles;
using Word = Microsoft.Office.Interop.Word;

namespace TechPractickProgramm
{
    public partial class Form1 : Form
    {
        PopupNotifier notifier = null;
        private string query;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (DBManager db = new DBManager())
            {

                db.LoadDataToDataGrid(db.mainClientQuery, clientDataGrid);
                db.LoadDataToDataGrid(db.mainTypeQuery, typeDataGrid);
                db.LoadDataToDataGrid(db.mainSendingQuery, sendingDataGrid);
                query = $"Select c.idClient as 'Id', CONCAT(trim(c.firstName), ' ' ,trim(c.lastName), ' ' ,trim(c.partonymic))" +
            $" as 'FIO' From Clients c";
                db.LoadDataToComboBox(query, clientFilterSendingCB, "FIO", "Id");
            }
            notifier = new PopupNotifier();
            notifier.ContentText = "Операция выполнена";
            notifier.BodyColor = Color.Green;
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (addClientFirstNameTB.Text != "" && addClientLastNameTB.Text != "" && addClientPatronymicTB.Text != ""
                && addClientAddressTB.Text != "")
            {
                using (DBManager db = new DBManager())
                {
                    query = $"Insert into Clients Values(N'{addClientFirstNameTB.Text.Trim()}', " +
                        $"N'{addClientLastNameTB.Text.Trim()}', N'{addClientPatronymicTB.Text.Trim()}', N'{addClientAddressTB.Text.Trim()}')";
                    db.ExecuteNonQuery(query);
                    notifier.Popup();
                    addClientFirstNameTB.Text = "";
                    addClientLastNameTB.Text = "";
                    addClientPatronymicTB.Text = "";
                    addClientAddressTB.Text = "";

                }
            }
            else MessageBox.Show("Требуется заполнить все поля");
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (DBManager db = new DBManager())
            {

                db.LoadDataToDataGrid(db.mainClientQuery, clientDataGrid);
                db.LoadDataToDataGrid(db.mainTypeQuery, typeDataGrid);
                db.LoadDataToDataGrid(db.mainSendingQuery, sendingDataGrid);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (addTypeNameTB.Text != "" && int.TryParse(addTypePercentTB.Text, out int percent))
            {
                    using (DBManager db = new DBManager())
                    {
                        query = $"Insert into Types Values({percent},N'{addTypeNameTB.Text.Trim()}')";
                        db.ExecuteNonQuery(query);
                        notifier.Popup();
                        addTypeNameTB.Text = "";
                        addTypePercentTB.Text = "";
                    }
            }
            else MessageBox.Show("Требует корректно заполнить все поля");
        }

        private void searchClintTB_TextChanged(object sender, EventArgs e)
        {
            Methods.SearchData(clientDataGrid, searchClintTB);
        }

        private void searchSendingTB_TextChanged(object sender, EventArgs e)
        {
            Methods.SearchData(sendingDataGrid, searchSendingTB);
        }

        private void searchTypeTB_TextChanged(object sender, EventArgs e)
        {
            Methods.SearchData(typeDataGrid, searchTypeTB);
        }

        private void DeleteSending_Click(object sender, EventArgs e)
        {
            if (sendingDataGrid.SelectedRows != null)
                using (DBManager db = new DBManager())
                {
                    query = $"Delete From Sendings where idSending = {sendingDataGrid.SelectedRows[0].Cells[0].Value}";
                    db.ExecuteNonQuery(query);
                    db.LoadDataToDataGrid(db.mainSendingQuery, sendingDataGrid);
                    notifier.Popup();
                }
            else MessageBox.Show("Требуется выбрать запись для удаления");
        }

        private void sendingDataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex != -1)
                {
                    sendingDataGrid.ClearSelection();
                    sendingDataGrid[e.ColumnIndex, e.RowIndex].Selected = true;
                }
            }
        }

        private void clientDataGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex != -1)
                {
                    clientDataGrid.ClearSelection();
                    clientDataGrid[e.ColumnIndex, e.RowIndex].Selected = true;
                }
            }
        }

        private void typeDataGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex != -1)
                {
                    typeDataGrid.ClearSelection();
                    typeDataGrid[e.ColumnIndex, e.RowIndex].Selected = true;
                }
            }
        }

        private void DeleteClient_Click(object sender, EventArgs e)
        {
            if (clientDataGrid.SelectedRows != null)
                using (DBManager db = new DBManager())
                {
                    query = $"Delete From Clients where idClient = {clientDataGrid.SelectedRows[0].Cells[0].Value}";
                    db.ExecuteNonQuery(query);
                    db.LoadDataToDataGrid(db.mainClientQuery, clientDataGrid);
                }
            else MessageBox.Show("Требуется выбрать запись для удаления");
        }

        private void DeleteType_Click(object sender, EventArgs e)
        {
            if (typeDataGrid.SelectedRows != null)
                using (DBManager db = new DBManager())
                {
                    query = $"Delete From Types where idType = {typeDataGrid.SelectedRows[0].Cells[0].Value}";
                    db.ExecuteNonQuery(query);
                    db.LoadDataToDataGrid(db.mainTypeQuery, typeDataGrid);
                }
            else MessageBox.Show("Требуется выбрать запись для удаления");
        }

        private void resetSending_Click(object sender, EventArgs e)
        {
            using (DBManager db = new DBManager())
            {
                db.LoadDataToDataGrid(db.mainSendingQuery, sendingDataGrid);
            }
        }

        private void resetClient_Click(object sender, EventArgs e)
        {
            using (DBManager db = new DBManager())
            {
                db.LoadDataToDataGrid(db.mainClientQuery, clientDataGrid);
            }
        }

        private void resetType_Click(object sender, EventArgs e)
        {
            using (DBManager db = new DBManager())
            {
                db.LoadDataToDataGrid(db.mainTypeQuery, typeDataGrid);
            }
        }

        private void addClientFirstNameTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsLetter(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void addClientLastNameTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsLetter(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void addClientPatronymicTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsLetter(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void addTypePercentTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsNumber(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (firstNameFilterClientTB.Text != "" || lastNameFilterClientTB.Text != "" ||
                 PatronymicFilterClientTB.Text != "" || addressFilterClientTB.Text != "")
                using (DBManager db = new DBManager())
                {
                    query = db.mainClientQuery + $" where c.firstName like N'%{firstNameFilterClientTB.Text}%' and " +
                        $" c.lastName like N'%{lastNameFilterClientTB.Text}%' and c.partonymic like N'%{PatronymicFilterClientTB.Text}%' and " +
                        $"c.address like N'%{addressFilterClientTB.Text}%'";
                    db.LoadDataToDataGrid(query, clientDataGrid);
                    firstNameFilterClientTB.Text = "";
                    lastNameFilterClientTB.Text = "";
                    PatronymicFilterClientTB.Text = "";
                    addressFilterClientTB.Text = "";
                }
            else MessageBox.Show("Для фильтрации хотя бы одно поле должно быть заполнено!");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (typeNameFilterTB.Text != "" || int.TryParse(percentTypeStartFilterTB.Text, out int startPercent)
                || int.TryParse(percentTypeEndFilterTB.Text, out int endPercent))
                using (DBManager db = new DBManager())
                {
                    startPercent = int.TryParse(percentTypeStartFilterTB.Text, out int timeStartPersent) ? timeStartPersent : 0;
                    endPercent = int.TryParse(percentTypeEndFilterTB.Text, out int timeEndPersent) ? timeEndPersent : 9999999;
                    if (startPercent < endPercent)
                    {
                        query = db.mainTypeQuery + $" where t.typeName like N'%{typeNameFilterTB.Text}%' and " +
                        $"t.[percent] between {startPercent} and {endPercent}";
                        db.LoadDataToDataGrid(query, typeDataGrid);
                        typeNameFilterTB.Text = "";
                        percentTypeStartFilterTB.Text = "";
                        percentTypeEndFilterTB.Text = "";
                    }
                    else MessageBox.Show("Начальное значение не может превышать конечное");
                }
            else MessageBox.Show("Для фильтрации хотя бы одно поле должно быть заполнено верно!");
        }

        private void filterSendingBtn_Click(object sender, EventArgs e)
        {
            if(barCodeFilterSendingTB.Text != "" || double.TryParse(costStartFilterSendingTB.Text, out double startcost) || 
                double.TryParse(costEndFilterSendingTB.Text,out double endCost) || clientFilterSendingCB.SelectedIndex != -1)
            {
                startcost = double.TryParse(costStartFilterSendingTB.Text,out double timeStartCost) ? timeStartCost : 0;
                endCost = double.TryParse(costEndFilterSendingTB.Text,out double timeEndCost) ? timeEndCost : 9999999;
                if(startcost < endCost)
                {
                    using (DBManager db = new DBManager())
                    {
                        query = db.mainSendingQuery + $" where barCode like N'%{barCodeFilterSendingTB.Text}%' and " +
                            $"cost between {startcost.ToString().Replace(',','.')} and {endCost.ToString().Replace(',', '.')}";
                        query += clientFilterSendingCB.SelectedIndex != -1 ?
                            $" and (idRecipient = {clientFilterSendingCB.SelectedValue} " +
                            $"or idSender = {clientFilterSendingCB.SelectedValue})" : "";
                        db.LoadDataToDataGrid(query, sendingDataGrid);
                        barCodeFilterSendingTB.Text = "";
                        costStartFilterSendingTB.Text = "";
                        costEndFilterSendingTB.Text = "";
                        clientFilterSendingCB.SelectedIndex = -1;
                    }
                }
                else MessageBox.Show("Начальное значение не может превышать конечное");
            }
            else MessageBox.Show("Для фильтрации хотя бы одно поле должно быть заполнено верно!");
        }

        private void UpdateTypeBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(typeDataGrid.SelectedRows[0].Cells[0].Value.ToString(), out int idType))
            {
                UpdateType updateType = new UpdateType(idType);
                this.Enabled = false;
                updateType.ShowDialog();
                this.Enabled = true;
                using (DBManager db = new DBManager())
                    db.LoadDataToDataGrid(db.mainTypeQuery, typeDataGrid);
            }
            else MessageBox.Show("Требуется выбрать запись");
            
        }

        private void UpdateClientBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(clientDataGrid.SelectedRows[0].Cells[0].Value.ToString(), out int idClient))
            {
                UpdateClient updateClient  = new UpdateClient(idClient);
                this.Enabled = false;
                updateClient.ShowDialog();
                this.Enabled = true;
                using (DBManager db = new DBManager())
                    db.LoadDataToDataGrid(db.mainClientQuery, clientDataGrid);
            }
            else MessageBox.Show("Требуется выбрать запись");
        }

        private void addSending_Click(object sender, EventArgs e)
        {
            AddSending addSending = new AddSending();
            this.Enabled = false;
            addSending.ShowDialog();
            this.Enabled = true;
            using(DBManager db = new DBManager())
                db.LoadDataToDataGrid(db.mainSendingQuery, sendingDataGrid);
        }

        private void sendingDataGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(sendingDataGrid.SelectedRows[0] != null)
            {
                SendingInfo sendingInfo = new SendingInfo(int.Parse(sendingDataGrid.SelectedRows[0].Cells[0].Value.ToString()));
                this.Enabled = false;
                sendingInfo.ShowDialog();
                this.Enabled =true;

            }
        }

        private void ExcelClientBtn_Click(object sender, EventArgs e)
        {
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                using(DBManager db = new DBManager())
                {
                    excelPackage.Workbook.Properties.Title = $"Клиенты";
                    excelPackage.Workbook.Properties.Created = DateTime.Now;
                    string query = $"Select CONCAT(trim(c.firstName), ' ' ,trim(c.lastName), ' ' ,trim(c.partonymic))" +
                    $" as 'ФИО Клиента', c.address as Адрес From Clients c";
                    DataTable dataTable = new DataTable();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, db.connection);
                    sqlDataAdapter.Fill(dataTable);
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Клиенты");
					worksheet.Cells[1, 1, 1, 2].Merge = true;
					worksheet.Cells[1, 1].Value = "Список клиентов";
					worksheet.Cells[2, 1].Value = "ФИО";
                    worksheet.Cells[2, 2].Value = "Адрес";
                    worksheet.Cells.AutoFitColumns();
                    for (int i = 0, sI = 2; i < dataTable.Rows.Count; sI++, i++)
                    {
                        object[] RowString = dataTable.Rows[i].ItemArray;
                        worksheet.Cells[sI, 1].Value = RowString[0].ToString().Trim();
                        worksheet.Cells[sI, 2].Value = RowString[1].ToString().Trim();
						worksheet.Cells[sI, 1].Style.Border.BorderAround(ExcelBorderStyle.Thick);
						worksheet.Cells[sI, 2].Style.Border.BorderAround(ExcelBorderStyle.Thick);
					}
					worksheet.Cells[dataTable.Rows.Count + 2, 1, dataTable.Rows.Count + 2, 2].Merge = true;
					worksheet.Cells[dataTable.Rows.Count + 2, 1].Value = $"Дата составления: {DateTime.Now.ToShortDateString()}";
					worksheet.Cells.AutoFitColumns();
                    worksheet.Cells.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    string excelFileName = "Клиенты.xlsx";
                    FileInfo file = new FileInfo(excelFileName);
                    try
                    {
                        excelPackage.SaveAs(file);
                        Process.Start(excelFileName);
                    }
                    catch (InvalidOperationException)
                    {
                        MessageBox.Show("Для формирования нового отчета требуется закрыть ранее созданный", "Ошибка создания отчета"
                            , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void excleTypeBtn_Click(object sender, EventArgs e)
        {
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                using (DBManager db = new DBManager())
                {
                    excelPackage.Workbook.Properties.Title = $"Тип оправки";
                    excelPackage.Workbook.Properties.Created = DateTime.Now;
                    string query = $"Select t.typeName as 'Наименование', t.[percent] as 'Налог(%)' From Types t";
                    DataTable dataTable = new DataTable();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, db.connection);
                    sqlDataAdapter.Fill(dataTable);
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Тип отправки");
					worksheet.Cells[1, 1, 1, 2].Merge = true;
					worksheet.Cells[1, 1].Value = "Список типов отправки";
					worksheet.Cells[2, 1].Value = "Название";
                    worksheet.Cells[2, 2].Value = "Процент(%)";
                    worksheet.Cells.AutoFitColumns();
                    for (int i = 0, sI = 2; i < dataTable.Rows.Count; sI++, i++)
                    {
                        object[] RowString = dataTable.Rows[i].ItemArray;
                        worksheet.Cells[sI, 1].Value = RowString[0].ToString().Trim();
                        worksheet.Cells[sI, 2].Value = RowString[1].ToString().Trim();
						worksheet.Cells[sI, 1].Style.Border.BorderAround(ExcelBorderStyle.Thick);
						worksheet.Cells[sI, 2].Style.Border.BorderAround(ExcelBorderStyle.Thick);
					}
					worksheet.Cells[dataTable.Rows.Count + 2, 1, dataTable.Rows.Count + 2, 2].Merge = true;
					worksheet.Cells[dataTable.Rows.Count + 2, 1].Value = $"Дата составления: {DateTime.Now.ToShortDateString()}";
					worksheet.Cells.AutoFitColumns();
                    worksheet.Cells.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    string excelFileName = "Тип оправки.xlsx";
                    FileInfo file = new FileInfo(excelFileName);
                    try
                    {
                        excelPackage.SaveAs(file);
                        Process.Start(excelFileName);
                    }
                    catch (InvalidOperationException)
                    {
                        MessageBox.Show("Для формирования нового отчета требуется закрыть ранее созданный", "Ошибка создания отчета"
                            , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void excelSendingBtn_Click(object sender, EventArgs e)
        {
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                using (DBManager db = new DBManager())
                {
                    excelPackage.Workbook.Properties.Title = $"Посылки";
                    excelPackage.Workbook.Properties.Created = DateTime.Now;
                    string query = $"Select s.barCode as 'Штрихкод', " +
            $"CONCAT(trim(sen.firstName), ' ' ,trim(sen.lastName), ' ' ,trim(sen.partonymic)) as 'Отправитель'," +
            $"CONCAT(trim(rec.firstName), ' ' ,trim(rec.lastName), ' ' ,trim(rec.partonymic)) as 'Получатель', " +
            $"s.weight as 'Вес', s.cost as 'Стоимость отправки' From Sendings s " +
            $"join Clients rec on rec.idClient = s.idRecipient join Clients sen on sen.idClient = s.idSender";
                    DataTable dataTable = new DataTable();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, db.connection);
                    sqlDataAdapter.Fill(dataTable);
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Отправления");
					worksheet.Cells[1, 1, 1, 4].Merge = true;
                    worksheet.Cells[1, 1].Value = "Список отправлений";
					worksheet.Cells[2, 1].Value = "Штрихкод";
                    worksheet.Cells[2, 2].Value = "Отправитель";
                    worksheet.Cells[2, 3].Value = "Получатель";
                    worksheet.Cells[2, 4].Value = "Стоимость";
                    worksheet.Cells.AutoFitColumns();
                    for (int i = 0, sI = 3; i < dataTable.Rows.Count; sI++, i++)
                    {
                        object[] RowString = dataTable.Rows[i].ItemArray;
                        worksheet.Cells[sI, 1].Value = RowString[0].ToString().Trim();
                        worksheet.Cells[sI, 2].Value = RowString[1].ToString().Trim();
                        worksheet.Cells[sI, 3].Value = RowString[2].ToString().Trim();
                        worksheet.Cells[sI, 4].Value = RowString[3].ToString().Trim();
						worksheet.Cells[sI, 1].Style.Border.BorderAround(ExcelBorderStyle.Thick);
						worksheet.Cells[sI, 2].Style.Border.BorderAround(ExcelBorderStyle.Thick);
						worksheet.Cells[sI, 3].Style.Border.BorderAround(ExcelBorderStyle.Thick);
						worksheet.Cells[sI, 4].Style.Border.BorderAround(ExcelBorderStyle.Thick);
					}
                    worksheet.Cells[dataTable.Rows.Count + 3, 1, dataTable.Rows.Count + 3, 4].Merge =true;
                    worksheet.Cells[dataTable.Rows.Count + 3, 1].Value = $"Дата составления: {DateTime.Now.ToShortDateString()}";

				   worksheet.Cells.AutoFitColumns();
                    worksheet.Cells.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    string excelFileName = "Отправления.xlsx";
                    FileInfo file = new FileInfo(excelFileName);
                    try
                    {
                        excelPackage.SaveAs(file);
                        Process.Start(excelFileName);
                    }
                    catch (InvalidOperationException)
                    {
                        MessageBox.Show("Для формирования нового отчета требуется закрыть ранее созданный", "Ошибка создания отчета"
                            , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

		private void groupBox3_Enter(object sender, EventArgs e)
		{

		}

		private void ExcelSendingDoc_Click(object sender, EventArgs e)
		{
            try
            {
                
				var wordApp = new Word.Application();
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "примерОтправления.docx");
				var doc = wordApp.Documents.Open(path);
				if (sendingDataGrid.SelectedRows[0] == null)
					MessageBox.Show("Требуется выбрать отправление");
				int idSending = Convert.ToInt32(sendingDataGrid.SelectedRows[0].Cells[0].Value);
				using (DBManager db = new DBManager())
				{
					query = $"Select S.barCode, CONCAT(Trim(Sender.lastName),' ', Trim(Sender.firstName), ' ',Trim(Sender.partonymic)), " +
						$"Sender.address, CONCAT(Trim(Recipient.lastName),' ', Trim(Recipient.firstName), ' ',Trim(Recipient.partonymic)), " +
						$"Recipient.address From Sendings S " +
						$"join Clients Sender on Sender.idClient=S.idSender " +
						$"join Clients Recipient on Recipient.idClient=S.idRecipient " +
						$"where S.idSending = {idSending}";
					DataTable dataTable = new DataTable();
					SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, db.connection);
					sqlDataAdapter.Fill(dataTable);
					object[] RowString = dataTable.Rows[0].ItemArray;
					// Заменяем поля в документе на нужные значения
					doc.Content.Find.Execute(FindText: "<barcode>", ReplaceWith: RowString[0].ToString());
					doc.Content.Find.Execute(FindText: "<sender>", ReplaceWith: RowString[1].ToString());
					doc.Content.Find.Execute(FindText: "<addressSender>", ReplaceWith: RowString[2].ToString());
					doc.Content.Find.Execute(FindText: "<pacipient>", ReplaceWith: RowString[3].ToString());
					doc.Content.Find.Execute(FindText: "<addresspacipient>", ReplaceWith: RowString[4].ToString());

					wordApp.Visible = true;
				}
			}
            catch(Exception ex)
            {
                MessageBox.Show("Произошла ошибка. Убедитесь что документ закрыт и повторите попытку");
            }
           
			
			
		}
	}
}
