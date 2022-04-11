namespace OOP
{
    // Class Definition
    public class House
    {
        public int SizeM2 { get; set; }
        public int Floors { get; set; }
        public decimal Value { get; set; }
        public int NumberVacancies { get; set; }
    }

    public class Object

    {
        public Object()
        {
            // Object definition
            var house = new House
            {
                SizeM2 = 100,
                Floors = 2,
                Value = 100000,
                NumberVacancies = 3
            };
        }
    }
}