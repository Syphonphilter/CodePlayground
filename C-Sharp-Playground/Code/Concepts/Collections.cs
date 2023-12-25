namespace C_Sharp_Playground.Code.Concepts
{
    public class Collections
    {
        void tlist()
        {
            List<dynamic> t_list = new List<dynamic>(0)
        {
            100,
            "bala"
        };
            foreach (dynamic item in t_list)
            {
                Console.WriteLine(item);
            }
        }
    }
}