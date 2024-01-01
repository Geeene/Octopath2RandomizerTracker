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
    /// <summary>
    /// Key Item View Model for the MVVM pattern. 
    /// </summary>
    public class KeyItemViewModel : ViewModelBase {
        private readonly KeyItem _keyItem;
        public String Image => _keyItem.CurrentImage();
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

        /// <summary>
        /// Increments the Check Counter of the linked KeyItem.
        /// This might also cause the background color and even the Image be updated.
        /// </summary>
        public void IncrementCheckCounter() {
            String currentImage = Image;
            _keyItem.IncrementCheckCounter(); 
            DetermineCheckColor(); 
            OnPropertyChanged(nameof(CheckCounter));
            if (Image != currentImage) {
                OnPropertyChanged(nameof(Image));
            }
            OnPropertyChanged(nameof(CheckBackgroundColor)); 
        }

        /// <summary>
        /// Increments the Received Counter of the linked KeyItem.
        /// This might also cause the background color and even the Image be updated.
        /// </summary>
        public void IncrementReceivedCounter() { 
            String currentImage = Image;
            _keyItem.IncrementReceivedCounter();
            DetermineReceivedColor();
            OnPropertyChanged(nameof(ReceivedCounter));
            if (Image != currentImage) {
                OnPropertyChanged(nameof(Image));
            } 
            OnPropertyChanged(nameof(ReceivedBackgroundColor)); 
        }

        /// <summary>
        /// Decrements the Check Counter of the linked KeyItem.
        /// This might also cause the background color and even the Image be updated.
        /// </summary>
        public void DecrementCheckCounter() {
            String currentImage = Image;
            _keyItem.DecrementCheckCounter(); 
            DetermineCheckColor(); 
            OnPropertyChanged(nameof(CheckCounter));
            if (Image != currentImage) {
                OnPropertyChanged(nameof(Image));
            }
            OnPropertyChanged(nameof(CheckBackgroundColor)); 
        }

        /// <summary>
        /// Decrements the Received Counter of the linked KeyItem.
        /// This might also cause the background color and even the Image be updated.
        /// </summary>
        public void DecrementReceivedCounter() {
            String currentImage = Image;
            _keyItem.DecrementReceivedCounter(); 
            DetermineReceivedColor(); 
            OnPropertyChanged(nameof(ReceivedCounter));
            if (Image != currentImage) { 
                OnPropertyChanged(nameof(Image)); 
            }
            OnPropertyChanged(nameof(ReceivedBackgroundColor)); 
        }


        /// <summary>
        /// Determines the Background Color for the CheckCounter Button. 
        /// It will be LightGreen if the value == MaximumCounterValue AND the MaximumCounterValue does not equal 0.
        /// i.e. it is something checkable and it has been raised to the max value.
        /// 
        /// If the Check Counter value is Larger than 0 AND smaller than the MaximumCountervalue then the color will be Yellow.
        /// Otherwise it is Transparent.
        /// </summary>
        private SolidColorBrush DetermineCheckColor() {
            bool value = _keyItem.CheckCounter == _keyItem.MaximumCounterValueChecks;
            if (value && _keyItem.MaximumCounterValueChecks != 0 ) {
                return Brushes.LightGreen; }
            else if (_keyItem.CheckCounter > 0) { return Brushes.Yellow; }
            return Brushes.Transparent;
        }

        /// <summary>
        /// Determines the Background Color for the ReceivedCounter Button. 
        /// It will be LightGreen if the value == MaximumCounterValue AND the MaximumCounterValue does not equal 0.
        /// i.e. it is something receiveable and it has been raised to the max value.
        /// 
        /// If the Received Counter value is Larger than 0 AND smaller than the MaximumCountervalue then the color will be Yellow.
        /// Otherwise it is Transparent.
        /// </summary>
        private SolidColorBrush DetermineReceivedColor() {
            bool value = _keyItem.ReceivedCounter == _keyItem.MaximumCounterValueReceived;
            if (value) { return Brushes.LightGreen; }
            else if (_keyItem.ReceivedCounter > 0) { return Brushes.Yellow; }
            return Brushes.Transparent;
        }
    }
}
