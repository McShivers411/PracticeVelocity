using System;
using System.Windows.Forms;

using PV_Event;

namespace PV_CodingChallenge_WindowsForms
{
    public partial class EventEntry : Form
    {
        public EventEntry()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //POPULATES DROPDOWN LIST AUTOMATICALLY BASED ON ENUM IN EventType.cs
            foreach (var eventType in Enum.GetValues(typeof(EventType))) {
                cmbEventType.Items.Add(eventType.ToString());
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Event currentEvent = new Event(1, "My Event", cmbEventType.SelectedItem.ToString());

            txtOutput.Text = currentEvent.Process();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
