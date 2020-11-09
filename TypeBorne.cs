using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Crab
{
    class TypeBorne
    {
        private string codeTypeBorne;
        private int dureeRevision;
        /// <summary>
        /// nombre de jours qui séparent deux révisions successives d'une borne de ce type
        /// </summary>
        private int nbJoursEntreRevisions;
        /// <summary>
        /// nombre d'unités de recharge au-delà duquel il faut envisager une nouvelle révision
        /// </summary>
        private int nbUnitesEntreRevisions;
        public TypeBorne(string codeTypeBorne, int dureeRevision, int nbJours, int nbUnites)
        {
            this.nbJoursEntreRevisions = nbJours;
            this.codeTypeBorne = codeTypeBorne;
            this.dureeRevision = dureeRevision;
            this.nbUnitesEntreRevisions = nbUnites;
        }
        public int getDureeRevision() { return this.dureeRevision; }
        public int getNbJoursEntreRevisions() {return this.nbJoursEntreRevisions; }
        public int getNbUnitesEntreRevisions() { return this.nbUnitesEntreRevisions; }
    }
}
