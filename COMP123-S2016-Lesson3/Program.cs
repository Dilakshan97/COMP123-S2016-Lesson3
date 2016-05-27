using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Lab2_Dilakshan_Packiyanathan
{
    /**
     * This class is the "driver" class for our Program
     * 
     * @class Program
     */
    public class Program
    {
        /**
         * the main method for our driver class Program
         * 
         * @method Main
         * @param {sting[]} args
         */
        public static void Main(string[] args)
        {
            // create a new instance of the Person class
            Person Dilakshan = new Person();
            Dilakshan.Name = "Dilakshan";
            Dilakshan.Age = 18;
            Dilakshan.SaysHello();
            Dilakshan.ShowAge();

            Console.WriteLine();
            Console.Write("Press 'Enter' for new Person");
            Console.ReadLine();
            Console.WriteLine();



            Person person = new Person("Buklau");
            person.Age = 34;
            person.SaysHello();
            person.ShowAge();

            Console.WriteLine();
            Console.Write("Press 'Enter' for new Person");
            Console.ReadLine();
            Console.WriteLine();

            Person Donavich = new Person(46);
            Donavich.Name = "Donavich";
            Donavich.SaysHello();
            Donavich.ShowAge();

            Console.WriteLine();
            Console.Write("Press 'Enter' for new Person");
            Console.ReadLine();
            Console.WriteLine();

            Person Tyrone = new Person("Tyrone", 23);
            Tyrone.Name = "Tyrone";
            Tyrone.SaysHello();
            Tyrone.ShowAge();

            Console.WriteLine();
            Console.Write("Thats all, Peace out:)");
            Console.ReadLine();
            Console.WriteLine();

        }
    }

}