using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers
{
    //Класс Лилия
    public class Lily : Flower
    {
        private int lilyPrice;

        //Конструктор
        public Lily(int price, Freshness fresh, int stem) : base(0, fresh, stem)
        {
            Price = price;
        }

        //Пересчёт цены из-за свежести цветка. Чем хуже качество, тем меньше получается цена
        public override int Price
        {
            get
            {
                return lilyPrice; ;
            }
            set
            {
                switch (this.Fresh)
                {
                    //высшая
                    case Freshness.HighestFreshness:
                        lilyPrice = value;
                        break;
                        //выше средней
                    case Freshness.AboveAverageFreshness:
                        lilyPrice = value - 4;
                        break;
                        //средняя
                    case Freshness.MediumFreshness:
                        lilyPrice = value - 7;
                        break;
                        //ниже средней
                    case Freshness.BelowAverageFreshness:
                        lilyPrice = value - 9;
                        break;
                        //низкая
                    case Freshness.LowFreshness:
                        lilyPrice = value - 10;
                        break;
                        //скидка
                    case Freshness.SaleFreshness:
                        lilyPrice = value - 15;
                        break;
                }
            }
        }

        //Перезапись информации о цветке после изменений из-за свежести
        public override string ToString()
        {
            return string.Format("{0}: {1}", "Lily", base.ToString()); ;
        }
    }
}
