using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace HandsOnNonGenericCollections
{
    class Movie
    {
        public int MovoieId { get; set; }
        public string MovieName { get; set; }
        public int Year { get; set; }
        public ArrayList Artists { get; set; }
    }
}
