using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kod_1.Entity
{
    public class Star
    {

        public int StarId { get; set; }
        public int StarValue { get; set; }
        public Movie Movies { get; set; }
        public int MovieId { get; set; }
        public int Ortalama { get; set; }
    }
}
