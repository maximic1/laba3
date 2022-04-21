using System;
using RabClass;

namespace TestClass
{
    class Program
    {
        static void MaxMeaning()
        {
            RabClass.RabClass Class = new RabClass.RabClass();
            double Otv_1 = Class.Rab(1835800, 2333500, 1.21, 34767, 23432, 5574345);
        }
        static void ZeroMeaning()
        {
            RabClass.RabClass Class = new RabClass.RabClass();
            double Otv_1 = Class.Rab(0, 0, 0, 0, 0, 0);
        }
        static void OneZeroMeaning()
        {
            RabClass.RabClass Class = new RabClass.RabClass();
            double Otv_1 = Class.Rab(10, 0, 1.9, 7, 2, 5);
        }
        static void NegativeMeaning()
        {
            RabClass.RabClass Class = new RabClass.RabClass();
            double Otv_1 = Class.Rab(-20, -6, -2.9, -17, -2, -25);
        }
        static void OneNegativeMeaning()
        {
            RabClass.RabClass Class = new RabClass.RabClass();
            double Otv_1 = Class.Rab(22, 16, -2.9, 12, 5, 2);
        }
        static void Symbols()
        {
            RabClass.RabClass Class = new RabClass.RabClass();
            double Otv_1 = Class.Rab(100, 116, f, 1, 15, 23);
        }
        static void SmallMeaning()
        {
            RabClass.RabClass Class = new RabClass.RabClass();
            double Otv_1 = Class.Rab(0.0000012, 0.0000000016, 0.0000009, 0.000000012, 0.000000005, 0.000000002);
        }
        static void NormalInput()
        {
            RabClass.RabClass Class = new RabClass.RabClass();
            double Otv_1 = Class.Rab(22, 16, 2.9, 12, 5, 2);
        }
        static void DoNotInputMeaning()
        {
            RabClass.RabClass Class = new RabClass.RabClass();
            double Otv_1 = Class.Rab(, , , , , );
        }
        static void DoNotInputOneMeaning()
        {
            RabClass.RabClass Class = new RabClass.RabClass();
            double Otv_1 = Class.Rab(22, 16, , 12, 5, 2);
        }
    }
}
