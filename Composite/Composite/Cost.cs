using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Cost
    {
        public TimeSpan Time { get; set; }
        public decimal Money { get; set; }

        public Cost(TimeSpan time, decimal money = 0)
        {
            Time = time;
            Money = money;
        }

        public Cost()
        {
            Time = new TimeSpan(0);
            Money = 0;
        }

        public override string ToString()
        {
            return $"{{Time: {Time.ToString()}, Money: {Money.ToString()}}}";
        }

        public static Cost operator +(Cost a, Cost b) => new Cost(a.Time + b.Time, a.Money + b.Money);
        public static Cost operator -(Cost a, Cost b) => new Cost(a.Time - b.Time, a.Money - b.Money);
    }
}
