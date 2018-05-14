using System;
using System.Collections.Generic;

namespace Change7_1
{
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

        public (int, int) Change(int total, int given)
        {
            if (total > given)
                throw new ArgumentException();

            if (total == given)
                return (0,0);

            var change = given - total;
            int sum = 0;
            int count = 0;

            foreach (var denominator in drawer)
            {
                while (denominator <= change)
                {
                    sum += denominator;
                    count++;
                    change -= denominator;
                }
            }
            return (sum, count);
        }

    }

}
