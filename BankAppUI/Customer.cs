using System;
using System.Windows.Forms;
using BankAppCore.Interfaces;
using BankAppCore.Models;
using Microsoft.Extensions.DependencyInjection;

namespace BankAppUI
{
    public partial class Customer : Form
    {
        private readonly IAccount _account;
        private readonly IServiceProvider _serviceProvider;
        private readonly IAccountOperation _accountOperation;
        public Customer(IAccount account, IServiceProvider serviceProvider, IAccountOperation accountOperation)
        {
            InitializeComponent();
            _account = account;
            _serviceProvider = serviceProvider;           
            _accountOperation = accountOperation;
        }

        private async void Customer_Load(object sender, EventArgs e)
        {
            Users user = new Users();
            try
            {
                lblWelcome.Text = $"Welcome {user.FullName}";
                var accounts = await _account.GetAllAccountByAUser(user.Id);
                if (accounts != null)
                {
                    foreach (var item in accounts)
                    {
                        cmbAccountNum.Items.Add(item.AccountNumber);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void cmbAccountNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selected = cmbAccountNum.Text;
                var account = await _account.GetAccountDetails(selected);

                if (account != null)
                {
                    rtbBalance.Text = account.Balance.ToString();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            CreateAccount account = _serviceProvider.GetRequiredService<CreateAccount>();
            account.ShowDialog();           
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnDeposit_Click(object sender, EventArgs e)
        {
            if (cmbAccountNum.Text != "" && txtAmount.Text != "")
            {
                bool check = await _accountOperation.Deposit(cmbAccountNum.Text, txtAmount.Text);
                if (check)
                {
                    MessageBox.Show("Deposit successful!");
                }
                else
                {
                    MessageBox.Show("Error Occured!");
                }


            }
            else
            {
                MessageBox.Show("One of your input is empty.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAmount.Text = "";
        }

        private async void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (cmbAccountNum.Text != "" && txtAmount.Text != "")
            {
                bool check = await _accountOperation.Withdraw(cmbAccountNum.Text, txtAmount.Text);
                if (check)
                {
                    MessageBox.Show("Withdrawal successful!!");
                }
                else
                {
                    MessageBox.Show("Insufficient Funds!");
                }
            }
            else
            {
                MessageBox.Show("Please select an account number");
            }
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            AccountStatement account = _serviceProvider.GetRequiredService<AccountStatement>();
            account.ShowDialog();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            Transfer transfer = _serviceProvider.GetRequiredService<Transfer>();
            transfer.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Home fm = _serviceProvider.GetRequiredService<Home>();
            fm.Show();
        }

        private void txtAmount_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
