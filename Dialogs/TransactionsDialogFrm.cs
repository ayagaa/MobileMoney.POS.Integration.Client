﻿using MobileMoney.POS.Integration.Client.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WebSocketSharp;

namespace MobileMoney.POS.Integration.Client.Dialogs
{
    public partial class TransactionsDialogFrm : Form
    {
        private readonly string _transactionDetail;
        private readonly string _customerMobileNo;
        private readonly string _transactionAmount;
        private readonly string _transactionRef;
        private WebSocket _webSocketClient;
        private List<string> _transactionLogs;
        public TransactionsDialogFrm(string transactionDetail,
            string customerMobileNo, string transactionAmount, string transactionRef)
        {
            InitializeComponent();
            _transactionDetail = transactionDetail;
            _customerMobileNo = customerMobileNo;
            _transactionAmount = transactionAmount;
            _transactionRef = transactionRef;
            tbxTransactionDescription.Text = _transactionDetail;
            tbxCustomerMobileNo.Text = _customerMobileNo;
            tbxTransactionAmount.Text = _transactionAmount;
            tbxTransactionRef.Text = _transactionRef;
            _transactionLogs = new List<string>();
            listBoxTransactionLogs.DataSource = _transactionLogs;
        }

        private void UpdateLogs()
        {
            Action addLog = () =>
            {
                listBoxTransactionLogs.DataSource = null;
                listBoxTransactionLogs.DataSource = _transactionLogs;
            };

            BeginInvoke(addLog);
        }


        private void initiateTransactionProcessing()
        {
            if (_webSocketClient != null)
            {
                try
                {
                    if (!_webSocketClient.IsAlive)
                        _webSocketClient.Connect();
                    var paymentRequest = new PaymentRequestModel()
                    {
                        Timestamp = DateTime.Now.ToString("yyyyMMddHHmmss"),
                        Amount = _transactionAmount,
                        PhoneNumber = _customerMobileNo,
                        TransactionDesc = _transactionDetail,
                        AccountReference = _transactionRef,
                    };
                    //var test = JsonConvert.DeserializeObject(Json.SerializeResults(paymentRequest));
                    _webSocketClient.Send(JsonConvert.SerializeObject(paymentRequest));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The following error occured: {0}", ex.Message);
                }

                UpdateLogs();
            }
        }
        private void btnProcess_Click(object sender, System.EventArgs e)
        {
            initiateTransactionProcessing();
        }

        private void tblCancel_Click(object sender, System.EventArgs e)
        {

        }

        private void TransactionsDialogFrm_Load(object sender, System.EventArgs e)
        {
            if (_webSocketClient == null)
            {
                _webSocketClient = new WebSocket("ws://localhost:5000/pos");
                _webSocketClient.OnOpen += (snd, eArgs) =>
                {
                    //_transactionLogs.Add("Connected to MPesa transaction server.");
                    UpdateLogs();
                };
                _webSocketClient.OnMessage += (snd, eArgs) =>
                {
                    if (!_webSocketClient.IsAlive)
                        _webSocketClient.Connect();
                    _transactionLogs.Add(eArgs.Data);
                    UpdateLogs();
                    if (eArgs.Data != null && !string.IsNullOrEmpty(eArgs.Data))
                    {
                        if (eArgs.Data.Contains("MPesa Receipt Number:"))
                        {
                            if (MessageBox.Show(eArgs.Data, "Transaction information", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                            {
                                this.Close();
                            }
                        }
                        else if (eArgs.Data.Contains("STK push request FAILED for customer on line") ||
                        eArgs.Data.Contains("Could not get transaction access token."))
                        {
                            if (MessageBox.Show(string.Format("There was an error while processing the transaction. The result reads: {0}. Do you want to retry?", eArgs.Data), "Transaction incomplete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                            {
                                initiateTransactionProcessing();
                            }
                            else
                            {
                                this.Close();
                            }
                        }
                    }
                };
                _webSocketClient.OnClose += (snd, eArgs) =>
                {
                    _transactionLogs.Add("Connection to the server was closed.");
                    UpdateLogs();
                };

                _webSocketClient.Connect();
                UpdateLogs();
            }
        }

        private void TransactionsDialogFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_webSocketClient != null && _webSocketClient.IsAlive)
            {
                _webSocketClient.Close();
            }
        }
    }
}
