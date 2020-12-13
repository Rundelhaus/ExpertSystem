class RandomAccessMemory
{
    public string firm;
    public string modelName;
    public int price;
    public string MT;
    public int memorySize;
    public double capacity;
    public string[] all = new string[6];


    public RandomAccessMemory(string firm,
                              string modelName,
                              int memorySize,
                              string MT,
                              double capacity,
                              int price)
    {
        this.firm = all[0] = firm;
        this.modelName = all[1] = modelName;
        this.memorySize = memorySize;
        all[2] = memorySize.ToString();
        this.MT = all[3] = MT;
        this.capacity = capacity;
        all[4] = capacity.ToString();
        this.price = price;
        all[5] = price.ToString();
    }

    public string getStats()
    {
        return string.Join(" ", this.all);
    }
}