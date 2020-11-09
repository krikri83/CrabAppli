using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Crab
{
    class Borne
    {
        private int idBorne;
      // TimeSpan
        private DateTime dateDerniereRevision;
        /// <summary>
        /// nombre d'unités de recharge délivrées depuis la dernière révision, 
        /// ce compteur étant remis à zéro suite à chaque révision
        /// </summary>
        private int indiceCompteurUnites;
        private TypeBorne leType;
        public Borne(int idBorne, DateTime dateDerniere, TypeBorne typeBorne)
        {
            this.idBorne = idBorne;
            this.leType = typeBorne;
            this.dateDerniereRevision = dateDerniere;
        }

		/// <summary>
		///  retourne la durée en minutes requise pour réaliser la révision sur la borne, 
		/// cette durée étant fonction du type de la borne
		/// </summary>
		/// <returns></returns>
		public int getDureeRevision() 
        
        {
            return this.leType.getDureeRevision();
        }
        /// <summary>
        ///  retourne vrai lorsque la borne doit être révisée, soit parce que le temps qui sépare 
        /// deux révisions pour ce type de borne s'est écoulé depuis la date de la dernière révision,
        /// soit parce que le nombre d'unités de recharge délivrées par la borne
        /// depuis la dernière révision a atteint le seuil établi pour ce type de borne ;
        /// retourne faux sinon
        /// </summary>
        /// <returns></returns>
        public bool estaReviser() 
        
        {
			bool ok = false;
			TimeSpan duree = DateTime.Now.Subtract(this.dateDerniereRevision);

			double nbJours = duree.TotalDays;
			
			 if(this.indiceCompteurUnites <= this.leType.getNbUnitesEntreRevisions() || nbJours <= 30)
			{
				ok = true;
			}
			
		   return ok;
        
        }
    }
}
