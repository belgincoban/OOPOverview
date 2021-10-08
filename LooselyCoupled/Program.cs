using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooselyCoupled
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer();
            computer.Disk = new HardDisk();
            computer.Disk = new SSD();
        }
    }
}
