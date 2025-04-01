using NBitcoin;
using System;
using WalletBitcoin.classes;

namespace WalletBitcoin
{
    public partial class Form1 : Form
    {
        BitcoinWallet wallet;

        public Form1()
        {
            InitializeComponent();
            //richTextBox1
        }

        static async Task Saldo(string address)
        {
            var api = new BlockCypherApi();
            var addresses = new List<string>
        {
            address,
            address
        };

            try
            {
                var balance = await api.GetWalletBalanceAsync(addresses);
                MessageBox.Show($"Balance: {balance} BTC");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbAddress.Text = "";
            tbKey.Text = "";
            rcbSeed.Text = "";
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbRede.Text))
            {
                if (cbRede.Text == "Mainnet")
                {
                    //var wallet = new BitcoinWallet(Network.Main);
                    wallet = new BitcoinWallet(Network.Main);
                    tbAddress.Text = "";
                    tbKey.Text = "";
                    rcbSeed.Text = "";
                    tbAddress.Text = wallet.GetAddress(1);
                    tbKey.Text = wallet.GetPrivateKey(1) + "";
                    rcbSeed.Text = wallet.GetSeedPhrase().Replace(' ', '\n');
                    MessageBox.Show("Wallet generated on the network: Mainnet");

                    if (!string.IsNullOrWhiteSpace(tbAddress.Text))
                    {
                        btnBalance.Enabled = true;
                    }
                    else
                    {
                        btnBalance.Enabled = false;
                    }
                }
                else if (cbRede.Text == "TestNet")
                {
                    //var wallet = new BitcoinWallet(Network.TestNet);
                    wallet = new BitcoinWallet(Network.TestNet);
                    tbAddress.Text = "";
                    tbKey.Text = "";
                    rcbSeed.Text = "";
                    tbAddress.Text = wallet.GetAddress(0);
                    tbKey.Text = wallet.GetPrivateKey(0) + "";
                    rcbSeed.Text = wallet.GetSeedPhrase().Replace(' ', '\n');
                    MessageBox.Show("Wallet generated on the network: TestNet");
                }

            }
            else
            {
                MessageBox.Show("Choose a network!");
            }
        }

        private void btRecoverClear_Click(object sender, EventArgs e)
        {
            tb01.Text = "";
            tb02.Text = "";
            tb03.Text = "";
            tb04.Text = "";
            tb05.Text = "";
            tb06.Text = "";
            tb07.Text = "";
            tb08.Text = "";
            tb09.Text = "";
            tb10.Text = "";
            tb11.Text = "";
            tb12.Text = "";
            tbRecoverAddress.Text = "";
            tbRecoverKey.Text = "";
        }

        private void btRecover_Click(object sender, EventArgs e)
        {
            string seedPhrase = tb01.Text.Trim() + " " + tb02.Text.Trim() + " " + tb03.Text.Trim() + " " + tb04.Text.Trim() + " " + tb05.Text.Trim() + " " + tb06.Text.Trim() + " " + tb07.Text.Trim() + " " + tb08.Text.Trim() + " " + tb09.Text.Trim() + " " + tb10.Text.Trim() + " " + tb11.Text.Trim() + " " + tb12.Text.Trim();
            try
            {
                wallet = new BitcoinWallet(seedPhrase, Network.Main);
                tbRecoverAddress.Text = wallet.GetAddress(0);
                tbRecoverKey.Text = wallet.GetPrivateKey(0).ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            if (tbAddress.Text == "")
            {
                MessageBox.Show("Address empty!");
            }
            else
            {
                Saldo(tbAddress.Text);
            }
        }

        private void btnRecoverBalance_Click(object sender, EventArgs e)
        {
            if (tbRecoverAddress.Text == "")
            {
                MessageBox.Show("Address empty!");
            }
            else
            {
                Saldo(tbRecoverAddress.Text);
            }
        }
    }
}
