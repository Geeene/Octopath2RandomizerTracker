using Octopath2RandomizerTracker.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octopath2RandomizerTracker.Commands
{
    /// <summary>
    /// Command that will be used for incrementing the checked counter for a KeyItem
    /// </summary>
    public class CheckedButtonCommand(KeyItemViewModel keyItem, bool isIncrease) : CommandBase
    {

        private readonly KeyItemViewModel _keyItemViewModel = keyItem;
        private readonly bool _isIncrease = isIncrease;

        public override void Execute(object? parameter)
        {
            if (_isIncrease) {
                _keyItemViewModel.IncrementCheckCounter();
            } else {
                _keyItemViewModel.DecrementCheckCounter();
            }
        }
    }
}
