using Octopath2RandomizerTracker.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Octopath2RandomizerTracker.Commands
{
    /// <summary>
    /// Command that will be used for incrementing the checked counter for a KeyItem
    /// </summary>
    public class ReceivedButtonCommand(KeyItemViewModel keyItem, bool isIncrease) : CommandBase
    {
        private readonly KeyItemViewModel _keyItemViewModel = keyItem;

        private readonly bool _isIncrease = isIncrease;

        public override void Execute(object? parameter)
        {
            if (_isIncrease) {
                _keyItemViewModel.IncrementReceivedCounter();
            } else { 
                _keyItemViewModel.DecrementReceivedCounter();
            }
        }
    }
}
