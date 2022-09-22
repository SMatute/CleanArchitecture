using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Master
{
    public  class AppData : BaseEntity<int>
    {
        public string Nombre { get; set; } = String.Empty;

        public int Edad { get; set; } 

        public string Profesion { get; set; } = String.Empty;



    }
}
