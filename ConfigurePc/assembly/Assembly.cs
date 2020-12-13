using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConfigurePc.storage;

namespace ConfigurePc.assembly
{
    class Assembly
    {
        private double cap = 0;
        private Processor poleProc;
        private Motherboard poleMoth;
        private MemoryDisc poleMem;
        private RandomAccessMemory poleRAM;
        private GraphicsCard poleGCard;
        private PowerSupply polePower;
        private void findProcessor(Processor theorProc)
        {
            foreach (Processor proc in Storage.processors)
            {
                if (proc.coreAmount >= theorProc.coreAmount) &(proc.frequency >= theorProc.frequency) & (poleProc != proc)
                {
                    poleProc = proc;
                    break;
                }

            }
        }



        private void findMother()
        {
            foreach (Motherboard moth in Storage.motherboards)
            {
                if (poleProc.chipset == moth.chipset) &(poleMoth != moth)
                {
                    poleMoth = moth;
                    break;
                }
            }
        }



        private void findMem(MemoryDisc theorMem)
        {
            foreach (MemoryDisc mem in Storage.memorydiscs)
            {
                if (mem.storageVolume >= theorMem.storageVolume) &(poleMem != mem)
                {
                    poleMem = mem;
                    break;
                }
            }
        }


        private void findRAM(RandomAccessMemory theorRam)
        {
            foreach (RandomAccessMemory ram in Storage.randomaccessmemoryes)
            {
                if (ram.memorySize >= theorRam.memorySize) &(ram.MT == poleMoth.supportedMT) & (poleRAM != ram)
                {
                    poleRAM = ram;
                    break;
                }
            }
        }

        private void findGCard(GraphicsCard theorGCard)
        {
            foreach (GraphicsCard GCard in Storage.graphicscards)
            {
                if (GCard.volume >= theorGCard.volume) &(poleGCard != GCard)
                {
                    poleGCard = GCard;
                    break;
                }
            }
        }



        private void findPowerSupply()
        {
            foreach (PowerSupply pow in Storage.powersupplies)
            {
                if (pow.capacity >= cap) &(polePower != pow)
                {
                    polePower = pow;
                    break;
                }
            }
        }

        public void makeAssembly()
        {
            findProcessor();
            cap += poleProc.capacity;
            findMother();
            findMemory();
            cap += poleMem.capacity;
            findRAM();
            findGCard();
            cap += poleGCard.capacity;

            findMem();
            cap += poleMem.capacity;
            findPowerSupply();
        }

        public void remakeAssembly()
        {
            findProcessor();
            cap += poleProc.capacity;
            findMother();
            findMemory();
            cap += poleMem.capacity;
            findRAM();
            findGCard();
            cap += poleGCard.capacity;

            findMem();
            cap += poleMem.capacity;
            findPowerSupply();
        }
    }
}
