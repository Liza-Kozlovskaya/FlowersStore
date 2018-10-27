using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers
{
    //Класс Ирис
    public class Iris : Flower
    {
        private int irisPrice;

        //Конструктор
        public Iris(int price, Freshness fresh, int stem) : base(0, fresh, stem)
        {
            Price = price;
        }

        //Пересчёт цены из-за свежести цветка. Чем хуже качество, тем меньше получается цена
        public override int Price
        {
            get
            {
                return irisPrice;
            }
            set
            {
                switch (this.Fresh)
                {
                    //высшая
                    case Freshness.HighestFreshness:
                        irisPrice = value;
                        break;
                        //выше средней
                    case Freshness.AboveAverageFreshness:
                        irisPrice = value - 1;
                        break;
                        //средняя
                    case Freshness.MediumFreshness:
                        irisPrice = value - 5;
                        break;
                        //ниже средней
                    case Freshness.BelowAverageFreshness:
                        irisPrice = value - 6;
                        break;
                       //низкая
                    case Freshness.LowFreshness:
                        irisPrice = value - 8;
                        break;
                        //скидка
                    case Freshness.SaleFreshness:
                        irisPrice = value - 11;
                        break;
                }
            }
        }

        //Перезапись информации о цветке после изменений из-за свежести
        public override string ToString()
        {
            return string.Format("{0}: {1}", "Iris", base.ToString()); ;
        }
    }
}
