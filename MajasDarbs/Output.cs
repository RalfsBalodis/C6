using System;
using System.Linq;

namespace MajasDarbs
{
    internal class Output
    {
        /// <summary>
        /// Sagatavo īpašības vārdus. Ja iedotasi vārds, beidzas ar a vai e, tad visi īpašības vārdi tiek beigti ar a.
        /// </summary>
        /// <param name="name">Visiem burtiem jābūt lielajiem burtiem. </param>
        public static void GetOutput(string name)
        {
            
            try
            {
                name = name.ToUpper();                     
                string normalName = name.Substring(0, 1);   // pirmais burts
                normalName += name.ToLower().Substring(1);  // pārējie burti pārveidoti uz mazajiem



                Console.WriteLine($"\nČau {normalName}");
                Console.WriteLine("Tu esi:\n");



                foreach (char c in name)
                {
                    string property = DataProcesor.GetNameProperties(c);

                    if (name.Last() == 'A' || name.Last() == 'E')
                    {
                        property = property.Remove(property.Length - 1);
                        property += 'a';
                    }
                    Console.WriteLine(property);
                }
            }
            catch (Exception e)
            {
                if (name == "")
                { 
                    name = "Tev nav vārda?";
                    Console.WriteLine(name); 
                }             
                else { Console.WriteLine(  e.Message ); };

            }






        }
    }
}

