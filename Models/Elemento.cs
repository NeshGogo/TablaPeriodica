using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TablaPeriodica.Models
{
    public class Elemento
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Initials { get; set; }
        public CategorisEnum Category { get; set; }
        public int Orden { get; set; }
    }
}

namespace TablaPeriodica
{
    public enum CategorisEnum
    {
        Alcalinos,
        Alcalinoterreos,
        BloqueD,
        Lantanidos,
        Actinidos,
        OtrosMetales,
        Metaloides,
        OtrosNoMetales,
        Halogenos,
        GasesNobles
    }
}