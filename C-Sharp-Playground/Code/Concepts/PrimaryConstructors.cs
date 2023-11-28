namespace C_Sharp_Playground.Code.Concepts
{
    public class PrimaryConstructors
    {
        // USAGE
        // var staff = new PrimaryConstructors.Employee(1, "Bala", "Jr Developer");
        // var promoted = staff.Promote("Sr Developer", 3);
        // Console.WriteLine(promoted);
        /// <summary>
        /// Represents an employee with properties for age, name, position, and years of experience.
        /// </summary>
        /// <remarks>
        /// This record class includes a constructor and a method for promoting the employee.
        /// </remarks>
        public record Employee(int age, string name, string position)
        {
            /// <summary>
            /// Gets or sets the years of experience of the employee.
            /// </summary>
            public int yearsOfExperience { get; init; }

            /// <summary>
            /// Initializes a new instance of the <see cref="Employee"/> class.
            /// </summary>
            /// <param name="Age">The age of the employee.</param>
            /// <param name="Name">The name of the employee.</param>
            /// <param name="Position">The position of the employee.</param>
            /// <param name="yox">The years of experience of the employee.</param>
            public Employee(int Age, string Name, string Position, int yox) : this(Age, Name, Position)
            {
                yearsOfExperience = yox;
            }

            /// <summary>
            /// Promotes the employee to a new position with additional years of experience.
            /// </summary>
            /// <param name="newPosition">The new position of the employee.</param>
            /// <param name="additionalYears">The additional years of experience.</param>
            /// <returns>A new instance of <see cref="Employee"/> with the updated position and years of experience.</returns>
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