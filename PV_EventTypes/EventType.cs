using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV_Event
{
    //THIS ENUMERATOR DEFINES THE DIFFERENT TYPES OF EVENTS TO BE HANDLED
    //NOTE: THIS PREVENTS ADDITIONAL TYPES FROM BEING ENTERED MANUALLY
    //      BY THE USER AND REDUCES ERRORS/BUGS BY REMOVING THE NEED
    //      TO PARSE STRINGS OR HAVE EXCESSIVE CONDITION STATEMENTS
    public enum EventType
    {
        //ADD NEW EVENT TYPES HERE
        Register,
        Diagnose
    }
}
