using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankAppCore.Models;
using BankAppCore.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace BankAppUI
{
    public partial class CreateAccount : Form
    {
        private readonly IAccount _account;
        private readonly IUtilities _utility;
        private readonly IServiceProvider _serviceProvider;
        public CreateAccount(IAccount account, IUtilities utilities, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _account = account;
            _utility = utilities;
            _serviceProvider = serviceProvider;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            Accounts account = new Accounts()
            {
                AccountNumber = _utility.GenerateRandom(10),
                AccountType = rdbSaving.Checked ? "Savings" : "Current",
                Balance = Convert.ToDouble(txtInitailAmt.Text),
                UserId = users.Id
            };

            try
            {
                bool check = await _account.AddAccount(account);
                MessageBox.Show($"Account Added Successfully!! Your account number is {account.AccountNumber}");
                this.Hide();
                Customer customer = _serviceProvider.GetRequiredService<Customer>();
                customer.Show();
                customer.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
