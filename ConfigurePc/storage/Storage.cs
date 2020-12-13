using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigurePc.storage
{
    class Storage
    {  
       public static GraphicsCard[] graphicsCards = 
       { 
           new GraphicsCard("MSI", "GeForce GT 710 Silent LP", 1, 19, 2850), 
           new GraphicsCard("PowerColor", "GeForce GTX 1050 Ti", 2, 75, 5799),
           new GraphicsCard("Gigabyte", "AMD Radeon RX 550 Red Dragon", 4, 50, 11899),
           new GraphicsCard("MSI", "GeForce GTX 1650 GAMING X", 4, 75, 14299),
           new GraphicsCard("ASUS", "GeForce GTX 1660 SUPER TUF GAMING X3", 6, 125, 26999),
           new GraphicsCard("GigaByte", "GeForce GT 730 LP", 2, 25, 5050)
       };

       public static MemoryDisc[] memoryDiscs =
       {
            new MemoryDisc("Seagate", "HDD", "BLUE", 1000, 3199, 6.8),
            new MemoryDisc("WD", "HDD", "SkyHawk", 1000, 4250, 5.6),
            new MemoryDisc("Toshiba", "HDD", "N300", 16000, 31999, 6.91),
            new MemoryDisc("Apacer", "SSD", "AS350 PANTHER", 128, 1750, 0),
            new MemoryDisc("Goodram", "SSD", "CX400", 512, 4550, 0),
            new MemoryDisc("Smartbuy", "SSD", "Revival 3", 960, 8199, 0),
       };

        public static Motherboard[] motherboards =
        {
            new Motherboard( "GIGABYTE", "Standard-ATX", "X570 AORUS MASTER", "AM4", "AMD X570", "DDR4", 4, 31999),
            new Motherboard( "Micro-ATX", "MSI", "MAG B550M MORTAR", "AM4", "AMD B550", "DDR4", 4, 12499),
            new Motherboard( "Standard-ATX", "ASUS", "PRIME B460-PLUS", "LGA 1200", "Intel B460", "DDR4", 4, 9499),
            new Motherboard( "Micro-ATX", "ASRock", "B550M-HDV", "AM4", "AMD B550", "DDR4", 2, 6550),
            new Motherboard( "Micro-ATX", "ASUS", "H110M-R/C/SI", "LGA 1151", "Intel H110", "DDR4", 4, 4399),
            new Motherboard( "Micro-ATX", "Biostar", "H110MDE", "LGA 1151", "Intel H110", "DDR4", 2, 3699),
        };

        public static PowerSupply[] powerSupplies =
        {
            new PowerSupply( "HIPER", "HP-250SFX", 250, 1399),
            new PowerSupply( "Xilence", "Red Wings XN051", 400, 1899),
            new PowerSupply( "Aerocool", "ECO", 600, 2399),
            new PowerSupply( "Zalman", "WATTBIT 400W", 400, 2499),
            new PowerSupply( "Chieftec", "TFX 300W", 300, 2899),
            new PowerSupply( "Xilence", "Gaming series XN240", 850, 6899)
        };

        public static Processor[] processors =
        {
            new Processor("Intel", "Celeron G4930", "LGA 1151-v2", 3200, 2, 54, 3050),
            new Processor("AMD", "Athlon 200GE OEM", "AM4", 3200, 2, 59, 3299),
            new Processor("Intel", "Pentium Gold G5420", "LGA 1151-v2", 3800, 4, 54, 6199),
            new Processor("Intel", "Pentium Gold G6500", "LGA 1200", 4100, 2, 58, 7150),
            new Processor("Intel", "Core i3-10100F", "LGA 1200", 3600, 4, 65, 7299),
            new Processor("AMD", "Ryzen 7 3700X", "AM4", 3600, 8, 65, 28999)
        };

        public static RandomAccessMemory[] randomAccessMemories =
        {
            new RandomAccessMemory( "Patriot", "Signature", 2, "DDR2", 1.8, 1350),
            new RandomAccessMemory( "AMD", "Radeon R7 Performance Series", 4, "DDR4", 1.2, 1350),
            new RandomAccessMemory( "Kingston", "HyperX FURY Blue Series", 4, "DDR3", 1.5, 1899),
            new RandomAccessMemory( "Samsung", "M378A1K43DB2-CTD", 8, "DDR4", 1.2, 2699),
            new RandomAccessMemory( "Transcend", "JetRam", 8, "DDR4", 1.2, 2699),
            new RandomAccessMemory( "A-Data", "XPG Gammix D10", 16, "DDR4", 1.35, 5299)
        };
    }
    
}
