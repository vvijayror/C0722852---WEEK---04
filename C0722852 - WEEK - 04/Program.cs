using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0722852___WEEK___04
{
    class Program

    {
        static void Main(string[] args)
        {

            Countryside blue = new Countryside();
            blue.Lunch();
        }

        class Village
        {
            // Node is an ADT
            // what KIND of DATA do we need in a NODE?
            public Village nextVillage;
            public Village previousVillage;
            public String VillageName;
            public bool idAstrildeHere = false;

        }
        class Countryside
        {
            Village Maple = new Village();
            Village Toronto = new Village();
            Village Ajax = new Village();
            Village First;
            Village Last;
            Village temp;


            public void Lunch()
            {

                First = Maple;
                Last = Ajax;
                Maple.VillageName = "Maple";
                Maple.nextVillage = Toronto;
                Maple.previousVillage = null;
                Toronto.VillageName = "Toronto";
                Toronto.nextVillage = Ajax;
                Toronto.previousVillage = Maple;
                Ajax.VillageName = "Ajax";
                Ajax.nextVillage = null;
                Ajax.previousVillage = Toronto;

                Console.WriteLine(this.displayMap());
            }

            public string displayMap()
            {
                string listofCities = "";
                //what problem do I need to solve?
                // we need to print ALL the cities in our area


                listofCities = listofCities + First.VillageName;
                temp = First.nextVillage;
                listofCities = listofCities + First.VillageName;

                return listofCities;



            }
        }
    }
}


    
