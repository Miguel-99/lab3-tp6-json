using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_tp6_json.model {
    class Book {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Anio_publicacion { get; set; }
        public string Editorial { get; set; }
        public int IdAuthor { get; set; }
    }
}
