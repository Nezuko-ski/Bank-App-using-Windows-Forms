
namespace BankAppUI
{
    partial class Transfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transfer));
            this.lblSender = new System.Windows.Forms.Label();
            this.cmbSender = new System.Windows.Forms.ComboBox();
            this.lblReciever = new System.Windows.Forms.Label();
            this.txtReceiver = new System.Windows.Forms.TextBox();
            this.lblTransferAmt = new System.Windows.Forms.Label();
            this.txtTransferAmt = new System.Windows.Forms.TextBox();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSender
            // 
            this.lblSender.AutoSize = true;
            this.lblSender.BackColor = System.Drawing.Color.PaleGreen;
            this.lblSender.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSender.ForeColor = System.Drawing.Color.Black;
            this.lblSender.Location = new System.Drawing.Point(183, 124);
            this.lblSender.Name = "lblSender";
            this.lblSender.Size = new System.Drawing.Size(179, 23);
            this.lblSender.TabIndex = 0;
            this.lblSender.Text = "Select Account:";
            // 
            // cmbSender
            // 
            this.cmbSender.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbSender.FormattingEnabled = true;
            this.cmbSender.Location = new System.Drawing.Point(472, 123);
            this.cmbSender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSender.Name = "cmbSender";
            this.cmbSender.Size = new System.Drawing.Size(224, 28);
            this.cmbSender.TabIndex = 1;
            // 
            // lblReciever
            // 
            this.lblReciever.AutoSize = true;
            this.lblReciever.BackColor = System.Drawing.Color.PaleGreen;
            this.lblReciever.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReciever.ForeColor = System.Drawing.Color.Black;
            this.lblReciever.Location = new System.Drawing.Point(17, 174);
            this.lblReciever.Name = "lblReciever";
            this.lblReciever.Size = new System.Drawing.Size(388, 23);
            this.lblReciever.TabIndex = 2;
            this.lblReciever.Text = "Enter Recipient\'s Account Number:";
            // 
            // txtReceiver
            // 
            this.txtReceiver.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtReceiver.Location = new System.Drawing.Point(472, 171);
            this.txtReceiver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReceiver.Name = "txtReceiver";
            this.txtReceiver.Size = new System.Drawing.Size(224, 29);
            this.txtReceiver.TabIndex = 3;
            // 
            // lblTransferAmt
            // 
            this.lblTransferAmt.AutoSize = true;
            this.lblTransferAmt.BackColor = System.Drawing.Color.PaleGreen;
            this.lblTransferAmt.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTransferAmt.ForeColor = System.Drawing.Color.Black;
            this.lblTransferAmt.Location = new System.Drawing.Point(174, 224);
            this.lblTransferAmt.Name = "lblTransferAmt";
            this.lblTransferAmt.Size = new System.Drawing.Size(211, 23);
            this.lblTransferAmt.TabIndex = 4;
            this.lblTransferAmt.Text = "Enter the Amount:";
            // 
            // txtTransferAmt
            // 
            this.txtTransferAmt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTransferAmt.Location = new System.Drawing.Point(472, 221);
            this.txtTransferAmt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTransferAmt.Name = "txtTransferAmt";
            this.txtTransferAmt.Size = new System.Drawing.Size(224, 29);
            this.txtTransferAmt.TabIndex = 5;
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTransfer.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTransfer.ForeColor = System.Drawing.Color.Red;
            this.btnTransfer.Location = new System.Drawing.Point(550, 288);
            this.btnTransfer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(146, 46);
            this.btnTransfer.TabIndex = 6;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(770, 404);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.txtTransferAmt);
            this.Controls.Add(this.lblTransferAmt);
            this.Controls.Add(this.txtReceiver);
            this.Controls.Add(this.lblReciever);
            this.Controls.Add(this.cmbSender);
            this.Controls.Add(this.lblSender);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Transfer";
            this.Text = "Transfer";
            this.Load += new System.EventHandler(this.Transfer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSender;
        private System.Windows.Forms.ComboBox cmbSender;
        private System.Windows.Forms.Label lblReciever;
        private System.Windows.Forms.TextBox txtReceiver;
        private System.Windows.Forms.Label lblTransferAmt;
        private System.Windows.Forms.TextBox txtTransferAmt;
        private System.Windows.Forms.Button btnTransfer;
    }
}