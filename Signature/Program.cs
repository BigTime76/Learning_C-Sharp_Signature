using System;
using System.Text;

namespace Signature
    {
    internal class Sincerely
        {
        private static void Main ( string [ ] args )
            {
            string[] signed = { "Jerry", "R", "Peirce" };

            StringBuilder sb = new StringBuilder().AppendLine ( "---" );
            foreach ( string item in signed )
                {
                sb.Append ( item ).Append ( " " );
                }
            Console.WriteLine ( sb.ToString ( ) );
            }
        }
    }