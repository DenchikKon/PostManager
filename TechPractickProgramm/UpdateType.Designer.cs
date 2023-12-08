namespace TechPractickProgramm
{
    partial class UpdateType
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateType));
			this.updateTypePercentTB = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.updateTypeBtn = new System.Windows.Forms.Button();
			this.updateTypeNameTB = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// updateTypePercentTB
			// 
			this.updateTypePercentTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.updateTypePercentTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.updateTypePercentTB.ForeColor = System.Drawing.Color.MidnightBlue;
			this.updateTypePercentTB.Location = new System.Drawing.Point(22, 100);
			this.updateTypePercentTB.MaxLength = 3;
			this.updateTypePercentTB.Name = "updateTypePercentTB";
			this.updateTypePercentTB.Size = new System.Drawing.Size(249, 22);
			this.updateTypePercentTB.TabIndex = 16;
			this.updateTypePercentTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.updateTypePercentTB_KeyPress);
			// 
			// label17
			// 
			this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label17.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label17.Location = new System.Drawing.Point(111, 75);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(64, 16);
			this.label17.TabIndex = 15;
			this.label17.Text = "Процент";
			// 
			// updateTypeBtn
			// 
			this.updateTypeBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.updateTypeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.updateTypeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.updateTypeBtn.ForeColor = System.Drawing.Color.MidnightBlue;
			this.updateTypeBtn.Location = new System.Drawing.Point(22, 138);
			this.updateTypeBtn.Name = "updateTypeBtn";
			this.updateTypeBtn.Size = new System.Drawing.Size(249, 39);
			this.updateTypeBtn.TabIndex = 13;
			this.updateTypeBtn.Text = "Изменить";
			this.updateTypeBtn.UseVisualStyleBackColor = false;
			this.updateTypeBtn.Click += new System.EventHandler(this.updateTypeBtn_Click);
			// 
			// updateTypeNameTB
			// 
			this.updateTypeNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.updateTypeNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.updateTypeNameTB.ForeColor = System.Drawing.Color.MidnightBlue;
			this.updateTypeNameTB.Location = new System.Drawing.Point(22, 39);
			this.updateTypeNameTB.MaxLength = 50;
			this.updateTypeNameTB.Name = "updateTypeNameTB";
			this.updateTypeNameTB.Size = new System.Drawing.Size(249, 22);
			this.updateTypeNameTB.TabIndex = 14;
			// 
			// label11
			// 
			this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.label11.AutoSize = true;
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label11.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label11.Location = new System.Drawing.Point(111, 14);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(73, 16);
			this.label11.TabIndex = 12;
			this.label11.Text = "Название";
			// 
			// UpdateType
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SkyBlue;
			this.ClientSize = new System.Drawing.Size(292, 198);
			this.Controls.Add(this.updateTypePercentTB);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.updateTypeBtn);
			this.Controls.Add(this.updateTypeNameTB);
			this.Controls.Add(this.label11);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "UpdateType";
			this.Text = "Изменение данных типа";
			this.Load += new System.EventHandler(this.UpdateType_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox updateTypePercentTB;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button updateTypeBtn;
        private System.Windows.Forms.TextBox updateTypeNameTB;
        private System.Windows.Forms.Label label11;
    }
}