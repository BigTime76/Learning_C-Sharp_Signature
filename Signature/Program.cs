using System;
using System.Text;

namespace Signature {

    internal class Sincerely {

        private static void Main(string[] args) {
            string[] signed = new string[3] { "Jerry", "R", "Peirce" };
            string[] contact = new string[2] { "notreal@nomail.com", "900.909.9900" };
            // "Mean" Gene Hotline: Kids get your parents permission!
            try {
                StringBuilder sb = new StringBuilder().AppendLine("---");
                foreach(string item in signed) { sb.Append(item).Append(" "); }
                Console.WriteLine(sb.ToString());
                Console.WriteLine(String.Join(" | ", contact));
                } catch(Exception ex) {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
                }
            }
        }
    }