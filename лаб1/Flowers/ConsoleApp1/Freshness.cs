using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers
{

    //Какая бывает степень свежести
    public enum Freshness
    {
        HighestFreshness, //наивысшая свежесть
        AboveAverageFreshness, //выше средней свежести
        MediumFreshness, //средняя свежесть
        BelowAverageFreshness, //ниже средней свежести
        LowFreshness, //худшая свежесть
        SaleFreshness //наинизшая свежесть(на акции)
    }
}

