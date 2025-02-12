using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoArquit.Shared.Entities
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Specialty { get; set; } = null!;
        public string Hospital { get; set; } = null!;
    }
}
