namespace DPAdapterProject
{
    class FarenheitSensor
    {
        public double GetFarenheitTemperature()
        {
            return 40;
        }
    }
    class Sensor
    {
        public virtual double GetTemperature()
        {
            return 36.6;
        }
    }

    class Adapter : Sensor 
    {
        FarenheitSensor fsensor;
        public Adapter(FarenheitSensor fsensor)
        {
            this.fsensor = fsensor;
        }
        public override double GetTemperature()
        {
            return (fsensor.GetFarenheitTemperature() - 32) * 5 / 9;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Sensor sensor = new Sensor();
            FarenheitSensor fsensor = new FarenheitSensor();

            sensor = new Adapter(fsensor);

            double t = sensor.GetTemperature();
        }
    }
}