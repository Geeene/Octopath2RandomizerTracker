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
    /// Command that is used to select a key item for editing
    /// </summary>
    public class DataEditCommand(KeyItemViewModel keyItem, MainViewModel mainViewModel) : CommandBase
    {
        private readonly KeyItemViewModel _KeyItem = keyItem;
        private readonly MainViewModel _MainViewModel = mainViewModel;

        public override void Execute(object? parameter)
        {
            _KeyItem.ChangeVisibility();
        }
    }
}
