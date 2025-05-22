using System.Collections.Generic;

public class BankTransferConfigModel
{
    public string? lang { get; set; }
    public Transfer? transfer { get; set; }
    public List<string>? methods { get; set; }
    public Confirmation? confirmation { get; set; }
}

public class Transfer
{
    public int threshold { get; set; }
    public int low_fee { get; set; }
    public int high_fee { get; set; }
}

public class Confirmation
{
    public string? en { get; set; }
    public string? id { get; set; }
}
