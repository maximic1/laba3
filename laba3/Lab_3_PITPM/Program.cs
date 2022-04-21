using System;
using RabClass;

namespace Laba_3_PITPM
{
    class Program
    {
        static void Main(string[] args)
        {
            RabClass.RabClass Class = new RabClass.RabClass();
            double Otv_1 = Class.Rab(500, 600, 1.21, 17, 12, 7);
            double Otv_2 = Class.Rab(210, 660, 0.9, 11, 12, 3);
            double Otv_3 = Class.Rab(330, 520, 0.47, 8, 10, 16);
            double Otv = Otv_1 + Otv_2 + Otv_3;

            Console.WriteLine(Otv_1);
            Console.WriteLine(Otv_2);
            Console.WriteLine(Otv_3);
            Console.WriteLine(Otv);
        }
    }
}
