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

        public Climate CurrentClimate
        {
            get => Get<Climate>();
            set => Set(value);
        }

        public int Time
        {
            get => Get<int>();
            set => Set(value);
        }

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
            Time = 0;
            for (int i = 0; i < 72; i++)
            {
                Time++;

                await Task.Delay(100);
                CurrentClimate = new Climate();
                var rnd = new Random();
                CurrentClimate.Sun = rnd.Next(0, 5);
                Tick(CurrentClimate);
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
