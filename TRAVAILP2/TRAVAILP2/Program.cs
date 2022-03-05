using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAVAILP2
{
    class Program
    {
        static void Main(string[] args)
        {
        string caracters = "ABCDE99F-J74-12-89A";
            // selectioner uniquement  les  caracteres qui sont des nombres 

            IEnumerable<char> stringQuery =
                from ch in caracters
                where Char.IsDigit(ch)
                select ch;
            //Boucle foreach pour laffichage
            foreach(char c in stringQuery)
                Console.Write(c + "");
            int comptage = stringQuery.Count();
            Console.WriteLine("\n Les caracteres sont au nombre de :");
            Console.WriteLine("count ={0}", + comptage);
            //pour selectionnnertous les caracters avant le premier'-'
            IEnumerable<char> stringQuery2 = caracters.TakeWhile(c => c == '-');

            // executer la requete Query
            foreach( var affiche in stringQuery2)
                Console.Write(affiche);

                Console.WriteLine(System.Environment.NewLine +" cliquer sur n`impote quel bouton pour quiter");
                Console.ReadKey();

       
        }
    }
}
