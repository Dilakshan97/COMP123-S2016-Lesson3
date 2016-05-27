using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Lab2_Dilakshan_Packiyanathan
{
    /**
     * This class defines a generic Person
     * 
     * @class Person
     * @field _name {string} _Name
     */
    public class Person
    {
        // PRIVATE INSTANCE VARIABLES ++++++++++++++++++++++++++++++++++
        private string _name;
        private int _age;

        // PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This is a property for our _name field
         * </summary>
         * @property {string} Name
         */
        public string Name
        {
            get
            {
                return this._name;
            }

            set
            {

                this._name = value;
            }

        }

        /**
         * <summary>
         * This is a public property for our private _age field
         * </summary>
         * @property {int} Age
         * 
         */

        public int Age
        {
            get
            {
                return this._age;
            }

            set
            {
                this._age = value;
            }
        }
        //CONSTRUCTORS ++++++++++++++++++++++++++++++++++






        /**
         * <summary>
         * This is the default empty constructor for the Person class
         * </summary>
         * @constructor Person
         */
        public Person()
        {
            this.Name = "unknown name!";
            this.Name = "0";
        }

        /**
         * <summary>
         * This is a consructor that takes name as a parameter and passes 
         * it to the _name private instance variable
         * </summary>
         * @constructor Person
         * @param {string} name
         */
        public Person(string name)
        {
            this.Name = name;
            this.Age = 0;

        }

        /**
         * <summary>
         * This is a constructor that takes age as a parameter and passes it to the _age private instance variable
         * </summary>
         * 
         */
        public Person(int age)

        {
            this.Name = "unknown name!";
            this.Age = age;
        }

        /**
         * <summary>
         * This is a constructor that takes both name and age as parameters
         * It assigns the local name value to the Name proerty
         * Itt assigns the local age value to the age property
         * </summary>
         * @Constructor
         * @param {string} name
         * @param {int} age
         */

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        //PUBLC METHOD +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This method output the _name value with "says hello! to the console.
         * </summary>
         * 
         * @method
         * return {void}
         */
        public void SaysHello()
        {
            Console.WriteLine(this.Name + " says hello!");
        }

        /**
         * <summary>
         * This command outputs the _name and _age value in the following 
         * format: _name + " is " + "years old " '
         * </summary>
         *
         *@method ShowAge
         * @return {void} 
         */
        public void ShowAge()
        {
            Console.WriteLine(this.Name + " is " + this.Age + " yers old. ");
        }
    }
}