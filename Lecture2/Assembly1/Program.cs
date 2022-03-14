using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assembly1
{
    public class Asssembly1BaseClass
    {
        private string privateVariable = "private";
        protected string protectedVariable = "protected";
        internal string internalVariable = "internal";
        protected internal string protectedInternalVariable = "protected internal";
        public string publicVariable = "public";

        public void TestAccess()
        {
            //Console.WriteLine(privateVariable);
            //Console.WriteLine(protectedVariable);
            Console.WriteLine(protectedInternalVariable);
            Console.WriteLine(publicVariable);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Asssembly1BaseClass objBase = new Asssembly1BaseClass();
            objBase.TestAccess();
            Console.ReadKey();
        }
    }
}
