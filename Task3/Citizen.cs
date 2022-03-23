
namespace Task3
{
    abstract class Citizen
    {
        public int Age { get; set;  }

        public string SeriesAndNumberOfPassport { get; set; }
        public abstract void Greeting();

        public Citizen(int age, string seriesAndNumberOfPassport)
        {
            this.Age = age;
            this.SeriesAndNumberOfPassport = seriesAndNumberOfPassport;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: age {this.Age}, pasport '{this.SeriesAndNumberOfPassport}'";
        }
        public override bool Equals(object obj)
        {
            var value = obj as Citizen;
            if (value != null)
                return this.SeriesAndNumberOfPassport == value.SeriesAndNumberOfPassport;
            else
                return false;
        }
    }
}
