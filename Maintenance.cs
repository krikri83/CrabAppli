using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Crab
{
    class Maintenance
    {
        private List<Station> lesStations;
        private List<Technicien> lesTechniciens;
        private List<Visite> lesVisites;
        public Maintenance(List<Station> lesStations,List<Technicien> lesTechniciens,List<Visite> lesVisites )
        {
            this.lesStations = lesStations;
            this.lesTechniciens = lesTechniciens;
            this.lesVisites = lesVisites;
        }

		/// <summary>
		/// Affecte les visites à réaliser aux techniciens, en répartissant équitablement le travail
		/// entre les techniciens. Chaque visite est affectée au technicien le moins occupé en temps
		/// total de maintenance préventive. L'état de chaque visite doit alors être mis à jour.
		/// </summary>
		public void affecterVisites()
        {
			
			foreach(Visite v in this.lesVisites)
			{
				Technicien t = getTechnicienMoinsOccupe();
				if(v.getEtat() =='p')
				{
					t.affecterVisite(v);
					v.changerEtat();
				}
			}
         }

		public Technicien getTechnicienMoinsOccupe()//comment recoupe le minimum
		{
			Technicien t = this.lesTechniciens[0];
			int min = this.lesTechniciens[0].getTempsOccupe();
			foreach(Technicien tech in this.lesTechniciens)
			{
				int temps = tech.getTempsOccupe();
				if (temps < min)
				{
					min = temps;
					t = tech;
				}
			}
			return t;
		}
    }
}
