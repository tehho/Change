using System;
using System.Collections.Generic;

namespace Change
{
    class Program
    {
        static void Main(string[] args)
        {
        }


    }

    public class ChangeBack
    {
        public int sum;
        public int count;
    }

    public class ChangeMaker
    {
        List<int> drawer;

        public ChangeMaker()
        {
            drawer = new List<int>()
            {
                500,
                200,
                100,
                50,
                10,
                5,
                2,
                1
            };
        }

        public int Change(int total, int given)
        {
            if(total == given)
                return 0;

            if (total > given)
                throw new ArgumentException();
            int sum = 0;
            int count = 0;
            foreach(var denominator in drawer)
            {
                while(denominator < given)
                {

                }
            }
        }
    }
}
