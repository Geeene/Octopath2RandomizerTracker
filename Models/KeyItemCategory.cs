using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octopath2RandomizerTracker.Models
{
    public class KeyItemCategory(String category)
    {
        public String categoryName = category;
        public List<KeyItem> keyItems = [];

        public void AddKeyItem(KeyItem item)
        {
            keyItems.Add(item);
        }
    }
}
