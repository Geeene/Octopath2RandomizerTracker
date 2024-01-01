using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Octopath2RandomizerTracker.Models
{
    /// <summary>
    /// Model Representing a KeyItem
    /// </summary>
    /// <param name="images"></param>
    /// <param name="tooltip"></param>
    public class KeyItem(List<String> images, String tooltip)
    {
        public List<String> Images { get; set; } = images;
        public String Tooltip { get; } = tooltip;
        public int CheckCounter { get; set; } = 0;
        public int ReceivedCounter { get; set; } = 0;

        public int MaximumCounterValueChecks { get; set; } = 1;
        public int MaximumCounterValueReceived { get; set; } = 1;

        public KeyItem(String images, String tooltip) : this([images], tooltip) { }

        public KeyItem(String images, String tooltip, int maxCounterValue) : this([images], tooltip, maxCounterValue, maxCounterValue) { }

        public KeyItem(List<String> images, String tooltip, int maxCounterValue) : this(images, tooltip, maxCounterValue, maxCounterValue) { }

        public KeyItem(String images, String tooltip, int maxCounterValueChecks, int maxCounterValueReceived) : this([images], tooltip, maxCounterValueChecks, maxCounterValueReceived) { }        
        
        public KeyItem(List<String> images, String tooltip, int maxCounterValueChecks, int maxCounterValueReceived) : this(images, tooltip)
        {
            MaximumCounterValueChecks = maxCounterValueChecks;
            MaximumCounterValueReceived = maxCounterValueReceived;
        }

        /// <summary>
        /// Increases the CheckCounter by 1 if the counter is below the maximum value
        /// </summary>
        public void IncrementCheckCounter() { 
            if (CheckCounter < MaximumCounterValueChecks) { CheckCounter++; } 
        }

        /// <summary>
        /// Increases the ReceivedCounter by 1 if the counter is below the Maximum value
        /// </summary>
        public void IncrementReceivedCounter() { 
            if (ReceivedCounter < MaximumCounterValueReceived) { ReceivedCounter++; } 
        }

        /// <summary>
        /// Decreases the CheckCounter by 1 if the current value is larger than 0
        /// </summary>
        public void DecrementCheckCounter() { 
            if (CheckCounter > 0) { CheckCounter--; } 
        }

        /// <summary>
        /// Decreases the ReceivedCounter by 1 if the current value is larger than 0
        /// </summary>
        public void DecrementReceivedCounter() { 
            if (ReceivedCounter > 0){ ReceivedCounter--; } 
        }

        /// <summary>
        /// Returns a String that represent the current check quantity in the GUI
        /// </summary>
        public String CheckRepresentation() {
            return representation_inner(CheckCounter, MaximumCounterValueChecks);
        }

        /// <summary>
        /// Returns a String that represent the current receive quantity in the GUI
        /// </summary>
        public String ReceivedRepresentation() {
            return representation_inner(ReceivedCounter, MaximumCounterValueReceived);
        }

        /// <summary>
        /// Retruns an Empty String if the given Value is 0 or the same as the given max. This will cause the Button in the GUI to not display a text.
        /// </summary>
        /// <param name="value">The value of how often the KeyItem has been checekd / received</param>
        /// <param name="max">The maximum number of times this KeyItem can be checked / received</param>
        /// <returns></returns>
        private String representation_inner(int value, int max) {
            if (value == 0 || value == max) {
                return String.Empty;
            } else {
                return "" + value;
            }
        }

        public String CurrentImage() {
            if (Images.Count > 1) {
                if (Images.Count == MaximumCounterValueChecks && CheckCounter != 0) {
                    return Images[CheckCounter - 1];
                } else if (Images.Count == MaximumCounterValueReceived && ReceivedCounter != 0) {
                    return Images[ReceivedCounter - 1];
                }
            }
            return Images[0];
        }
    }
}
