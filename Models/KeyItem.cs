using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Octopath2RandomizerTracker.Models
{
    public class KeyItem(String image, String tooltip)
    {
        public String Image { get; } = image;
        public String Tooltip { get; } = tooltip;
        public int CheckCounter { get; set; } = 0;
        public int ReceivedCounter { get; set; } = 0;

        public int MaximumCounterValueChecks { get; set; } = 1;
        public int MaximumCounterValueReceived { get; set; } = 1;

        public KeyItem(String image, String tooltip, int maxCounterValue) : this(image, tooltip) {
            MaximumCounterValueChecks = maxCounterValue;
            MaximumCounterValueReceived = maxCounterValue;
        }
        public KeyItem(String image, String tooltip, int maxCounterValueChecks, int maxCounterValueReceived) : this(image, tooltip)
        {
            MaximumCounterValueChecks = maxCounterValueChecks;
            MaximumCounterValueReceived = maxCounterValueReceived;
        }

        public void IncrementCheckCounter() { 
            if (CheckCounter < MaximumCounterValueChecks) { CheckCounter++; } 
        }
        public void IncrementReceivedCounter() { 
            if (ReceivedCounter < MaximumCounterValueReceived) { ReceivedCounter++; } 
        }
        public void DecrementCheckCounter() { 
            if (CheckCounter > 0) { CheckCounter--; } 
        }
        public void DecrementReceivedCounter() { 
            if (ReceivedCounter > 0){ ReceivedCounter--; } 
        }

        public String CheckRepresentation() {
            return representation_inner(CheckCounter, MaximumCounterValueChecks);
        }

        public String ReceivedRepresentation() {
            return representation_inner(ReceivedCounter, MaximumCounterValueReceived);
        }

        private String representation_inner(int value, int max) {
            if (value == 0 || value == max) {
                return String.Empty;
            } else {
                return "" + value;
            }
        }
    }
}
