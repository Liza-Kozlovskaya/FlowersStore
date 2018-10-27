using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers
{
    //Класс Роза
    public class Rose : Flower
    {
        private int rosePrice;
        //Конструктор
        public Rose(int price, Freshness fresh, int stem) : base(0, fresh, stem)
        {
            Price = price;
        }

        //Пересчёт цены из-за свежести цветка. Чем хуже качество, тем меньше получается цена
        public override int Price
        {
            get
            {
                return rosePrice;
            }
            set
            {
                switch (this.Fresh)
                {
                    //высшая
                    case Freshness.HighestFreshness:
                        rosePrice = value;
                        break;
                        //выше среднего
                    case Freshness.AboveAverageFreshness:
                        rosePrice = value - 1;
                        break;
                        //средняя
                    case Freshness.MediumFreshness:
                        rosePrice = value - 3;
                        break;
                        //ниже среднего
                    case Freshness.BelowAverageFreshness:
                        rosePrice = value - 4;
                        break;
                       //низкая
                    case Freshness.LowFreshness:
                        rosePrice = value - 6;
                        break;
                        //скидка
                    case Freshness.SaleFreshness:
                        rosePrice = value - 8;
                        break;
                }

            }
        }

        //Перезапись информации о цветке после изменений из-за свежести
        public override string ToString()
        {
            return string.Format("{0}: {1}", "Rose", base.ToString()); ;
        }
    }
}
