using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalletBitcoin.classes
{
    class Balance
    {
        public string address { get; set; }
        public long balance { get; set; } // Saldo em satoshis
    }
}
