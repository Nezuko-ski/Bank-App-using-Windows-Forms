
namespace BankAppUI
{
    partial class AccountStatement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountStatement));
            this.lblChoose = new System.Windows.Forms.Label();
            this.cmbChooseAccount = new System.Windows.Forms.ComboBox();
            this.dgAccountStatement = new System.Windows.Forms.DataGridView();
            this.AccNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemainBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccountStatement)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChoose
            // 
            this.lblChoose.AutoSize = true;
            this.lblChoose.BackColor = System.Drawing.Color.Transparent;
            this.lblChoose.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblChoose.ForeColor = System.Drawing.Color.White;
            this.lblChoose.Location = new System.Drawing.Point(134, 29);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(210, 26);
            this.lblChoose.TabIndex = 0;
            this.lblChoose.Text = "Choose Account";
            this.lblChoose.Click += new System.EventHandler(this.lblChoose_Click);
            // 
            // cmbChooseAccount
            // 
            this.cmbChooseAccount.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbChooseAccount.FormattingEnabled = true;
            this.cmbChooseAccount.Location = new System.Drawing.Point(389, 29);
            this.cmbChooseAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbChooseAccount.Name = "cmbChooseAccount";
            this.cmbChooseAccount.Size = new System.Drawing.Size(222, 28);
            this.cmbChooseAccount.TabIndex = 1;
            this.cmbChooseAccount.SelectedIndexChanged += new System.EventHandler(this.cmbChooseAccount_SelectedIndexChanged);
            // 
            // dgAccountStatement
            // 
            this.dgAccountStatement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAccountStatement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccNo,
            this.Description,
            this.Amount,
            this.RemainBalance,
            this.Date});
            this.dgAccountStatement.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgAccountStatement.Location = new System.Drawing.Point(134, 70);
            this.dgAccountStatement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgAccountStatement.Name = "dgAccountStatement";
            this.dgAccountStatement.RowHeadersWidth = 51;
            this.dgAccountStatement.RowTemplate.Height = 29;
            this.dgAccountStatement.Size = new System.Drawing.Size(615, 368);
            this.dgAccountStatement.TabIndex = 2;
            // 
            // AccNo
            // 
            this.AccNo.HeaderText = "Account Number";
            this.AccNo.MinimumWidth = 6;
            this.AccNo.Name = "AccNo";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.Width = 200;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.Width = 80;
            // 
            // RemainBalance
            // 
            this.RemainBalance.HeaderText = "Balance";
            this.RemainBalance.MinimumWidth = 6;
            this.RemainBalance.Name = "RemainBalance";
            this.RemainBalance.Width = 80;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            // 
            // AccountStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(902, 449);
            this.Controls.Add(this.dgAccountStatement);
            this.Controls.Add(this.cmbChooseAccount);
            this.Controls.Add(this.lblChoose);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AccountStatement";
            this.Text = "AccountStatement";
            this.Load += new System.EventHandler(this.AccountStatement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAccountStatement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChoose;
        private System.Windows.Forms.ComboBox cmbChooseAccount;
        private System.Windows.Forms.DataGridView dgAccountStatement;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemainBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}