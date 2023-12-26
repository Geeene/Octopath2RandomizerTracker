using Octopath2RandomizerTracker.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octopath2RandomizerTracker.ViewModels
{
    /// <summary>
    /// ViewModel representing a KeyItemCategory.
    /// </summary>
    public class KeyItemCategoryViewModel : ViewModelBase {
        private readonly KeyItemCategory _category;
        public String CategoryName => _category.categoryName;

        private readonly BindingList<KeyItemViewModel> _keyItems;

        public IEnumerable<KeyItemViewModel> KeyItems => _keyItems;

        public KeyItemCategoryViewModel(KeyItemCategory category)
        {
            _category = category;
            _keyItems = [.. _category.keyItems.Select(keyItem => new KeyItemViewModel(keyItem)).ToList()];
        }
    }
}
