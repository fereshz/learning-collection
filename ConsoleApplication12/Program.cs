namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.ArrayList oList = new System.Collections.ArrayList();
            int[] x = new int[5];
            oList.Add(7);
            oList.Add(21);
            oList.Add(5);
            oList.Insert(1, 7);
            oList.Insert(2, 4);
            oList.Insert(3, 3);
            oList.Insert(4, 7);
            oList.Remove(8);

            foreach (int intCurrent in oList)
            {
                System.Console.WriteLine(intCurrent);
            }
            System.Console.ReadLine();




            while (oList.Contains(7))
            {
                oList.Remove(7);
            }

            foreach (int i in oList)
            {
                System.Console.WriteLine(i);
            }

            //for (int intIndex = 0; intIndex <= oList.Count - 1; intIndex++)
            //{

            //    if (oList.Contains(7))
            //    {
            //        oList.Remove(7);
            //    }
            //    System.Console.WriteLine(oList[intIndex]);

            //}


            System.Console.ReadLine();

            //int[] y = { 22, 3, 6, 3, 14, 2,3, 7 };
            //for (int i = 0; i < y.Length; i++)
            //{
            //    if (y[i]==3)
            //    {
            //        System.Console.WriteLine("yes");
            //    }
            //}

            //System.Console.ReadLine();
        }
    }
}