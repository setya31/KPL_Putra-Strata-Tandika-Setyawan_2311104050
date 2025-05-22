class Program
{
    static void Main(string[] args)
    {
        var config = BankTransferConfig.LoadConfig();

        string message = config.lang == "en"
            ? "Please insert the amount of money to transfer:"
            : "Masukkan jumlah uang yang akan di-transfer:";
        Console.WriteLine(message);

        int amount = int.Parse(Console.ReadLine());
        int fee = amount <= config.transfer.threshold ? config.transfer.low_fee : config.transfer.high_fee;
        int total = amount + fee;

        if (config.lang == "en")
        {
            Console.WriteLine($"Transfer fee = {fee}");
            Console.WriteLine($"Total amount = {total}");
        }
        else
        {
            Console.WriteLine($"Biaya transfer = {fee}");
            Console.WriteLine($"Total biaya = {total}");
        }

        Console.WriteLine(config.lang == "en" ? "Select transfer method:" : "Pilih metode transfer:");
        for (int i = 0; i < config.methods.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {config.methods[i]}");
        }

        Console.Write("=> ");
        Console.ReadLine(); // input pilihan metode (boleh tidak dipakai)

        string confirmPrompt = config.lang == "en"
            ? $"Please type \"{config.confirmation.en}\" to confirm the transaction:"
            : $"Ketik \"{config.confirmation.id}\" untuk mengkonfirmasi transaksi:";
        Console.WriteLine(confirmPrompt);
        string userConfirm = Console.ReadLine();

        bool isConfirmed = (config.lang == "en" && userConfirm == config.confirmation.en)
            || (config.lang == "id" && userConfirm == config.confirmation.id);

        if (isConfirmed)
        {
            Console.WriteLine(config.lang == "en" ? "The transfer is completed" : "Proses transfer berhasil");
        }
        else
        {
            Console.WriteLine(config.lang == "en" ? "Transfer is cancelled" : "Transfer dibatalkan");
        }
    }
}