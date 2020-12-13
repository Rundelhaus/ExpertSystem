class PowerSupply
{
    public string firm;
    public string modelName;
    public double capacity;
    public int price;
    public string[] all = new string[4];

    public PowerSupply(string firm,
                        string modelName,
                        double capacity,
                        int price)
    {
        this.firm = all[0] = firm;
        this.modelName = all[1] = modelName;
        this.capacity = capacity;
        all[2] = capacity.ToString();
        this.price = price;
        all[3] = price.ToString();
    }

    public string getStats()
    {
        return string.Join(" ", this.all);
    }
}