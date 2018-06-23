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

        public override string ToString()
        {
            return "" + Height;
        }
    }
}
