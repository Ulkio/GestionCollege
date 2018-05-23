using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCollege
{
    class Enseignant
    {
        public string nomEnseignant { get; set; }
        public string prenomEnseignant { get; set; }
        public string telEnseignant { get; set; }
        public string mailEnseignant { get; set; }
        public DateTime dateEnseignant { get; set; }
        public int idEnseignant { get; set; }
        public bool isResponsableEnseignant { get; set; }
    }
}
