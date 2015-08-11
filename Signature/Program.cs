using System;
using System.Text;

namespace Signature
    {
    internal class Sincerely
        {
        private static void Main ( string [ ] args )
            {
            Console.WriteLine ( Signed ( "Jerry", 'R', "Peirce" ) );
            }

        private static string Signed ( string first, char mid, string last )
            {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine ( "---" ).Append ( first ).Append ( " " );
            sb.Append ( mid ).Append ( " " ).AppendLine ( last );
            string whole = sb.ToString();
            return whole;
            }
        }
    }