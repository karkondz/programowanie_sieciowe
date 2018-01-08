using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRC2
{
    class Program
    {
        static void Main(string[] args)
        {
            short result =0, final_res=0, CRC_div;
            short[] data = new short[] { 38 };
            CRC_div = 0xA;
            
            int CRC_div_len = 4;
            result = 0;
            
            foreach (var item in data)
            {

 
                result ^= item;
                for (int i = 0; i < 8 + CRC_div_len - 1; i++)
                {
                    if ((result & 1) > 0)
                    {
                        result = (short)(result ^ CRC_div);
                    }
                    result >>= 1;
                    
                }
            }
           
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
