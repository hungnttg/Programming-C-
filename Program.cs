using System;

namespace Sort
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] mang = new int[5] { 4, 5, 1, 2, -1 };
            Console.WriteLine("Before Sort: ");
            for (int l=0;l<5;l++)
            {

                Console.Write(mang[l] + ",");
            }
            //int j = 0;
            for (int j=0;j<4;j++)
            {
                for (int i = j + 1; i >0; i--) 
                {
                    if (mang[i] < mang[i - 1])
                    {
                        int temp = mang[i - 1];
                        mang[i - 1] = mang[i];
                        mang[i] = temp;
                    }
                }
            }
            //in
            Console.WriteLine("After Sort");
            for (int k=0;k<5;k++)
            {

                Console.Write(mang[k] + ",");
            }
        }
    }
}
