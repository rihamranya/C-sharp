// See https://aka.ms/new-console-template for more information

public class HelloWorld
{
    
    
    static void Permuter(ref int x, ref int y) {
        int aux;
        aux = x;
        x = y;
        y = aux;
    }
    // public static void Main(string[] args)
    // {
    //      
    //     unsafe
    //     {
    //         int* p;
    //         int a, b;
    //         p = &a;
    //         Console.Write("entrez un entier: ");
    //         b= int.Parse(Console.ReadLine());
    //         *p = 5;
    //         Permuter(ref a,ref b);
    //         // Console.WriteLine("les valeurs sont {0} et {1} " ,a,b);
    //         // Console.WriteLine("Les valeurs sont " + a + " et " + b);
    //         Console.WriteLine($"Les valeurs sont {a} et {b}");
    //     }
    // }
}


