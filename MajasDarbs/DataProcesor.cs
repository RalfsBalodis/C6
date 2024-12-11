namespace MajasDarbs
{
    internal class DataProcesor
    {
        /// <summary>
        /// Atkarībā no burta, atlasa īpašību.
        /// </summary>
        /// <param char="c"> Jābūt lielajam burtam!</param>
        /// <returns></returns>
        // Iespejams izveidot sarakstus ar vairākiem ipasības vārdiem un izveidot algoritmu, kas izvēlas vārdus no saraksta randomā.
        public static string GetNameProperties(char c)
        {
            string output = "-";
            
                
                switch (c)
                {
                    case 'A':
                        {
                            output = "Apzinigs";
                            break;
                        }
                    case 'B': 
                        {
                            output = "Bossigs";
                            break;
                        }
                    case 'C':
                        {
                            output = "Citigs";
                            break;
                        }
                    case 'D':
                        {
                            output = "Drosmigs";
                            break;
                        }
                    case 'E':
                        {
                            output = "Elegants";
                            break;
                        }
                    case 'F':
                        {
                            output = "Fantastisks";
                            break;
                        }
                    case 'G':
                        {
                            output = "Gudrs";
                            break;
                        }
                    case 'H':
                        {
                            output = "Harizmatisks";
                            break;
                        }
                    case 'I':
                        {
                            output = "Interesnats";
                            break;
                        }
                    case 'J':
                        {
                            output = "Jauks";
                            break;
                        }
                    case 'K':
                        {
                            output = "Kolosals";
                            break;
                        }
                    case 'L':
                        {
                            output = "Labs";
                            break;
                        }
                    case 'M':
                        {
                            output = "Mierigs";
                            break;
                        }
                    case 'N':
                        {
                            output = "Nosverts";
                            break;
                        }
                    case 'O':
                        {
                            output = "Omuligs";
                            break;
                        }
                    case 'P':
                        {
                            output = "Pieklajigs";
                            break;
                        }
                    case 'R':
                        {
                            output = "Rupigs";
                            break;
                        }
                    case 'S':
                        {
                            output = "Sirsnigs";
                            break;
                        }
                    case 'T':
                        {
                            output = "Taktisks";
                            break;
                        }
                    case 'U':
                        {
                            output = "Uznemigs";
                            break;
                        }
                    case 'V':
                        {
                            output = "Valdonigs";
                            break;
                        }
                    case 'Z':
                        {
                            output = "Zinoss";
                            break;
                        }
                    default:
                        break;
                }
            return output;
        }
    }
}
