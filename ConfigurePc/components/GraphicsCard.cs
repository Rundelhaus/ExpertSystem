class GraphicsCard
{
    public string firm;
    public string modelName;
    public double volume;
    public int price;
    public double capacity;
    public string[] all = new string[5];

    public GraphicsCard(string firm,
                        string modelName,
                        double volume,
                        double capacity,
                        int price)
    {
        this.firm = all[0] = firm;
        this.modelName = all[1] = modelName;
        this.volume = volume;
        all[2] = volume.ToString();
        this.capacity = capacity;
        all[3] = capacity.ToString();
        this.price = price;
        all[4] = price.ToString();
    }

    public string getStats()
    {
        return string.Join(" ", this.all);
    }
}