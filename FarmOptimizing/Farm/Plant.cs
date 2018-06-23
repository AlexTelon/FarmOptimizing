using WpfTemplate.Utils;

namespace FarmOptimizing.Farm
{
    class Plant : BindableBase
    {
        public int Height
        {
            get => Get<int>();
            set => Set(value);
        }

        /// <summary>
        /// As time goes on the climate might change. The plant grows or withers based on the change (or not) in the climate.
        /// </summary>
        /// <param name="climate"></param>
        public void TimeStep(Climate climate)
        {
            Height += climate.Sun;
        }

        public override string ToString()
        {
            return "" + Height;
        }
    }
}
