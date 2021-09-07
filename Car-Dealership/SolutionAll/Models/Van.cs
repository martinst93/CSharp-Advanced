using Enums;

namespace Models
{
    public class Van : Vehicle
    {
        public int MaxLoad { get; set; }

        public Van(string brand, string model, EngineEnum engineType, int engineCC, int power, TransmissionEnum transmission, int price, int maxLoad) : base(brand, model, engineType, engineCC, power, transmission, price)
        {
            MaxLoad = maxLoad;
        }
        public Van()
        {

        }
        public override string VehicleInfo()
        {
            return $"{base.VehicleInfo()}{"Max PayLoad :",-25} {MaxLoad,0} kg\n\n";
        }
    }
}