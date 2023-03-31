using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2
{
    public class NumberPlate
    {
        string originalNumber;
        public string LicensePlate(string originalNumber, int count)
        {
            this.originalNumber = originalNumber;
            char[] chars = originalNumber.ToUpper().ToCharArray();
            Array.Reverse(chars);
            string res = new string(chars);
            res = res.Replace("-", "");
            List<string> listString = new List<string>();
            while(res.Length > 0)
            {
                if(res.Length < count)
                {
                    listString.Add(res);
                    break;
                }
                else
                {
                    listString.Add(res.Substring(0, count));
                    res = res.Substring(count);
                }
            }
            res =   String.Join("-", listString.ToArray());
            chars = res.ToCharArray();
            Array.Reverse(chars);
            res = new string(chars);
            return res;
        }


        public static void main(string[] args)
        {
            NumberPlate n1 = new NumberPlate();
            NumberPlate n2 = new NumberPlate();
            NumberPlate n3 = new NumberPlate();
            NumberPlate n4 = new NumberPlate();
            Console.WriteLine(n1.LicensePlate("5F3Z-2e-9-w", 4));
            Console.WriteLine(n2.LicensePlate("2-5g-3-J", 2)); //➞ "2-5G-3J"

            Console.WriteLine(n3.LicensePlate("2-4A0r7-4k", 3));// ➞ "24-A0R-74K"

            Console.WriteLine(n4.LicensePlate("nlj-206-fv", 3));
        }
    }
}
