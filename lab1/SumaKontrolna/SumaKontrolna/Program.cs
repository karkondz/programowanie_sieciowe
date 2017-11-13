using System;

namespace ConsoleApplication
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            byte nowa=5;
            byte m;
            byte b=0;
            byte a = 0;
            byte[] tab = new byte[] {0, 1, 1, 0, 1, 0, 1, 0, 0};
           // char[] tab2 = new char[] {'a', 'b'};

           // Console.WriteLine(nowa);

          //  for (int i = 0; i < 1; i++)
           // {
                foreach(var v in tab){

                for (int j = 1; j < 8; j++)
                {
                    m = (byte)(1 << (j-1));

                    b=(byte)(Convert.ToByte(Convert.ToBoolean(v) & Convert.ToBoolean(m))>> (j-1));
                    //b=nowa & m;

                    a ^= b;
                
                
                }
            }
            Console.WriteLine(a);

        }
    }
}