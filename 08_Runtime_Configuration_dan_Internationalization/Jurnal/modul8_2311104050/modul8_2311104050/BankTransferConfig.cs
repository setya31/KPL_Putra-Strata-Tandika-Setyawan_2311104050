using System;
using System.IO;
using System.Text.Json;

public static class BankTransferConfig
{
    private const string configFilePath = "bank_transfer_config.json";

    public static BankTransferConfigModel LoadConfig()
    {
        if (File.Exists(configFilePath))
        {
            string json = File.ReadAllText(configFilePath);
            BankTransferConfigModel? config = JsonSerializer.Deserialize<BankTransferConfigModel>(json);
            if (config != null) return config;
        }

        // Return default config jika file tidak ditemukan atau gagal dibaca
        return new BankTransferConfigModel
        {
            lang = "en",
            transfer = new Transfer
            {
                threshold = 25000000,
                low_fee = 6500,
                high_fee = 15000
            },
            methods = new List<string> { "RTO (real-time)", "SKN", "RTGS", "BI FAST" },
            confirmation = new Confirmation
            {
                en = "yes",
                id = "ya"
            }
        };
    }
}
