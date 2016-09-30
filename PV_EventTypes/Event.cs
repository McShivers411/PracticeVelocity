namespace PV_Event
{
    //THIS CLASS DEFINES THE "EVENT" OBJECT
    public class Event : IEvent
    {
        //CONSTRUCTORS
        public Event(int ID, string Name, string eventType)
        {
            this._ID = ID;
            this._Name = Name;

            if (eventType.ToLower() == "register") {
                this._EventType = EventType.Register;
            }
            else if (eventType.ToLower() == "diagnose") {
                this._EventType = EventType.Diagnose;
            }
        }


        //PROPERTIES
        private int _ID;
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private EventType _EventType;
        public EventType Event_Type
        {
            get { return _EventType; }
            set { _EventType = value; }
        }


        //GENERIC PROCESS EVENT METHOD THAT DETERMINES CORRECT
        //HANDLING BASED ON THE EVENT TYPE
        public string Process()
        {
            if (this.Event_Type == EventType.Register) {
                return ProcessRegister();
            }
            else if(this.Event_Type == EventType.Diagnose) {
                return ProcessDiagnose();
            }
            else {
                return "Type is not supported at this time :(";
            }
        }


        //PROCESS METHODS FOR INDIVIDUAL EVENT TYPES
        protected string ProcessDiagnose()
        {
            string returnValue = "";
            int low = 2;
            int high = 7;
            
            for (int i = 1; i <= 100; i++) {
                if (i % low == 0 && i % high == 0) { returnValue += "Diagnose Patient\r\n"; }
                else if (i % high == 0) { returnValue += "Patient\r\n"; }
                else if (i % low == 0) { returnValue += "Diagnose\r\n"; }                
                else returnValue += i.ToString() + "\r\n";
            }

            return returnValue;
        }

        protected string ProcessRegister()
        {
            string returnValue = "";
            int low = 3;
            int high = 5;

            for (int i = 1; i <= 100; i++)
            {
                if (i % low == 0 && i % high == 0) { returnValue += "Register Patient\r\n"; }
                else if (i % high == 0) { returnValue += "Patient\r\n"; }
                else if (i % low == 0) { returnValue += "Register\r\n"; }
                else returnValue += i.ToString() + "\r\n";
            }

            return returnValue;
        }
    }
}
