using NBitcoin;
using System;
using System.Threading.Tasks;

public class BitcoinWallet
{
    private readonly Network _network;
    private readonly ExtKey _masterKey;
    private readonly Mnemonic _mnemonic;

    // Construtor para criar nova carteira
    public BitcoinWallet(Network network = null)
    {
        _network = network ?? Network.Main; // Default para Mainnet
        _mnemonic = new Mnemonic(Wordlist.English, WordCount.Twelve); // Gera frase de 12 palavras
        _masterKey = _mnemonic.DeriveExtKey();
    }

    // Construtor para recuperar carteira existente
    public BitcoinWallet(string mnemonicPhrase, Network network = null)
    {
        _network = network ?? Network.Main; // Default para Mainnet
        _mnemonic = new Mnemonic(mnemonicPhrase, Wordlist.English);
        _masterKey = _mnemonic.DeriveExtKey();
    }

    // Obtém a frase secreta (seed phrase)
    public string GetSeedPhrase()
    {
        return _mnemonic.ToString();
    }

    // Gera um endereço Bitcoin (derivado do caminho BIP-44: m/44'/0'/0'/0/index)
    public string GetAddress(int index = 0)
    {
        var keyPath = new KeyPath($"m/44'/0'/0'/0/{index}");
        var privateKey = _masterKey.Derive(keyPath).PrivateKey;
        return privateKey.PubKey.GetAddress(ScriptPubKeyType.Legacy, _network).ToString();
    }

    // Obtém a chave privada de um endereço específico
    public BitcoinSecret GetPrivateKey(int index = 0)
    {
        var keyPath = new KeyPath($"m/44'/0'/0'/0/{index}");
        return _masterKey.Derive(keyPath).PrivateKey.GetBitcoinSecret(_network);
    }

    // Consulta o saldo (simulado - requer integração com API real)
    public async Task<Money> GetBalanceAsync(int index = 0)
    {
        // Para produção, use uma API como BlockCypher ou um nó local
        // Aqui é apenas um placeholder
        Console.WriteLine("Consulta de saldo requer integração com API ou nó Bitcoin.");
        return await Task.FromResult(Money.Zero);
    }
    
    // Envia Bitcoin para um endereço
    public Transaction BuildTransaction(string destinationAddress, Money amount, int index = 0)
    {
        var privateKey = GetPrivateKey(index);
        var address = BitcoinAddress.Create(destinationAddress, _network);

        // Placeholder: requer UTXOs reais de uma API ou nó
        var txBuilder = _network.CreateTransactionBuilder();
        var tx = txBuilder
            .AddKeys(privateKey)
            .Send(address, amount)
            .SetChange(privateKey.PubKey.GetAddress(ScriptPubKeyType.Legacy, _network))
            .SendFees(Money.Coins(0.0001m)) // Taxa fixa de exemplo
            .BuildTransaction(sign: true);

        return tx;
    }
}