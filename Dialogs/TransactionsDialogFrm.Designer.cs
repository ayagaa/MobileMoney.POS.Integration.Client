namespace MobileMoney.POS.Integration.Client.Dialogs
{
    partial class TransactionsDialogFrm
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
            this.lblTransactionDesc = new System.Windows.Forms.Label();
            this.tbxTransactionDescription = new System.Windows.Forms.TextBox();
            this.tbxCustomerMobileNo = new System.Windows.Forms.TextBox();
            this.lblCustomerMobileNo = new System.Windows.Forms.Label();
            this.tbxTransactionRef = new System.Windows.Forms.TextBox();
            this.lblTransactionRef = new System.Windows.Forms.Label();
            this.tbxTransactionAmount = new System.Windows.Forms.TextBox();
            this.lblTransactionAmount = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.listBoxTransactionLogs = new System.Windows.Forms.ListBox();
            this.lblTransactionLog = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTransactionDesc
            // 
            this.lblTransactionDesc.AutoSize = true;
            this.lblTransactionDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionDesc.Location = new System.Drawing.Point(47, 28);
            this.lblTransactionDesc.Name = "lblTransactionDesc";
            this.lblTransactionDesc.Size = new System.Drawing.Size(188, 20);
            this.lblTransactionDesc.TabIndex = 0;
            this.lblTransactionDesc.Text = "Transaction Description";
            // 
            // tbxTransactionDescription
            // 
            this.tbxTransactionDescription.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbxTransactionDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTransactionDescription.Location = new System.Drawing.Point(44, 55);
            this.tbxTransactionDescription.Name = "tbxTransactionDescription";
            this.tbxTransactionDescription.Size = new System.Drawing.Size(773, 38);
            this.tbxTransactionDescription.TabIndex = 1;
            // 
            // tbxCustomerMobileNo
            // 
            this.tbxCustomerMobileNo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbxCustomerMobileNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCustomerMobileNo.Location = new System.Drawing.Point(44, 154);
            this.tbxCustomerMobileNo.Name = "tbxCustomerMobileNo";
            this.tbxCustomerMobileNo.Size = new System.Drawing.Size(241, 38);
            this.tbxCustomerMobileNo.TabIndex = 3;
            // 
            // lblCustomerMobileNo
            // 
            this.lblCustomerMobileNo.AutoSize = true;
            this.lblCustomerMobileNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerMobileNo.Location = new System.Drawing.Point(47, 127);
            this.lblCustomerMobileNo.Name = "lblCustomerMobileNo";
            this.lblCustomerMobileNo.Size = new System.Drawing.Size(166, 20);
            this.lblCustomerMobileNo.TabIndex = 2;
            this.lblCustomerMobileNo.Text = "Customer Mobile No.";
            // 
            // tbxTransactionRef
            // 
            this.tbxTransactionRef.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbxTransactionRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTransactionRef.Location = new System.Drawing.Point(309, 154);
            this.tbxTransactionRef.Name = "tbxTransactionRef";
            this.tbxTransactionRef.Size = new System.Drawing.Size(241, 38);
            this.tbxTransactionRef.TabIndex = 5;
            // 
            // lblTransactionRef
            // 
            this.lblTransactionRef.AutoSize = true;
            this.lblTransactionRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionRef.Location = new System.Drawing.Point(312, 127);
            this.lblTransactionRef.Name = "lblTransactionRef";
            this.lblTransactionRef.Size = new System.Drawing.Size(128, 20);
            this.lblTransactionRef.TabIndex = 4;
            this.lblTransactionRef.Text = "Transaction Ref";
            // 
            // tbxTransactionAmount
            // 
            this.tbxTransactionAmount.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbxTransactionAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTransactionAmount.Location = new System.Drawing.Point(576, 154);
            this.tbxTransactionAmount.Name = "tbxTransactionAmount";
            this.tbxTransactionAmount.Size = new System.Drawing.Size(241, 38);
            this.tbxTransactionAmount.TabIndex = 7;
            // 
            // lblTransactionAmount
            // 
            this.lblTransactionAmount.AutoSize = true;
            this.lblTransactionAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionAmount.Location = new System.Drawing.Point(579, 127);
            this.lblTransactionAmount.Name = "lblTransactionAmount";
            this.lblTransactionAmount.Size = new System.Drawing.Size(159, 20);
            this.lblTransactionAmount.TabIndex = 6;
            this.lblTransactionAmount.Text = "Transaction Amount";
            // 
            // btnProcess
            // 
            this.btnProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.Location = new System.Drawing.Point(331, 600);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(310, 46);
            this.btnProcess.TabIndex = 0;
            this.btnProcess.Text = "Process MPesa Transaction";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(662, 600);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(156, 46);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // listBoxTransactionLogs
            // 
            this.listBoxTransactionLogs.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listBoxTransactionLogs.CausesValidation = false;
            this.listBoxTransactionLogs.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listBoxTransactionLogs.FormattingEnabled = true;
            this.listBoxTransactionLogs.ItemHeight = 16;
            this.listBoxTransactionLogs.Location = new System.Drawing.Point(44, 260);
            this.listBoxTransactionLogs.Name = "listBoxTransactionLogs";
            this.listBoxTransactionLogs.Size = new System.Drawing.Size(773, 324);
            this.listBoxTransactionLogs.TabIndex = 8;
            this.listBoxTransactionLogs.TabStop = false;
            this.listBoxTransactionLogs.UseTabStops = false;
            // 
            // lblTransactionLog
            // 
            this.lblTransactionLog.AutoSize = true;
            this.lblTransactionLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionLog.Location = new System.Drawing.Point(47, 237);
            this.lblTransactionLog.Name = "lblTransactionLog";
            this.lblTransactionLog.Size = new System.Drawing.Size(130, 20);
            this.lblTransactionLog.TabIndex = 9;
            this.lblTransactionLog.Text = "Transaction Log";
            // 
            // TransactionsDialogFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 658);
            this.Controls.Add(this.lblTransactionLog);
            this.Controls.Add(this.listBoxTransactionLogs);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.tbxTransactionAmount);
            this.Controls.Add(this.lblTransactionAmount);
            this.Controls.Add(this.tbxTransactionRef);
            this.Controls.Add(this.lblTransactionRef);
            this.Controls.Add(this.tbxCustomerMobileNo);
            this.Controls.Add(this.lblCustomerMobileNo);
            this.Controls.Add(this.tbxTransactionDescription);
            this.Controls.Add(this.lblTransactionDesc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "TransactionsDialogFrm";
            this.Text = "MPesa Transaction";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TransactionsDialogFrm_FormClosing);
            this.Load += new System.EventHandler(this.TransactionsDialogFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTransactionDesc;
        private System.Windows.Forms.TextBox tbxTransactionDescription;
        private System.Windows.Forms.TextBox tbxCustomerMobileNo;
        private System.Windows.Forms.Label lblCustomerMobileNo;
        private System.Windows.Forms.TextBox tbxTransactionRef;
        private System.Windows.Forms.Label lblTransactionRef;
        private System.Windows.Forms.TextBox tbxTransactionAmount;
        private System.Windows.Forms.Label lblTransactionAmount;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox listBoxTransactionLogs;
        private System.Windows.Forms.Label lblTransactionLog;
    }
}