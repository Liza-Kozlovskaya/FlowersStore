using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers
{
    //Класс Астра
    public class Aster : Flower
    {
        private int asterPrice;

        //Конструктор
        public Aster(int price, Freshness fresh, int stem) : base(0, fresh, stem)
        {
            Price = price;
        }

        //Пересчёт цены из-за свежести цветка. Чем хуже качество, тем меньше получается цена
        public override int Price
        {
            get
            {
                return asterPrice; ;
            }
            set
            {
                switch (this.Fresh)
                {
                    //высшая
                    case Freshness.HighestFreshness:
                        asterPrice = value;
                        break;
                        //выше средней
                    case Freshness.AboveAverageFreshness:
                        asterPrice = value - 2;
                        break;
                        //средняя
                    //если цветок средней свежести, то от изначальной цены отнимаем 4
                    case Freshness.MediumFreshness:
                        asterPrice = value - 4;
                        break;
                        //ниже средней
                    case Freshness.BelowAverageFreshness:
                        asterPrice = value - 6;
                        break;
                       //низкая
                    case Freshness.LowFreshness:
                        asterPrice = value - 9;
                        break;
                       //скидка
                    case Freshness.SaleFreshness:
                        asterPrice = value - 14;
                        break;
                }
            }
        }

        //Перезапись информации о цветке после изменений из-за свежести
        public override string ToString()
        {
            return string.Format("{0}: {1}", "Aster", base.ToString()); ;
        }
    }
}
