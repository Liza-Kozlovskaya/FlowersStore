using System;
using Flowers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest
    {
        //сортировка по свежести
        [TestMethod]
        public void TestFresh()
        {
            Flower Rose = new Flower(100, Freshness.AboveAverageFreshness, 32);
            Flower Lily = new Flower(78, Freshness.HighestFreshness, 29);
            Flower Aster = new Flower(54, Freshness.LowFreshness, 21);
            Flower Orchid = new Flower(115, Freshness.LowFreshness, 23);


            //тест 1:
            int expected1 = 1; //ожидаемый результат
            int actual1 = Rose.CompareTo(Lily); //результат метода
            Assert.AreEqual(expected1, actual1);

            //тест 2:
            int expected2 = -1;
            int actual2 = Lily.CompareTo(Rose);
            Assert.AreEqual(expected2, actual2);

            //тест 3:
            int expected3 = 0;
            int actual3 = Aster.CompareTo(Orchid);
            Assert.AreEqual(expected3, actual3);

        }

        //изменение цены астр из-за свежести цветка
        [TestMethod]
        public void TestPriceAster()
        {
            //тест 0: для астр на скидке
            Aster aster0 = new Aster(63, Freshness.SaleFreshness, 30);
            int expected0 = 49; //63-14=9
            int actual0 = aster0.Price;
            Assert.AreEqual(expected0, actual0);

            //тест 1: для астр плохого качества
            Aster aster1 = new Aster(63, Freshness.LowFreshness, 30);
            int expected1 = 54; //63-9=54
            int actual1 = aster1.Price;
            Assert.AreEqual(expected1, actual1);

            //тест 2: для астр ниже среднего качества
            Aster aster2 = new Aster(67, Freshness.BelowAverageFreshness, 27);
            int expected2 = 61; //67-6=61
            int actual2 = aster2.Price;
            Assert.AreEqual(expected2, actual2);

            //тест 3: для астр среднего качества
            Aster aster3 = new Aster(72, Freshness.MediumFreshness, 23);
            int expected3 = 68; //72-4=68
            int actual3 = aster3.Price;
            Assert.AreEqual(expected3, actual3);

            //тест 4: для астр выше среднего качества
            Aster aster4 = new Aster(52, Freshness.AboveAverageFreshness, 23);
            int expected4 = 50; //52-2=50
            int actual4 = aster4.Price;
            Assert.AreEqual(expected4, actual4);

            //тест 5: для астр высшего качества
            Aster aster5 = new Aster(73, Freshness.HighestFreshness, 23);
            int expected5 = 73; 
            int actual5 = aster5.Price;
            Assert.AreEqual(expected5, actual5);
        }

        //изменение цены пионов из-за свежести цветка
        [TestMethod]
        public void TestPricePeony()
        {
            //тест 0: для пионов на скидке
            Peony peony0 = new Peony(78, Freshness.SaleFreshness, 29);
            int expected0 = 65; //78-13=64
            int actual0 = peony0.Price;
            Assert.AreEqual(expected0, actual0);

            //тест 1: для пионов плохого качества
            Peony peony1 = new Peony(78, Freshness.LowFreshness, 29);
            int expected1 = 69; //78-9 =69
            int actual1 = peony1.Price;
            Assert.AreEqual(expected1, actual1);

            //тест 2: для пионов ноже среднего качества
            Peony peony2 = new Peony(89, Freshness.BelowAverageFreshness, 25);
            int expected2 = 83; //89-6=83
            int actual2 = peony2.Price;
            Assert.AreEqual(expected2, actual2);

            //тест 3: для пионов среднего качества
            Peony peony3 = new Peony(89, Freshness.MediumFreshness, 25);
            int expected3 = 84; //89-5=84
            int actual3 = peony3.Price;
            Assert.AreEqual(expected3, actual3);

            //тест 4: для пионов выше среднего качества
            Peony peony4 = new Peony(89, Freshness.AboveAverageFreshness, 25);
            int expected4 = 86; //89-3=86
            int actual4 = peony4.Price;
            Assert.AreEqual(expected4, actual4);

            //тест 5: для пионов наилучшего качества
            Peony peony5 = new Peony(91, Freshness.HighestFreshness, 27);
            int expected5 = 91;
            int actual5 = peony5.Price;
            Assert.AreEqual(expected5, actual5);
        }

        //изменение цены ирисов из-за свежести цветка
        [TestMethod]
        public void TestPriceIris()
        {
            //тест 0: для ирисов на скидке
            Iris iris0 = new Iris(63, Freshness.SaleFreshness, 22);
            int expected0 = 52; //63-11=52
            int actual0 = iris0.Price;
            Assert.AreEqual(expected0, actual0);

            //тест 1: для ирисов плохого качества
            Iris iris1 = new Iris(63, Freshness.LowFreshness, 22);
            int expected1 = 55; //63-8=55
            int actual1 = iris1.Price;
            Assert.AreEqual(expected1, actual1);

            //тест 2: для ирисов ниже среднего качества
            Iris iris2 = new Iris(63, Freshness.BelowAverageFreshness, 22);
            int expected2 = 57; //63-6=57
            int actual2 = iris2.Price;
            Assert.AreEqual(expected2, actual2);

            //тест 3: для ирисов среднего качества
            Iris iris3 = new Iris(67, Freshness.MediumFreshness, 20);
            int expected3 = 62; //67-5=62
            int actual3 = iris3.Price;
            Assert.AreEqual(expected3, actual3);

            //тест 4: для ирисов выше среднего качества
            Iris iris4 = new Iris(63, Freshness.AboveAverageFreshness, 22);
            int expected4 = 62;//63-1=62
            int actual4 = iris4.Price;
            Assert.AreEqual(expected4, actual4);

            //тест 5: для ирисов наилучшего качества
            Iris iris5 = new Iris(72, Freshness.HighestFreshness, 23);
            int expected5 = 72;
            int actual5 = iris5.Price;
            Assert.AreEqual(expected5, actual5);
        }

        //изменение цены лилий из-за свежести цветка
        [TestMethod]
        public void TestPriceLily()
        {
            //тест 0: для лилий на скидке
            Lily lily0 = new Lily(76, Freshness.SaleFreshness, 32);
            int expected0 = 61; //76-15=61
            int actual0 = lily0.Price;
            Assert.AreEqual(expected0, actual0);

            //тест 1: для лилий плохого качества
            Lily lily1 = new Lily(76, Freshness.LowFreshness, 32);
            int expected1 = 66; //76-10=66
            int actual1 = lily1.Price;
            Assert.AreEqual(expected1, actual1);

            //тест 2: для лилий ниже среднего качества
            Lily lily2 = new Lily(76, Freshness.BelowAverageFreshness, 32);
            int expected2 = 67; //76-9=67
            int actual2 = lily2.Price;
            Assert.AreEqual(expected2, actual2);

            //тест 3: для лилий среднего качества
            Lily lily3 = new Lily(79, Freshness.MediumFreshness, 27);
            int expected3 = 72; //79-7=72
            int actual3 = lily3.Price;
            Assert.AreEqual(expected3, actual3);

            //тест 4: для лилий выше среднего качества
            Lily lily4 = new Lily(79, Freshness.AboveAverageFreshness, 27);
            int expected4 = 75; //79-4=75
            int actual4 = lily4.Price;
            Assert.AreEqual(expected4, actual4);

            //тест 5: для лилий наилучшего качества
            Lily lily5 = new Lily(76, Freshness.HighestFreshness, 32);
            int expected5 = 76;
            int actual5 = lily5.Price;
            Assert.AreEqual(expected5, actual5);
        }

        //изменение цены роз из-за свежести цветка
        [TestMethod]
        public void TestPriceRose()
        {
            //тест 0: для роз на скидке
            Rose rose0 = new Rose(86, Freshness.SaleFreshness, 27);
            int expected0 = 78; //86-8=78
            int actual0 = rose0.Price;
            Assert.AreEqual(expected0, actual0);

            //тест 1: для роз плохого качества
            Rose rose1 = new Rose(86, Freshness.LowFreshness, 27);
            int expected1 = 80; //86-6=80
            int actual1 = rose1.Price;
            Assert.AreEqual(expected1, actual1);

            //тест 2: для роз ниже среднего качества
            Rose rose2 = new Rose(87, Freshness.BelowAverageFreshness, 30);
            int expected2 = 83; //87-4=83
            int actual2 = rose2.Price;
            Assert.AreEqual(expected2, actual2);

            //тест 3: для роз среднего качества
            Rose rose3 = new Rose(86, Freshness.MediumFreshness, 27);
            int expected3 = 83; //86-3=83
            int actual3 = rose3.Price;
            Assert.AreEqual(expected3, actual3);

            //тест 4: для роз выше среднего качества
            Rose rose4 = new Rose(94, Freshness.AboveAverageFreshness, 33);
            int expected4 = 93; //94-1=93
            int actual4 = rose4.Price;
            Assert.AreEqual(expected4, actual4);

            //тест 5: для роз наилучшего качества
            Rose rose5 = new Rose(86, Freshness.HighestFreshness, 27);
            int expected5 = 86;
            int actual5 = rose5.Price;
            Assert.AreEqual(expected5, actual5);
        }
    }
}
