using System;
namespace ClubInterface
{
    interface IClub
    {//Properties
        public int Id { get; set; }
        public string Sport { get; set; }
        public string Position { get; set; }
        

        //Methods
        string FullStatus();
        double Cost();
    }
    class Program
    {
        class Athlete : IClub
        {
            public int Id { get; set; }
            public string Sport { get; set; }
            public string Position { get; set; }
            public double Rate { get; set; }
            public int Hours { get; set; }

            public Athlete()
            {
                Id = 0;
                Sport = string.Empty;
                Position = string.Empty;
                Rate = 0;
                Hours = 0;
            }
            public Athlete(int id, string sport, string position, double rate, int hours)
            {
                Id = id;
                Sport = sport;
                Position = position;
                Rate = rate;
                Hours = hours;
            }

            public string FullStatus()
            {
                return Sport + " " + Position;
            }
            public double Cost()
            {
                if (Hours > 0)
                    return Rate * Hours;
                else
                    return Rate;
            }
        }
        static void Main(string[] args)
        {
            // Worker object created using parameterized constructor
            Athlete basketball = new Athlete(1, "Basketball", "Gaurd", 10, 3);
            Console.WriteLine(basketball.FullStatus());
            Console.WriteLine(basketball.Cost());

            //Worker object created using the default constructor
            //values are assigned using properties
            Athlete softball = new Athlete();
            softball.Id = 2;
            softball.Sport = "Softball";
            softball.Position = "Pitcher";
            softball.Rate = 20;
            softball.Hours = 2;
            Console.WriteLine(softball.FullStatus());
            Console.WriteLine(softball.Cost());

        }
    }
}
