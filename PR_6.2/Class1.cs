using System;
using System.Windows.Forms;

namespace RAZRABOTKA_6._2
{
    internal class Class1
    {
        // Подсистема для управления жаркой
        class Frying
        {
            public void StartFrying(double temperature, int time)
            {
                MessageBox.Show($"Начать жарку при температуре {temperature} градусов, время {time} минут");
                // Логика жарки
            }
        }
        // Подсистема для управления тушением
        class Stewing
        {
            public void StartStewing(double temperature, int time)
            {
                MessageBox.Show($"Начать тушение при температуре {temperature} градусов, время {time} минут");
                // Логика тушения
            }
        }
        // Подсистема для приготовления супа
        class MakingSoup
        {
            public void MakeSoup(double temperature, int time)
            {
                MessageBox.Show($"Приготовить суп при температуре {temperature} градусов, время {time} минут");
                // Логика приготовления супа
            }
        }
        // Фасад для управления мультиваркой
        class MulticookerFacade
        {
            private Frying frying;
            private Stewing stewing;
            private MakingSoup makingSoup;
            public MulticookerFacade()
            {
                frying = new Frying();
                stewing = new Stewing();
                makingSoup = new MakingSoup();
            }
            public void CookOwnRecipe(double temperature, int time)
            {
                frying.StartFrying(temperature, time);
                stewing.StartStewing(temperature, time);
                makingSoup.MakeSoup(temperature, time);
            }
            public void HandleEmergencySituation(string situation)
            {
                MessageBox.Show($"Нештатная ситуация: {situation}");
                // Логика обработки нештатной ситуации
            }
        }
        public class Form1 : Form
        {
            public Form1()
            {
                MulticookerFacade multicooker = new MulticookerFacade();
                // Приготовление собственного рецепта
                multicooker.CookOwnRecipe(120, 60);
                // Обработка нештатной ситуации
                multicooker.HandleEmergencySituation("Перегрев");
            }
        }
    }
}
