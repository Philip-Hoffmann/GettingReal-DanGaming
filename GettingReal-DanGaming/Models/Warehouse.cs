using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal_DanGaming.Models
{
    public class Warehouse
    {
        private string _name;
        private string _location;


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }
        public void AddCategory(Category category)
        {
            // Method intentionally left empty.
        }

        public static void Remove(Category category)
        {
            // Method intentionally left empty.
        }
    }
}
