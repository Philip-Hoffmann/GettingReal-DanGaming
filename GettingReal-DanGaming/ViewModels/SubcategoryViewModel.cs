using GettingReal_DanGaming.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal_DanGaming.ViewModels
{
    public class SubcategoryViewModel
    {
        private Subcategory subcategory;

        public int Id
        {
            get { return subcategory.Id; }
        }

        public string ModelName
        {
            get { return subcategory.ModelName; }
        }

        public string? Manufacturer
        {
            get { return subcategory.Manufacturer; }
        }

        public string Name
        {
            get
            {
                return $"{subcategory.ModelName}, {subcategory.Manufacturer}";
            }
        }

        public SubcategoryViewModel(Subcategory subcategory)
        {
            this.subcategory = subcategory;
        }
    }
}
