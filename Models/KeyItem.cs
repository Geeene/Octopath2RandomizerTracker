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

        public int MaximumCounterValue { get; set; } = 1;

        public KeyItem(String image, String tooltip, int maxCounterValue) : this(image, tooltip) { 
            MaximumCounterValue = maxCounterValue;
        }

        public void IncrementCheckCounter() { 
            if (CheckCounter < MaximumCounterValue) { CheckCounter++; } 
        }
        public void IncrementReceivedCounter() { 
            if (ReceivedCounter < MaximumCounterValue) { ReceivedCounter++; } 
        }
        public void DecrementCheckCounter() { 
            if (CheckCounter > 0) { CheckCounter--; } 
        }
        public void DecrementReceivedCounter() { 
            if (ReceivedCounter > 0){ ReceivedCounter--; } 
        }
    }
}
