using Octopath2RandomizerTracker.Commands;
using Octopath2RandomizerTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace Octopath2RandomizerTracker.ViewModels
{
    public class KeyItemViewModel : ViewModelBase {
        private readonly KeyItem _keyItem;
        public String Image => _keyItem.Image;
        public String Tooltip => _keyItem.Tooltip;
        public int CheckCounter => _keyItem.CheckCounter;
        public int ReceivedCounter => _keyItem.ReceivedCounter;

        public ICommand CheckedIncreaseCommand { get; }
        public ICommand CheckedDecreaseCommand { get; }
        public ICommand ReceivedIncreaseCommand { get; }
        public ICommand ReceivedDecreaseCommand { get; }

        public KeyItemViewModel(KeyItem keyItem) {
            _keyItem = keyItem;
            CheckedIncreaseCommand = new CheckedButtonCommand(this, true);
            CheckedDecreaseCommand = new CheckedButtonCommand(this, false);
            ReceivedIncreaseCommand = new ReceivedButtonCommand(this, true);
            ReceivedDecreaseCommand = new ReceivedButtonCommand(this, false);
        }

        public void IncrementCheckCounter() { _keyItem.IncrementCheckCounter(); OnPropertyChanged(nameof(CheckCounter)); }
        public void IncrementReceivedCounter() { _keyItem.IncrementReceivedCounter(); OnPropertyChanged(nameof(ReceivedCounter)); }
        public void DecrementCheckCounter() { _keyItem.DecrementCheckCounter(); OnPropertyChanged(nameof(CheckCounter)); }
        public void DecrementReceivedCounter() { _keyItem.DecrementReceivedCounter(); OnPropertyChanged(nameof(ReceivedCounter)); }
    }
}
