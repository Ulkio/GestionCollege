using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCollege.MODEL
{
    class Etudiant
    {
        public int idEtudiant { get; set; }
        public DateTime dateEntreeEtudiant { get; set; }
        public string nomEtudiant { get; set; }
        public string prenomEtudiant { get; set; }
        public string telEtudiant { get; set; }
        public string mailEtudiant { get; set; }
    }
}
