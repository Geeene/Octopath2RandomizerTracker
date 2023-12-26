using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octopath2RandomizerTracker.ViewModels
{
    /// <summary>
    /// Common Base class for all View Models, used only to unify the PropertyChangedEventHandler logic, so that it doesn't have to be implemented in each class.
    /// </summary>
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Called to fire an event that a Property of this ViewModel has been changed
        /// </summary>
        /// <param name="propertyName"></param>
        protected void OnPropertyChanged(string? propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
