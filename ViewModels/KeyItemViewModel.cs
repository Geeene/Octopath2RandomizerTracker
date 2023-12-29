using Octopath2RandomizerTracker.Commands;
using Octopath2RandomizerTracker.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Octopath2RandomizerTracker.ViewModels
{
    public class KeyItemViewModel : ViewModelBase {
        private readonly KeyItem _keyItem;
        public String Image => _keyItem.Image;
        public String Tooltip => _keyItem.Tooltip;
        public String CheckCounter => _keyItem.CheckRepresentation();
        public String ReceivedCounter => _keyItem.ReceivedRepresentation();

        public Brush CheckBackgroundColor => DetermineCheckColor();
        public Brush ReceivedBackgroundColor => DetermineReceivedColor();


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

        public void IncrementCheckCounter() { _keyItem.IncrementCheckCounter(); DetermineCheckColor(); OnPropertyChanged(nameof(CheckCounter)); OnPropertyChanged(nameof(CheckBackgroundColor)); }
        public void IncrementReceivedCounter() { _keyItem.IncrementReceivedCounter(); DetermineReceivedColor(); OnPropertyChanged(nameof(ReceivedCounter)); OnPropertyChanged(nameof(ReceivedBackgroundColor)); }
        public void DecrementCheckCounter() { _keyItem.DecrementCheckCounter(); DetermineCheckColor(); OnPropertyChanged(nameof(CheckCounter)); OnPropertyChanged(nameof(CheckBackgroundColor)); }
        public void DecrementReceivedCounter() { _keyItem.DecrementReceivedCounter(); DetermineReceivedColor(); OnPropertyChanged(nameof(ReceivedCounter)); OnPropertyChanged(nameof(ReceivedBackgroundColor)); }


        private SolidColorBrush DetermineCheckColor() {
            bool value = _keyItem.CheckCounter == _keyItem.MaximumCounterValueChecks;
            if (value && _keyItem.MaximumCounterValueChecks != 0 ){ return Brushes.LightGreen; }
            else if (_keyItem.CheckCounter > 0) { return Brushes.Yellow; }
            return Brushes.Transparent;
        }

        private SolidColorBrush DetermineReceivedColor() {
            bool value = _keyItem.ReceivedCounter == _keyItem.MaximumCounterValueReceived;
            if (value) { return Brushes.LightGreen; }
            else if (_keyItem.ReceivedCounter > 0) { return Brushes.Yellow; }
            return Brushes.Transparent;
        }
    }
}
