using System;
using System.Collections.Generic;
using System.Text;

namespace Bussen
{
    class Bus
    {
        //variables
        private Person[] passenger = new Person[5];

        //constructor
        public Bus()
        {

        }
        //add passenger method.
        public void addPassenger(Person p)
        {
            //calls the getEmptyIndex function to get index of an empty container to save the person object into.
            Passenger[getEmptyIndex()] = p;
            
        }
        //check if bus is full
        public bool checkIfBusIsFull()
        {
            //loop through the passenger array
           for(int i = 0; i < Passenger.Length; i++)
            {
                //if an index is null then a seat is open and return false
                if(Passenger[i] == null)
                {
                    return false;
                }
               
            }
           //else return true
            return true;
        }
        //returns index of an empty slot
        public int getEmptyIndex()
        {
            //loop through passenger array
            for(int i = 0; i < Passenger.Length; i++)
            {
                //if the index in the passenger array is null
                if(Passenger[i] == null)
                {
                    //return index position of i
                    return i;
                }
            }
            //else return 500
            return 500;
        }
        //print out all passengers
        public void printPassengers()
        {
            //loop through passenger array
            for(int i = 0; i < Passenger.Length; i++)
            {
                //print aslong the array index is not null.
                if(Passenger[i] != null) {
                Console.WriteLine(Passenger[i].Name);
                }
            }
            //make the user press a key + enter or just enter to continue..
            Console.WriteLine("");
            Console.WriteLine("Tryck på valfri tangent + ENTER för att återvända till menyn....");
            Console.ReadLine();
         
        }
        //remove passenger based on index method
        public void removePassenger(int index)
        {
            //passenger index get set to null
            Passenger[index] = null;
            
        }
        //print removable passengers method
        public void removablePassengers()
        {
            //for loop the passenger array
            for(int i = 0; i < Passenger.Length; i++)
            {
                //print every index in the passenger array aslong it is not null
                if(Passenger[i] != null)
                {
                    //i+1 makes the index of the array look more realistic like [1][2][3] instead of [0][1][2]
                    Console.WriteLine("[" + (i+1) + "] "+Passenger[i].Name);
                }
            }
        }
        //find age based on age method
        public string findAge(int age)
        {
            //loop through passenger array. 
            for(int i = 0; i < Passenger.Length; i++)
            {
                //if array index is not null
                if(Passenger[i] != null) { 
                    //if passengers age on index i == age
                    if(Passenger[i].Age == age)
                    {
                        //return the name of the person with that age
                    return Passenger[i].Name;
                    }
                }
            }
            //else return messeage that passenger doesnt exist with that age
            return "Det finns ingen passagerare med den angivna åldern.";
            
        }
        //total age method
        public void totalAge()
        {
            //variable
            int totalAge = 0;
            //loop through passenger array. 
            for (int i = 0; i < Passenger.Length; i++)
            {
                //if array index is not null
                if(Passenger[i] != null)
                {
                    //add passengers age on index i to totalAge variable
                    totalAge += Passenger[i].Age;
                }
            }
            //print out total age of all passengers
            Console.WriteLine("Totala åldern för alla passagerare är: " + totalAge);
        }

        //average age function
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
