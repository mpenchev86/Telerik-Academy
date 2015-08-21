using System;

namespace Phone
{
    class GSMTest
    {
        public void TestGSMs()
        {
            GSM[] testGSMs = new GSM[3];
            testGSMs[0] = new GSM("Sprint", "Samsung");
            testGSMs[1] = new GSM("One (M8)", "HTC", new Battery("", 496, 20, BatteryType.LiPo));
            testGSMs[2] = new GSM(
                "Lumia 638", "Nokia", 192.00, "Pesho Goshov", new Battery("", BatteryType.LiIon), 
                new Display(4.5));
            foreach (GSM gsm in testGSMs)
            {
                gsm.ToString();
            }
            GSM.IPhone4S.ToString();
        }
    }
}
