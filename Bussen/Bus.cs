using System;
using System.Collections.Generic;
using System.Text;

namespace Bussen
{
    class Bus
    {
        private Person[] passenger = new Person[5];

        public Bus()
        {

        }



        public void addPassenger(Person p)
        {
            Passenger[getEmptyIndex()] = p;
            
        }

        public bool checkIfBusIsFull()
        {
           for(int i = 0; i < Passenger.Length; i++)
            {
                if(Passenger[i] == null)
                {
                    return false;
                }
               
            }
            return true;
        }

        public int getEmptyIndex()
        {
            for(int i = 0; i < Passenger.Length; i++)
            {
                if(Passenger[i] == null)
                {
                    return i;
                }
            }
            return 500;
        }

        public void printPassengers()
        {
            for(int i = 0; i < Passenger.Length; i++)
            {
                //print aslong the array index is not null.
                if(Passenger[i] != null) {
                Console.WriteLine(Passenger[i].Name);
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Tryck på valfri tangent + ENTER för att återvända till menyn....");
            Console.ReadLine();
         
        }

        public void removePassenger(int index)
        {
            Passenger[index] = null;
            
        }

        public void removablePassengers()
        {
            for(int i = 0; i < Passenger.Length; i++)
            {
                if(Passenger[i] != null)
                {
                    Console.WriteLine("[" + (i+1) + "] "+Passenger[i].Name);
                }
            }
        }

        public string findAge(int age)
        {
            for(int i = 0; i < Passenger.Length; i++)
            {
                if(Passenger[i] != null) { 
                    if(Passenger[i].Age == age)
                    {
                    return Passenger[i].Name;
                    }
                }
            }
            return "Det finns ingen passagerare med den angivna åldern.";
            
        }

        public void totalAge()
        {
            int totalAge = 0;
            for(int i = 0; i < Passenger.Length; i++)
            {
                if(Passenger[i] != null)
                {
                    totalAge += Passenger[i].Age;
                }
            }

            Console.WriteLine("Totala åldern för alla passagerare är: " + totalAge);
        }


        public void averageAge()
        {
            //variables for calculations
            int averageAgeCalculation = 0;
            int totalAge = 0;
            //list to store ages in
            List<int> averageAge = new List<int>();
            //for loop through the passenger array
            for(int i = 0; i < Passenger.Length; i++)
            {
                //if the passenger array on index i is not null
                if(Passenger[i] != null)
                {
                    //add passengers age to the list.
                    averageAge.Add(Passenger[i].Age);
                }
            }
            //foreach age in the list
            foreach(int age in averageAge)
            {
                //if the age is not null in the list. add it to totalAge
                if(age != null) { 
                totalAge += age;
                }
            }
            //calculate average age.
            averageAgeCalculation = (totalAge / averageAge.Count);
            //print average age.
            Console.WriteLine(averageAgeCalculation);
        }

        //getters and setters
        Person[] Passenger { get => passenger; set => passenger = value; }

    }

   

  


}
