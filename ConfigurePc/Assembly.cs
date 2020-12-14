using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConfigurePc.storage;

class DataScience
{
    public Processor poleProc;
    public Motherboard poleMoth;
    public MemoryDisc poleMem;
    public RandomAccessMemory poleRAM;
    public GraphicsCard poleGCard;
    public DataScience()
    {
        poleProc = new Processor(null, null, null, 2100, 8, 0, 0);
        poleMoth = new Motherboard(null, null, null, null, null, null, 4, 0);
        poleMem = new MemoryDisc(null, null, null, 1000, 0, 0);
        poleRAM = new RandomAccessMemory(null, null, 32, null, 0, 0);
        poleGCard = new GraphicsCard(null, null, 11, 0, 0);
    }
}

class User
{
    public Processor poleProc;
    public Motherboard poleMoth;
    public MemoryDisc poleMem;
    public RandomAccessMemory poleRAM;
    public GraphicsCard poleGCard;
    public User()
    {
        poleProc = new Processor(null, null, null, 2100, 2, 0, 0);
        poleMoth = new Motherboard(null, null, null, null, null, null, 0, 0);
        poleMem = new MemoryDisc(null, null, null, 300, 0, 0);
        poleRAM = new RandomAccessMemory(null, null, 4, null, 0, 0);
        poleGCard = new GraphicsCard(null, null, 0, 0, 0);
    }
}

class Programmer
{
    public Processor poleProc;
    public Motherboard poleMoth;
    public MemoryDisc poleMem;
    public RandomAccessMemory poleRAM;
    public GraphicsCard poleGCard;
    public Programmer()
    {
        poleProc = new Processor(null, null, null, 2100, 4, 0, 0);
        poleMoth = new Motherboard(null, null, null, null, null, null, 0, 0);
        poleMem = new MemoryDisc(null, null, null, 300, 0, 0);
        poleRAM = new RandomAccessMemory(null, null, 8, null, 0, 0);
        poleGCard = new GraphicsCard(null, null, 0, 0, 0);
    }
}

class Gamer
{
    public Processor poleProc;
    public Motherboard poleMoth;
    public MemoryDisc poleMem;
    public RandomAccessMemory poleRAM;
    public GraphicsCard poleGCard;
    public Gamer()
    {
        poleProc = new Processor(null, null, null, 3400, 4, 0, 0);
        poleMoth = new Motherboard(null, null, null, null, null, null, 0, 0);
        poleMem = new MemoryDisc(null, null, "ssd", 500, 0, 0);
        poleRAM = new RandomAccessMemory(null, null, 8, null, 0, 0);
        poleGCard = new GraphicsCard(null, null, 3, 0, 0);
    }

}

class DeathStranding
{
    public Processor poleProc;
    public Motherboard poleMoth;
    public MemoryDisc poleMem;
    public RandomAccessMemory poleRAM;
    public GraphicsCard poleGCard;
    public DeathStranding()
    {
        poleProc = new Processor(null, null, null, 3400, 4, 0, 0);
        poleMoth = new Motherboard(null, null, null, null, null, null, 0, 0);
        poleMem = new MemoryDisc(null, null, "ssd", 500, 0, 0);
        poleRAM = new RandomAccessMemory(null, null, 8, null, 0, 0);
        poleGCard = new GraphicsCard(null, null, 6, 0, 0);
    }

}

class RDR2
{
    public Processor poleProc;
    public Motherboard poleMoth;
    public MemoryDisc poleMem;
    public RandomAccessMemory poleRAM;
    public GraphicsCard poleGCard;
    public RDR2()
    {
        poleProc = new Processor(null, null, null, 3500, 4, 0, 0);
        poleMoth = new Motherboard(null, null, null, null, null, null, 0, 0);
        poleMem = new MemoryDisc(null, null, null, 300, 0, 0);
        poleRAM = new RandomAccessMemory(null, null, 8, null, 0, 0);
        poleGCard = new GraphicsCard(null, null, 6, 0, 0);
    }
}

class Video
{
    public Processor poleProc;
    public Motherboard poleMoth;
    public MemoryDisc poleMem;
    public RandomAccessMemory poleRAM;
    public GraphicsCard poleGCard;
    public Video()
    {
        poleProc = new Processor("Intel", null, null, 2100, 4, 0, 0);
        poleMoth = new Motherboard(null, null, null, null, null, null, 0, 0);
        poleMem = new MemoryDisc(null, null, "ssd", 700, 0, 0);
        poleRAM = new RandomAccessMemory(null, null, 16, null, 0, 0);
        poleGCard = new GraphicsCard(null, null, 4, 0, 0);
    }

}

class DaVinci
{
    public Processor poleProc;
    public Motherboard poleMoth;
    public MemoryDisc poleMem;
    public RandomAccessMemory poleRAM;
    public GraphicsCard poleGCard;
    public DaVinci()
    {
        poleProc = new Processor(null, null, null, 3500, 4, 0, 0);
        poleMoth = new Motherboard(null, null, null, null, null, null, 0, 0);
        poleMem = new MemoryDisc(null, null, "ssd", 700, 0, 0);
        poleRAM = new RandomAccessMemory(null, null, 16, null, 0, 0);
        poleGCard = new GraphicsCard(null, null, 4, 0, 0);
    }

}

class Office
{
    public Processor poleProc;
    public Motherboard poleMoth;
    public MemoryDisc poleMem;
    public RandomAccessMemory poleRAM;
    public GraphicsCard poleGCard;
    public Office()
    {
        poleProc = new Processor(null, null, null, 1600, 4, 0, 0);
        poleMoth = new Motherboard(null, null, null, null, null, null, 4, 0);
        poleMem = new MemoryDisc(null, null, null, 500, 0, 0);
        poleRAM = new RandomAccessMemory(null, null, 4, null, 0, 0);
        poleGCard = new GraphicsCard(null, null, 0, 0, 0);
    }

}

class Photo
{
    public Processor poleProc;
    public Motherboard poleMoth;
    public MemoryDisc poleMem;
    public RandomAccessMemory poleRAM;
    public GraphicsCard poleGCard;
    public Photo()
    {
        poleProc = new Processor(null, null, null, 2100, 0, 0, 0);
        poleMoth = new Motherboard(null, null, null, null, null, null, 0, 0);
        poleMem = new MemoryDisc(null, null, "ssd", 500, 0, 0);
        poleRAM = new RandomAccessMemory(null, null, 16, null, 0, 0);
        poleGCard = new GraphicsCard(null, null, 4, 0, 0);
    }
}

class Assembly
{
    public double cap = 0;
    public Processor poleProc;
    public Motherboard poleMoth;
    public MemoryDisc poleMem;
    public RandomAccessMemory poleRAM;
    public GraphicsCard poleGCard;
    public PowerSupply polePower;

    public int price = 0;


    private void findProcessor(Processor theorProc)
    {
        foreach (Processor proc in Storage.processors)
        {
            if ((proc.coresAmount >= theorProc.coresAmount) && (proc.frequency >= theorProc.frequency))
            {
                poleProc = proc;
                break;
            }
                
        } 
    }

    

    private void findMother(Motherboard theorMoth)
    {
        foreach (Motherboard moth in Storage.motherboards)
        {
            if ((poleProc.socket == moth.socket) && (poleMoth.numberOfSlots >= theorMoth.numberOfSlots))
            {
                poleMoth = moth;
                break;  
            }
        } 
    }

    

    private void findMem(MemoryDisc theorMem)
    {
        foreach (MemoryDisc mem in Storage.memoryDiscs)
        {
            if (( mem.storageVolume >= theorMem.storageVolume))
            {
                poleMem = mem;
                break;  
            }
        } 
    }
    

    private void findRAM(RandomAccessMemory theorRam)
    {
        foreach (RandomAccessMemory ram in Storage.randomAccessMemories)
        {
            if (( ram.memorySize >= theorRam.memorySize) && (ram.MT == poleMoth.supportedMT) )
            {
                poleRAM = ram;
                break;  
            }
        } 
    }

    private void findGCard(GraphicsCard theorGCard)
    {
        foreach (GraphicsCard GCard in Storage.graphicsCards)
        {
            if (( GCard.volume >= theorGCard.volume))
            {
                poleGCard = GCard;
                break;  
            }
        } 
    }



    private void findPowerSupply()
    {
        foreach (PowerSupply pow in Storage.powerSupplies)
        {
            if (pow.capacity >= cap)
            {
                polePower = pow;
                break;
            }
        }
    }

    public void makeAssembly(string purpose)
    {

        if (purpose == "Anaconda") { 
            DataScience ty = new DataScience();
            findProcessor(ty.poleProc);
            cap += poleProc.capacity;
            findMother(ty.poleMoth);
            findMem(ty.poleMem);
            cap += poleMem.capacity;
            findRAM(ty.poleRAM);
            findGCard(ty.poleGCard);
            cap += poleGCard.capacity;
            findPowerSupply();
            price = poleProc.price + poleGCard.price + poleRAM.price + poleMem.price + poleMoth.price + polePower.price;
        }
        else if (purpose == "Photoshop") { 
            Photo ty = new Photo();
            findProcessor(ty.poleProc);
            cap += poleProc.capacity;
            findMother(ty.poleMoth);
            findMem(ty.poleMem);
            cap += poleMem.capacity;
            findRAM(ty.poleRAM);
            findGCard(ty.poleGCard);
            cap += poleGCard.capacity;
            findPowerSupply();
            price = poleProc.price + poleGCard.price + poleRAM.price + poleMem.price + poleMoth.price + polePower.price;
        }
        else if (purpose == "DaVinci") { 
            DaVinci ty = new DaVinci();
            findProcessor(ty.poleProc);
            cap += poleProc.capacity;
            findMother(ty.poleMoth);
            findMem(ty.poleMem);
            cap += poleMem.capacity;
            findRAM(ty.poleRAM);
            findGCard(ty.poleGCard);
            cap += poleGCard.capacity;
            findPowerSupply();
            price = poleProc.price + poleGCard.price + poleRAM.price + poleMem.price + poleMoth.price + polePower.price;
        }
        else if (purpose == "MS Office") { 
            Office ty = new Office();
            findProcessor(ty.poleProc);
            cap += poleProc.capacity;
            findMother(ty.poleMoth);
            findMem(ty.poleMem);
            cap += poleMem.capacity;
            findRAM(ty.poleRAM);
            findGCard(ty.poleGCard);
            cap += poleGCard.capacity;
            findPowerSupply();
            price = poleProc.price + poleGCard.price + poleRAM.price + poleMem.price + poleMoth.price + polePower.price;
        }
        else if (purpose == "рядовой пользователь") { 
            User ty = new User();
            findProcessor(ty.poleProc);
            cap += poleProc.capacity;
            findMother(ty.poleMoth);
            findMem(ty.poleMem);
            cap += poleMem.capacity;
            findRAM(ty.poleRAM);
            findGCard(ty.poleGCard);
            cap += poleGCard.capacity;
            findPowerSupply();
            price = poleProc.price + poleGCard.price + poleRAM.price + poleMem.price + poleMoth.price + polePower.price;
        }
        else if (purpose == "программист") { 
            Programmer ty = new Programmer();
            findProcessor(ty.poleProc);
            cap += poleProc.capacity;
            findMother(ty.poleMoth);
            findMem(ty.poleMem);
            cap += poleMem.capacity;
            findRAM(ty.poleRAM);
            findGCard(ty.poleGCard);
            cap += poleGCard.capacity;
            findPowerSupply();
            price = poleProc.price + poleGCard.price + poleRAM.price + poleMem.price + poleMoth.price + polePower.price;
        }
        else if (purpose == "датасайнтист") { 
            DataScience ty = new DataScience();
            findProcessor(ty.poleProc);
            cap += poleProc.capacity;
            findMother(ty.poleMoth);
            findMem(ty.poleMem);
            cap += poleMem.capacity;
            findRAM(ty.poleRAM);
            findGCard(ty.poleGCard);
            cap += poleGCard.capacity;
            findPowerSupply();
            price = poleProc.price + poleGCard.price + poleRAM.price + poleMem.price + poleMoth.price + polePower.price;
        }
        else if (purpose == "фоторедактор/художник") { 
            Photo ty = new Photo();
            findProcessor(ty.poleProc);
            cap += poleProc.capacity;
            findMother(ty.poleMoth);
            findMem(ty.poleMem);
            cap += poleMem.capacity;
            findRAM(ty.poleRAM);
            findGCard(ty.poleGCard);
            cap += poleGCard.capacity;
            findPowerSupply();
            price = poleProc.price + poleGCard.price + poleRAM.price + poleMem.price + poleMoth.price + polePower.price;
        }
        else if (purpose == "DEATH STRANDING") {
            DeathStranding ty = new DeathStranding();
            findProcessor(ty.poleProc);
            cap += poleProc.capacity;
            findMother(ty.poleMoth);
            findMem(ty.poleMem);
            cap += poleMem.capacity;
            findRAM(ty.poleRAM);
            findGCard(ty.poleGCard);
            cap += poleGCard.capacity;
            findPowerSupply();
            price = poleProc.price + poleGCard.price + poleRAM.price + poleMem.price + poleMoth.price + polePower.price;
        }
        else if (purpose == "Red Dead Redemption 2") { 
            RDR2 ty = new RDR2();
            findProcessor(ty.poleProc);
            cap += poleProc.capacity;
            findMother(ty.poleMoth);
            findMem(ty.poleMem);
            cap += poleMem.capacity;
            findRAM(ty.poleRAM);
            findGCard(ty.poleGCard);
            cap += poleGCard.capacity;
            findPowerSupply();
            price = poleProc.price + poleGCard.price + poleRAM.price + poleMem.price + poleMoth.price + polePower.price;
        }
    }
}