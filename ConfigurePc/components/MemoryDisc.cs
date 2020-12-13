class MemoryDisc
{
    public string firm;
    public string type;
    public string modelName;
    public int price;
    public int storageVolume;
    public double capacity;
    public string[] all = new string[6];

    public MemoryDisc(string firm,
                      string type,
                      string modelName,
                      int storageVolume,
                      int price,
                      double capacity)
    {
        this.firm = all[0] = firm;
        this.type = all[1] = type;
        this.modelName = all[2] = modelName;
        this.storageVolume = storageVolume;
        all[3] = storageVolume.ToString();
        this.price = price;
        all[4] = price.ToString();
        this.capacity = capacity;
        all[5] = capacity.ToString();
    }

    public string getStats()
    {
        return string.Join(" ", this.all);
    }
}