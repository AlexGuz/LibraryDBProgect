using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDBProgect
{
    public class Autor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public ICollection<Book> Books { get; set; }  
        public string AutorName { get { return $"{Name} {Surname}"; } }     

        public Autor()
        {
            Books = new List<Book>();
        }
        public override string ToString()
        {
            return AutorName;
        }
    }
}
