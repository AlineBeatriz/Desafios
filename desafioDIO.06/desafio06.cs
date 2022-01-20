using System; 

class DIO {

    static void Main(string[] args) { 

    int x = int.Parse(Console.ReadLine());
          if(x % 2 == 0){
            x = x + 2;
            Console.WriteLine(x);
          }else{
            x = x + 1;
            Console.WriteLine(x);
          }

    }

}