using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers
{
    //Класс Пион
    public class Peony : Flower
    {
        private int peonyPrice;

        //Конструктор
        public Peony(int price, Freshness fresh, int stem) : base(0, fresh, stem)
        {
            Price = price;
        }

        //Пересчёт цены из-за свежести цветка. Чем хуже качество, тем меньше получается цена
        public override int Price
        {
            get
            {
                return peonyPrice; ;
            }
            set
            {
                switch (this.Fresh)
                {
                    //высшая 
                    case Freshness.HighestFreshness:
                        peonyPrice = value;
                        break;
                        //выше средней
                    case Freshness.AboveAverageFreshness:
                        peonyPrice = value - 3;
                        break;
                        //средняя
                    case Freshness.MediumFreshness:
                        peonyPrice = value - 5;
                        break;
                        //ниже средней
                    case Freshness.BelowAverageFreshness:
                        peonyPrice = value - 6;
                        break;
                        //низкая
                    case Freshness.LowFreshness:
                        peonyPrice = value - 9; 
                        break;
                        //скидка
                    case Freshness.SaleFreshness:
                        peonyPrice = value - 13;
                        break;
                }
            }
        }

        //Перезапись информации о цветке после изменений из-за свежести
        public override string ToString()
        {
            return string.Format("{0}: {1}", "Peony", base.ToString()); ;
        }
    }
}
