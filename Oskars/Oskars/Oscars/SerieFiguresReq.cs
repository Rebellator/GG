using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oskars.Oscars
{
    public class SerieFiguresReq
    {
        public string nameAndSurname { get; set; }
        public string sex { get; set; }
        public int age { get; set; }
        public string town { get; set; }
        public string title { get; set; }
        public int year { get; set; }
        public decimal boxOffice { get; set; }
    }
}
