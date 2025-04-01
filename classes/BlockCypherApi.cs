using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WalletBitcoin.classes
{
    class BlockCypherApi
    {
        private const string ApiUrl = "https://api.blockcypher.com/v1/btc/main/addrs/";

        /// <summary>
        /// Obtém o saldo total de uma carteira Bitcoin consultando múltiplos endereços via API da BlockCypher.
        /// </summary>
        /// <param name="addresses">Lista de endereços Bitcoin da carteira.</param>
        /// <returns>O saldo total em BTC.</returns>
        public async Task<decimal> GetWalletBalanceAsync(List<string> addresses)
        {
            using (var httpClient = new HttpClient())
            {
                // Junta os endereços com ponto e vírgula para a consulta em lote
                var addressesString = string.Join(";", addresses);
                var response = await httpClient.GetAsync($"{ApiUrl}{addressesString}/balance");
                response.EnsureSuccessStatusCode();
                var json = await response.Content.ReadAsStringAsync();

                // Desserializa a resposta JSON em uma lista de saldos
                var balances = JsonConvert.DeserializeObject<List<Balance>>(json);
                decimal totalBalance = 0;
                foreach (var balance in balances)
                {
                    // Converte de satoshis para BTC
                    //totalBalance += balance.balance / 100000000m;
                    totalBalance = balance.balance / 100000000m;
                    //totalBalance = balance.balance / 2m;
                }
                return totalBalance;
            }
        }
    }
}
