using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfTemplate.Utils;

namespace FarmOptimizing.Farm
{
    /// <summary>
    /// this class holds a set of environmental factors that affect the plant in various ways
    /// </summary>
    class Climate : BindableBase
    {
        // no need to use units and stuff now just testing the main idea.
        public int Sun
        {
            get => Get<int>();
            set => Set(value);
        }
        public int Water
        {
            get => Get<int>();
            set => Set(value);
        }

        public override string ToString()
        {
            return $"Sun: {Sun}, Water: {Water}";
        }
    }
}
