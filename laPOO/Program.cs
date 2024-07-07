using laPOO;
using laPOO.Operations;


internal class Program
{
    private static void Main(string[] args)
    {




        ////bool itIsCalculatrice = calculatriceSharp is Calculatrice;
        //// bool itIsnCalculatrice = calculatriceSharp is Addition;
        //int a=0;
        //int b=0; 

        ////Operation f;

        ////f = new Addition(a,b);

        ////Addition q;




        ////if(f is Addition h)
        ////{

        ////}


        //q = new Operation(a,b);






        Console.WriteLine("veuillez insérer un premier chifre");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("veuillez insérer un deuxieme chifre");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("veuillez faire un choix sur la liste suivante a faire a tes deux chifre ");
        Console.WriteLine("1 - additioner");
        Console.WriteLine("1 - 1er chiffre soustraction 2eme chifre");
        Console.WriteLine("3 - multiplication ");
        Console.WriteLine("4 - 1 er chifre division 2eme chifre");
        Console.WriteLine("5 - 1er chifre modulo 2eme chifre");

        Operation operation;






        int c = int.Parse(Console.ReadLine());
       // while (true)
        //{
            switch (c)
            {
                case 1:
                    operation = new Addition(a, b);
                    break;
                case 2:
                    operation = new Soustraction(a, b);
                    break;
                case 3:
                    operation = new Multiplication(a, b);
                    break;
                case 4:
                    operation = new Devision(a, b);
                    break;
                case 5:
                    operation = new Modulo(a, b);

                    break;
                default:
                    Console.WriteLine("can you repeat");
                    operation = null; 
                    break;
            }
        //}
        Calculatrice calculatriceSharp = new(operation);
        calculatriceSharp.Executer();
        Console.WriteLine("le resultat de votre opération est " + calculatriceSharp.Resultat);
    }
}

//a = 1;
//b = 2;

////Addition plus = new Addition(a, b);

////plus.Excuter(a, b);
////Console.WriteLine(plus);
//using laPOO.Operations;

//Animal monBerger = new Chien(44);

//Chien caniche = new Chien(10);
//Animal oiseau = new Animal(1);
//erreur
//Chien giraf = new Animal(55);

//exemple pour le patern matchin 
//int a = 4;
//float x = a;
//.....erreur
//float y = 5;
//int u = y;
