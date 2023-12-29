using Octopath2RandomizerTracker.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Octopath2RandomizerTracker.ViewModels
{
    /// <summary>
    /// View Model that either groups together multiple KeyItemCategorys or multiple ParentKeyItemCategories.
    /// Used to not need to define a separate Property for each Characters main Story / each regions Sidestories etc.
    /// </summary>
    public class ParentKeyItemCategoryViewModel: ViewModelBase {

        private String _CategoryName { get; }
        public String CategoryName => _CategoryName;

        private readonly ObservableCollection<KeyItemCategoryViewModel> _SubCategories = [];
        private readonly ObservableCollection<ParentKeyItemCategoryViewModel> _SubParentCategories = [];
        public IEnumerable<KeyItemCategoryViewModel> SubCategories => _SubCategories;
        public IEnumerable<ParentKeyItemCategoryViewModel> SubParentCategories => _SubParentCategories;
        public ICommand ChangeVisibilityCommand { get; }

        public ParentKeyItemCategoryViewModel(String parentCategoryName) { 
            _CategoryName = parentCategoryName; 
            ChangeVisibilityCommand = new ChangeVisibilityCommand(this); 
        }

        public void AddSubcategory(KeyItemCategoryViewModel category) { 
            _SubCategories.Add(category);
        }

        public void AddSubParentCategory(ParentKeyItemCategoryViewModel category)
        {
            if (this != category && !category.SubParentCategories.Contains(this)) {
                _SubParentCategories.Add(category);
            }
        }
    }
}
