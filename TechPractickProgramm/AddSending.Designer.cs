namespace TechPractickProgramm
{
    partial class AddSending
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSending));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.chooseTypeSendingCB = new System.Windows.Forms.ComboBox();
			this.chooseSenderSendingCB = new System.Windows.Forms.ComboBox();
			this.chooseRecipientSendingCB = new System.Windows.Forms.ComboBox();
			this.addBarCodeSendingTB = new System.Windows.Forms.TextBox();
			this.addWeightSendingTB = new System.Windows.Forms.TextBox();
			this.addCostSendingTB = new System.Windows.Forms.TextBox();
			this.addSendingBtn = new System.Windows.Forms.Button();
			this.percentInfo = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label1.Location = new System.Drawing.Point(34, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(97, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Отправитель:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label2.Location = new System.Drawing.Point(34, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Получатель:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label3.Location = new System.Drawing.Point(34, 116);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(99, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Тип доставки:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label4.Location = new System.Drawing.Point(34, 157);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "Штрихкод:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label5.Location = new System.Drawing.Point(34, 199);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(51, 16);
			this.label5.TabIndex = 4;
			this.label5.Text = "Масса:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label6.Location = new System.Drawing.Point(34, 236);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 16);
			this.label6.TabIndex = 5;
			this.label6.Text = "Стоимость:";
			// 
			// chooseTypeSendingCB
			// 
			this.chooseTypeSendingCB.ForeColor = System.Drawing.Color.MidnightBlue;
			this.chooseTypeSendingCB.FormattingEnabled = true;
			this.chooseTypeSendingCB.Location = new System.Drawing.Point(139, 115);
			this.chooseTypeSendingCB.Name = "chooseTypeSendingCB";
			this.chooseTypeSendingCB.Size = new System.Drawing.Size(214, 21);
			this.chooseTypeSendingCB.TabIndex = 6;
			this.chooseTypeSendingCB.SelectedIndexChanged += new System.EventHandler(this.chooseTypeSendingCB_SelectedIndexChanged);
			// 
			// chooseSenderSendingCB
			// 
			this.chooseSenderSendingCB.ForeColor = System.Drawing.Color.MidnightBlue;
			this.chooseSenderSendingCB.FormattingEnabled = true;
			this.chooseSenderSendingCB.Location = new System.Drawing.Point(139, 31);
			this.chooseSenderSendingCB.Name = "chooseSenderSendingCB";
			this.chooseSenderSendingCB.Size = new System.Drawing.Size(214, 21);
			this.chooseSenderSendingCB.TabIndex = 7;
			// 
			// chooseRecipientSendingCB
			// 
			this.chooseRecipientSendingCB.ForeColor = System.Drawing.Color.MidnightBlue;
			this.chooseRecipientSendingCB.FormattingEnabled = true;
			this.chooseRecipientSendingCB.Location = new System.Drawing.Point(139, 71);
			this.chooseRecipientSendingCB.Name = "chooseRecipientSendingCB";
			this.chooseRecipientSendingCB.Size = new System.Drawing.Size(214, 21);
			this.chooseRecipientSendingCB.TabIndex = 8;
			// 
			// addBarCodeSendingTB
			// 
			this.addBarCodeSendingTB.ForeColor = System.Drawing.Color.MidnightBlue;
			this.addBarCodeSendingTB.Location = new System.Drawing.Point(139, 156);
			this.addBarCodeSendingTB.MaxLength = 14;
			this.addBarCodeSendingTB.Name = "addBarCodeSendingTB";
			this.addBarCodeSendingTB.Size = new System.Drawing.Size(214, 20);
			this.addBarCodeSendingTB.TabIndex = 9;
			// 
			// addWeightSendingTB
			// 
			this.addWeightSendingTB.ForeColor = System.Drawing.Color.MidnightBlue;
			this.addWeightSendingTB.Location = new System.Drawing.Point(139, 198);
			this.addWeightSendingTB.Name = "addWeightSendingTB";
			this.addWeightSendingTB.Size = new System.Drawing.Size(214, 20);
			this.addWeightSendingTB.TabIndex = 10;
			this.addWeightSendingTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addWeightSendingTB_KeyPress);
			// 
			// addCostSendingTB
			// 
			this.addCostSendingTB.Enabled = false;
			this.addCostSendingTB.ForeColor = System.Drawing.Color.MidnightBlue;
			this.addCostSendingTB.Location = new System.Drawing.Point(139, 235);
			this.addCostSendingTB.Name = "addCostSendingTB";
			this.addCostSendingTB.Size = new System.Drawing.Size(214, 20);
			this.addCostSendingTB.TabIndex = 11;
			// 
			// addSendingBtn
			// 
			this.addSendingBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.addSendingBtn.ForeColor = System.Drawing.Color.MidnightBlue;
			this.addSendingBtn.Location = new System.Drawing.Point(82, 272);
			this.addSendingBtn.Name = "addSendingBtn";
			this.addSendingBtn.Size = new System.Drawing.Size(214, 38);
			this.addSendingBtn.TabIndex = 12;
			this.addSendingBtn.Text = "Добавить";
			this.addSendingBtn.UseVisualStyleBackColor = false;
			this.addSendingBtn.Click += new System.EventHandler(this.addSendingBtn_Click);
			// 
			// percentInfo
			// 
			this.percentInfo.AutoSize = true;
			this.percentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.percentInfo.Location = new System.Drawing.Point(360, 119);
			this.percentInfo.Name = "percentInfo";
			this.percentInfo.Size = new System.Drawing.Size(0, 16);
			this.percentInfo.TabIndex = 13;
			// 
			// AddSending
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SkyBlue;
			this.ClientSize = new System.Drawing.Size(401, 322);
			this.Controls.Add(this.percentInfo);
			this.Controls.Add(this.addSendingBtn);
			this.Controls.Add(this.addCostSendingTB);
			this.Controls.Add(this.addWeightSendingTB);
			this.Controls.Add(this.addBarCodeSendingTB);
			this.Controls.Add(this.chooseRecipientSendingCB);
			this.Controls.Add(this.chooseSenderSendingCB);
			this.Controls.Add(this.chooseTypeSendingCB);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AddSending";
			this.Text = "Отправление";
			this.Load += new System.EventHandler(this.AddSending_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox chooseTypeSendingCB;
        private System.Windows.Forms.ComboBox chooseSenderSendingCB;
        private System.Windows.Forms.ComboBox chooseRecipientSendingCB;
        private System.Windows.Forms.TextBox addBarCodeSendingTB;
        private System.Windows.Forms.TextBox addWeightSendingTB;
        private System.Windows.Forms.TextBox addCostSendingTB;
        private System.Windows.Forms.Button addSendingBtn;
        private System.Windows.Forms.Label percentInfo;
    }
}