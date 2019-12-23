using System;
using System.Collections.Generic;
using System.Text;

namespace UnoCoreApp.Models
{
    public class ListMenuView
    {
        public string GroupName { get; set; }
        public string Description { get; set; }
        public List<MenuOption> Options { get; set; }

        public ListMenuView(string gruopName, string description)
        {
            GroupName = gruopName;
            Description = description;
        }
    }
}
