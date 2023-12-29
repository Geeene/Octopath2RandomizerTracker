using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octopath2RandomizerTracker.ViewModels
{
    public class ParentKeyItemCategoryViewModel {
        private readonly ObservableCollection<KeyItemCategoryViewModel> _items = [];
        public IEnumerable<KeyItemCategoryViewModel> SubCategories => _items;

        public void AddSubcategory(KeyItemCategoryViewModel category) { 
            _items.Add(category);
        }
    }
}
