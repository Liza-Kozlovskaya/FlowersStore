using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers
{
    public class Flower : IComparable<Flower>
    {
        //Свойства
        public virtual int Price { get; set; }
        public Freshness Fresh { get; set; }
        public int StemLength { get; set; }

        //Конструктор
        public Flower(int price, Freshness fresh, int stem)
        {
            Price = price;
            Fresh = fresh;
            StemLength = stem;
        }

        //Переопределение ToString();
        public override string ToString()
        {
            return string.Format("Price: {0}, Freshness: {1}, StemLength: {2}",
                                 Price, Fresh, StemLength);
        }

        //Реализация интерфейса IComparable<Flower>(для сортировки)
        public int CompareTo(Flower other)
        {
            if ((int)this.Fresh > (int)other.Fresh)
                return 1;
            if ((int)this.Fresh < (int)other.Fresh)
                return -1;
            else
                return 0;
        }
    }
}

