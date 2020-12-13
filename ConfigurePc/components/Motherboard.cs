class Motherboard
{
    public string firm;
    public string modelName;
    public int price;
    public string formFactor;
    public string socket;
    public string chipset;
    public string supportedMT;
    public int numberOfSlots;
    public string[] all = new string[8];

    public Motherboard(string firm,
                     string formFactor,
                     string modelName,
                     string socket,
                     string chipset,
                     string supportedMT, //тип поддерживаемой озу
                     int numberOfSlots,
                     int price)
    {
        this.formFactor = all[0] = formFactor;
        this.firm = all[1] = firm;
        this.modelName = all[2] = modelName;
        this.socket = all[3] = socket;
        this.chipset = all[4] = chipset;
        this.supportedMT = all[5] = supportedMT;
        this.numberOfSlots = numberOfSlots;
        all[6] = numberOfSlots.ToString();
        this.price = price;
        all[7] = price.ToString();
    }

    public string getStats()
    {
        return string.Join(" ", this.all);
    }
}