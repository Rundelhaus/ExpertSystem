class Processor
{
    public string firm;
    public string modelName;
    public int price;
    public int frequency;
    public int coresAmount;
    public string socket;
    public double capacity;
    public string[] all = new string[7];

    public Processor(string firm,
                     string modelName,
                     string socket,
                     int frequency,
                     int coresAmount,
                     double capacity,
                     int price)
    {
        this.firm = all[0] = firm;
        this.modelName = all[1] = modelName;
        this.socket = all[2] = socket;
        this.frequency = frequency;
        all[3] = frequency.ToString();
        this.coresAmount = coresAmount;
        all[4] = coresAmount.ToString();
        this.capacity = capacity;
        all[5] = capacity.ToString();
        this.price = price;
        all[6] = price.ToString();
    }

    public string getStats()
    {
        return string.Join(" ", this.all);
    }
}