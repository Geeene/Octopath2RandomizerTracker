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
    /// Command that is used when double clicking on the name of a category and will trigger that Category to be come hidden.
    /// </summary>
    public class ChangeVisibilityCommand(ViewModelBase keyItem) : CommandBase
    {
        private readonly ViewModelBase _viewModel = keyItem;


        public override void Execute(object? parameter)
        {
            _viewModel.ChangeVisibility();
        }
    }
}
