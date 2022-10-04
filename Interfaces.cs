using System;
using System.Collections;

/*
    assignment:
        create a console app with a class that has an interface and push it to a git repo! Send me the link to the repository when done. 
        your class should have at least one interface and three different types of properties.
        the interface (and therefore, your class) should have at least three out of these four things:
        instance methods, properties, events, indexers.
        Make sure you have an instance of this class in main!

*/

namespace Interfaces
{

    interface NamesInterface {
        string? FirstName { get; set; }
        string? LastName { get; set; }

        string? FullName { get; }

        string GetFullName();

        int GetNameLength();

        void PrintName();
    }

    class Names : NamesInterface {

        ArrayList names = new ArrayList();


        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName {
            get {
                return FirstName + " " + LastName;
            }
        }

        public string GetFullName() {
            return FullName;
        }

        public int GetNameLength() {
            return FirstName.Length + LastName.Length;
        }

        public void PrintName() {
            Console.WriteLine(GetFullName());
        }

        public NamesInterface this[int index]{
            get => (NamesInterface)names[index];
            set => names.Insert(index, value);
        }

        public int Count => names.Count;

    }
    class Program
    {
        static void Main(string[] args)
        {
            Names names = new Names();
            names[0] = new Names();
            names[0].FirstName = "Jane";
            names[0].LastName = "Doe";
            
            names[1] = new Names();
            names[1].FirstName = "Jeffrey";
            names[1].LastName = "Dalton";

            names[2] = new Names();
            names[2].FirstName = "Rashaad";
            names[2].LastName = "Bryant";

            for(int i = 0; i < names.Count; i++) {
                names[i].PrintName();
            }

        }
    }
}