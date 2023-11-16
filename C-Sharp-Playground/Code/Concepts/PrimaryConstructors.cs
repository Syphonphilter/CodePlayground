namespace C_Sharp_Playground.Code.Concepts
{
    public class PrimaryConstructors
    {
        // USAGE
        //  var staff = new PrimaryConstructors.Employee(1, "Bala", "Jr Developer");
        // var promoted = staff.Promote("Sr Developer", 3);
        // Console.WriteLine(promoted);
        public record Employee(int age, string name, string position)
        {
            public int yearsOfExperience { get; init; }

            public Employee(int Age, string Name, string Position, int yox) : this(Age, Name, Position)
            {
                yearsOfExperience = yox;
            }
            public Employee Promote(string newPosition, int additionalYears)
            {
                return this with
                {
                    position = newPosition,
                    yearsOfExperience = additionalYears + additionalYears
                };
            }
        }
    }
}