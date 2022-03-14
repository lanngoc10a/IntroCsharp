// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Class1;

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
            Console.WriteLine(privateVariable);
            Console.WriteLine(protectedVariable);
            Console.WriteLine(protectedInternalVariable);
            Console.WriteLine(publicVariable);
        }
    }

    namespace Assembly2
    {
        public class Assembly1DerivedClass: Asssembly1BaseClass
        {
            public void TestAccess()
            {
                //Console.WriteLine(privateVariable);
                Console.WriteLine(protectedVariable);
                Console.WriteLine(internalVariable);
                Console.WriteLine(protectedInternalVariable);
                Console.WriteLine(publicVariable);
            }
        }

        public class AssemblyOtherClass
        {
            public void TestAccess()
            {
                Asssembly1BaseClass objBase = new Asssembly1BaseClass();

                //Console.WriteLine(privateVariable);AssemblyOtherClass
                //Console.WriteLine(objBase.protectedVariable);
                Console.WriteLine(objBase.internalVariable);
                Console.WriteLine(objBase.protectedInternalVariable);
                Console.WriteLine(objBase.publicVariable);
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                //Asssembly1BaseClass objBase = new Asssembly1BaseClass();
                //objBase.TestAccess();
                //Console.ReadKey();

                //Assembly1DerivedClass objDerivedClass = new Assembly1DerivedClass();
                //objDerivedClass.TestAccess();

                AssemblyOtherClass objOtherClass = new AssemblyOtherClass();
                objOtherClass.TestAccess();
                Console.ReadKey();
            }
        }
    }
}


