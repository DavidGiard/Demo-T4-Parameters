using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoT4Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            var pt1 = new ParamTemplate1();
            pt1.Session = new Dictionary<string, object>();
            pt1.Session["firstName"] = "David";
            pt1.Session["lastName"] = "Giard";
            pt1.Initialize();
            var outputText1 = pt1.TransformText();
            Console.WriteLine(outputText1);

            var pt2 = new ParamTemplate2();
            pt2.Session = new Dictionary<string, object>();
            var person = new Person()
            {
                FirstName = "Satya",
                LastName = "Nadella"
            };
            pt2.Session["person"] = person;
            pt2.Initialize();
            var outputText2 = pt2.TransformText();
            Console.WriteLine(outputText2);

            Console.ReadLine();
        }
    }
}
