﻿
using Kelasys.ESR.Utils.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kelasys.ESR.Entity {
    [Table("eleve")]
    public class Eleve : Membre {
        public AnneeEnseignement AnneeEnseignement { get; set; }

        public NiveauxEnseignement NiveauxEnseignement { get; set; }

        public AnneeScolaire AnneeScolaire { get; set; }

    }
}
