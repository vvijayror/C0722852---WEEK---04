=using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0722852___WEEK___04
{
    class Program

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

        public void Lunch()
        {

            Maple.VillageName = "Maple";
            Maple.nextVillage = Toronto;
            Maple.previousVillage = null;
            Toronto.VillageName = "Toronto";
            Toronto.nextVillage = Ajax;
            Toronto.previousVillage = Maple;
            Ajax.VillageName = "Ajax";
            Ajax.nextVillage = null;
            Ajax.previousVillage = Toronto;


        }
    }
}


    
