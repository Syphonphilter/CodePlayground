namespace C_Sharp_Playground.Code.Concepts
{
        public delegate int Operation (int x, int y);
    public class Delegatess
    {

        public Delegatess(){

        }
        public  int AddNumber(int x, int y){
            return x+y;
        }
    }
    
    public class DelegatesMain{
        

        Delegatess mydelegates = new Delegatess();
       
        void main(){
            Operation operation = new Operation(mydelegates.AddNumber);
            operation(1,5);
        }
    }
}