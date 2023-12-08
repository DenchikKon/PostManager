namespace TechPractickProgramm
{
    partial class SendingInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendingInfo));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.barCodeInfo = new System.Windows.Forms.Label();
			this.weightInfo = new System.Windows.Forms.Label();
			this.costInfo = new System.Windows.Forms.Label();
			this.RecipientInfo = new System.Windows.Forms.Label();
			this.typeInfo = new System.Windows.Forms.Label();
			this.senderInfo = new System.Windows.Forms.Label();
			this.operationsSendingdataGrid = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.completeOperationBtn = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.operationsSendingdataGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(10, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(97, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Отправитель:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(10, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Получатель:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(10, 103);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(99, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Тип доставки:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(373, 103);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "Штрихкод:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(373, 63);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(51, 16);
			this.label5.TabIndex = 4;
			this.label5.Text = "Масса:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(373, 28);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(77, 16);
			this.label6.TabIndex = 5;
			this.label6.Text = "Стоимость";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.SkyBlue;
			this.groupBox1.Controls.Add(this.barCodeInfo);
			this.groupBox1.Controls.Add(this.weightInfo);
			this.groupBox1.Controls.Add(this.costInfo);
			this.groupBox1.Controls.Add(this.RecipientInfo);
			this.groupBox1.Controls.Add(this.typeInfo);
			this.groupBox1.Controls.Add(this.senderInfo);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
			this.groupBox1.Location = new System.Drawing.Point(4, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(627, 168);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Информация";
			// 
			// barCodeInfo
			// 
			this.barCodeInfo.AutoSize = true;
			this.barCodeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.barCodeInfo.Location = new System.Drawing.Point(456, 103);
			this.barCodeInfo.Name = "barCodeInfo";
			this.barCodeInfo.Size = new System.Drawing.Size(97, 16);
			this.barCodeInfo.TabIndex = 11;
			this.barCodeInfo.Text = "Отправитель:";
			// 
			// weightInfo
			// 
			this.weightInfo.AutoSize = true;
			this.weightInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.weightInfo.Location = new System.Drawing.Point(456, 63);
			this.weightInfo.Name = "weightInfo";
			this.weightInfo.Size = new System.Drawing.Size(97, 16);
			this.weightInfo.TabIndex = 10;
			this.weightInfo.Text = "Отправитель:";
			// 
			// costInfo
			// 
			this.costInfo.AutoSize = true;
			this.costInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.costInfo.Location = new System.Drawing.Point(456, 28);
			this.costInfo.Name = "costInfo";
			this.costInfo.Size = new System.Drawing.Size(97, 16);
			this.costInfo.TabIndex = 9;
			this.costInfo.Text = "Отправитель:";
			// 
			// RecipientInfo
			// 
			this.RecipientInfo.AutoSize = true;
			this.RecipientInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.RecipientInfo.Location = new System.Drawing.Point(111, 63);
			this.RecipientInfo.Name = "RecipientInfo";
			this.RecipientInfo.Size = new System.Drawing.Size(97, 16);
			this.RecipientInfo.TabIndex = 8;
			this.RecipientInfo.Text = "Отправитель:";
			// 
			// typeInfo
			// 
			this.typeInfo.AutoSize = true;
			this.typeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.typeInfo.Location = new System.Drawing.Point(111, 103);
			this.typeInfo.Name = "typeInfo";
			this.typeInfo.Size = new System.Drawing.Size(97, 16);
			this.typeInfo.TabIndex = 7;
			this.typeInfo.Text = "Отправитель:";
			// 
			// senderInfo
			// 
			this.senderInfo.AutoSize = true;
			this.senderInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.senderInfo.Location = new System.Drawing.Point(111, 28);
			this.senderInfo.Name = "senderInfo";
			this.senderInfo.Size = new System.Drawing.Size(70, 16);
			this.senderInfo.TabIndex = 6;
			this.senderInfo.Text = "senderInfo";
			// 
			// operationsSendingdataGrid
			// 
			this.operationsSendingdataGrid.AllowUserToAddRows = false;
			this.operationsSendingdataGrid.AllowUserToDeleteRows = false;
			this.operationsSendingdataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.operationsSendingdataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.operationsSendingdataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
			this.operationsSendingdataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.operationsSendingdataGrid.Location = new System.Drawing.Point(4, 186);
			this.operationsSendingdataGrid.MultiSelect = false;
			this.operationsSendingdataGrid.Name = "operationsSendingdataGrid";
			this.operationsSendingdataGrid.ReadOnly = true;
			this.operationsSendingdataGrid.RowHeadersVisible = false;
			this.operationsSendingdataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.operationsSendingdataGrid.Size = new System.Drawing.Size(627, 226);
			this.operationsSendingdataGrid.TabIndex = 7;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Salmon;
			this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
			this.button1.Location = new System.Drawing.Point(546, 418);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(85, 33);
			this.button1.TabIndex = 8;
			this.button1.Text = "Закрыть";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// completeOperationBtn
			// 
			this.completeOperationBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.completeOperationBtn.ForeColor = System.Drawing.Color.MidnightBlue;
			this.completeOperationBtn.Location = new System.Drawing.Point(405, 418);
			this.completeOperationBtn.Name = "completeOperationBtn";
			this.completeOperationBtn.Size = new System.Drawing.Size(135, 33);
			this.completeOperationBtn.TabIndex = 9;
			this.completeOperationBtn.Text = "Операция выполнена";
			this.completeOperationBtn.UseVisualStyleBackColor = false;
			this.completeOperationBtn.Click += new System.EventHandler(this.completeOperationBtn_Click);
			// 
			// SendingInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SkyBlue;
			this.ClientSize = new System.Drawing.Size(634, 463);
			this.Controls.Add(this.completeOperationBtn);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.operationsSendingdataGrid);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "SendingInfo";
			this.Text = "Отправление";
			this.Load += new System.EventHandler(this.SendingInfo_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.operationsSendingdataGrid)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView operationsSendingdataGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button completeOperationBtn;
        private System.Windows.Forms.Label barCodeInfo;
        private System.Windows.Forms.Label weightInfo;
        private System.Windows.Forms.Label costInfo;
        private System.Windows.Forms.Label RecipientInfo;
        private System.Windows.Forms.Label typeInfo;
        private System.Windows.Forms.Label senderInfo;
    }
}