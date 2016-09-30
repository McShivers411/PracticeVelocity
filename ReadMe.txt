/////////////////////////////////////////////////////////////////

    Practice Velocity - Code Challenge - 2016/09/29
                      Chase Jensen

/////////////////////////////////////////////////////////////////


This program takes an event inputted by the user (from a combobox).  The current supported types are either "register" or "digagnose".
Based on the type selected, the program will output a specific string of text and display it to the user in a textbox.


------------------------------------------
    Programmer Notes:
------------------------------------------

When adding a new event type:
  1) Add it to the enum in EventType.cs
  2) Add a new Process_NewEventType() function to handle the logic for your event type in Event.cs
  3) Add logic to the Process() generic function in Event.cs to handle the processing of your event type.
  4) Add logic to the constructor to handle your new event type.
  
The program will auto-populate the drop down list in the interface based on the types in the enum list.
If a type is not recognized or not handled, the Event object will return error text.
