using System;
using System.Collections;


namespace Interfaces
{

    interface NamesInterface {
        string FirstName { get; set; }
        string LastName { get; set; }

        string FullName { get; }

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