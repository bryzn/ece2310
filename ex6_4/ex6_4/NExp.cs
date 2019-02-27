using System;
namespace ex6_4
{
    public class NExp
    {
        public NExp(int x)
        {

            double answer = 1;
            double counter = 1;

            while (counter <= x)
            {
                answer = answer * counter;
                counter++;

            }

            return answer;
        }
    }
    }
}
