using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_6._1
{
    public partial class Galaxy : Form
    {
        public Galaxy()
        {
            InitializeComponent();
        }
        public class SpaceBase
        {
            private static SpaceBase instance;
            private SpaceBase() 
            { 

            }
            public static SpaceBase GetInstance()
            {
                if (instance == null)
                {
                    instance = new SpaceBase();
                }
                return instance;
            }
            public void ConquerPlanet(string planetName)
            {
                Console.WriteLine($"Планета {planetName} захвачена Главным космическим штабом.");
            }
        }
        public class RandomEventGenerator
        {
            private static RandomEventGenerator instance;
            private Random rand = new Random();

            private List<string> randomEvents = new List<string>
            {
             "Всплеск враждебной активности",
             "Нанесение удара наших войск",
             "Появление космического тумана",
             "Заглушить связь"
            };
            private RandomEventGenerator()
            { 

            }
            public static RandomEventGenerator GetInstance()
            {
                if (instance == null)
                {
                    instance = new RandomEventGenerator();
                }

                return instance;
            }
            public string GetRandomEvent()
            {
                int index = rand.Next(randomEvents.Count);
                return randomEvents[index];
            }
        }

        private void Galaxy_Load(object sender, EventArgs e)
        {

        }
    }
}
