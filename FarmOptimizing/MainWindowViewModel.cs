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
            while (true)
            {
                await Task.Delay(100);
                Tick();
            }
        }

        private void Tick()
        {
            foreach (var plant in Plants)
            {
                plant.Height++;
            }
        }
    }
}
