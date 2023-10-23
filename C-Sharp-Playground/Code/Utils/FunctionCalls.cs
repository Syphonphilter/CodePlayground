
public class FunctionCalls{

public FunctionCalls(){
    //*ToLookup
var fruits = new List<string>
        {
            "apple", "banana", "cherry", "apple", "date", "banana"
        };

// Create a lookup table based on the length of each fruit name
var lookup = fruits.ToLookup(fruit => fruit.Length);
foreach(var f in lookup[4]){
    Console.WriteLine(f);
}
}

}
