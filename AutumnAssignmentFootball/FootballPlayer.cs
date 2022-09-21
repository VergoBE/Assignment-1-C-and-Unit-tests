using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutumnAssignmentFootball
{
    public class FootballPlayer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int ShirtNumber { get; set; }

        public FootballPlayer()
        {

        }

        public FootballPlayer(int id, string name, int age, int shirtNumber)
        {
            Id = id;
            Name = name;
            Age = age;
            ShirtNumber = shirtNumber;
        }

        public override string ToString()
        {
            return Id + " " + Name + " " + Age + " " + ShirtNumber;
        }

        public void AgeValidation()
        {
            if (Age < 1) throw new ArgumentOutOfRangeException("Player cannot be younger than 1" + Age);
        }

        public void NameValidator()
        {
            if (Name == null) throw new ArgumentNullException("Name cannot be empty or null" + Name);
            if (Name.Length < 2) throw new ArgumentOutOfRangeException("Name cannot be less than 2 characters" + Name);
     
        }

        public void ShirtNumberValidation()
        {
            if (ShirtNumber > 1) throw new ArgumentOutOfRangeException("Shirtnumber cannot exceed 99" + ShirtNumber);
            if (ShirtNumber < 99) throw new ArgumentOutOfRangeException("Shirtnumber cannot be lower than 1" + ShirtNumber);

        }
    }
}
