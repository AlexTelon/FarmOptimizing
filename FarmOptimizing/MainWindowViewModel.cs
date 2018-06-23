using FarmOptimizing.Farm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfTemplate.Utils;

namespace WpfTemplate
{
    class MainWindowViewModel : BindableBase
    {
        public ObservableCollection<Plant> Plants { get; set; } = new ObservableCollection<Plant>() { };

        public MainWindowViewModel()
        {
            for (int i = 0; i < 8; i++)
            {
                var plant = new Plant()
                {
                    Height = i*10
                };
                Plants.Add(plant);
            }

            RunSimulation();
        }

        private async Task RunSimulation()
        {
            for (int i = 0; i < 24; i++)
            {
                await Task.Delay(100);
                var env = new Climate();
                var rnd = new Random();
                env.Sun = rnd.Next(0, 5);
                Tick(env);
            }
        }

        private void Tick(Climate climate)
        {
            foreach (var plant in Plants)
            {
                plant.TimeStep(climate);
            }
        }
    }
}
