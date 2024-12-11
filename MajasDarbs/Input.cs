using System;

namespace MajasDarbs
{
    internal class Input
    {
        /// <summary>
        /// Metode ļauj lietotājam ievadīt savu vārdu un atmet simbolus vai ciparus. Ja ievadīta atstarpe, turpmākie simboli netiek ņemti vēra.
        /// </summary>
        /// <returns></returns>
        public static string GetName()
        {
            Console.WriteLine("Kā Tevi sauc?");
            string name = "";
            string input = Console.ReadLine();
            foreach (char c in input)
            {
                if ( char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    name +=c  ;
                }
                else if ( char.IsWhiteSpace(c))
                {
                    break;
                }
            }
            return name;
        }
    }
}
