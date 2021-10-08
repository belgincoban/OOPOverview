using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooselyCoupled
{
    public class Computer
    {
        public IMemoryUnit Ram { get; set; }
        public IStorageDevice Disk { get; set; }
    }

    //bağlılığı azaltan interface kullanımı

    public interface IMemoryUnit
    {

    }

    public interface IStorageDevice
    {

    }
    public class Ram: IMemoryUnit
    {
        public int Capacity { get; set; }
        public string Vendor { get; set; }
    }

    public class HardDisk:IStorageDevice
    {
        public int RPM { get; set; }
    }

    public class SSD : IStorageDevice
    {

    }
}


