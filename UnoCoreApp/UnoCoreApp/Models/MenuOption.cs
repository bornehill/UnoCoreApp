using System;
using System.Collections.Generic;
using System.Text;
using UnoCoreApp.Views;

namespace UnoCoreApp.Models
{
    public class MenuOption
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int Nivel { get; set; }
        public string GroupName { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ParentId { get; set; }
        public string ImageName { get; set; }
        public string GoForm { get; set; }
    }
}
