using System;
using System.Collections.Generic;

namespace Change
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

        public ChangeBack Change(int total, int given)
        {
            if (total > given)
                throw new ArgumentException();

            var returnValue = new ChangeBack();
            if (total == given)
                return returnValue;

            var change = given - total;

            foreach(var denominator in drawer)
            {
                while(denominator <= change)
                {
                    returnValue.sum += denominator;
                    returnValue.count++;
                    change -= denominator;
                }
            }
            return returnValue;
        }
    }
}
