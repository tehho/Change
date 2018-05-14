using System;
using System.Collections.Generic;

namespace Change
{
    public class ChangeMaker_Tuple
    {
        List<int> drawer;

        public ChangeMaker_Tuple()
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

        public Tuple<int, int> Change(int total, int given)
        {
            if (total > given)
                throw new ArgumentException();
            
            if (total == given)
                return new Tuple<int, int>(0, 0);

            var change = given - total;

            int sum = 0;
            int count = 0;

            foreach(var denominator in drawer)
            {
                while(denominator <= change)
                {
                    sum += denominator;
                    count++;
                    change -= denominator;
                }
            }
            return new Tuple<int, int>(sum, count);
        }
    }
}
