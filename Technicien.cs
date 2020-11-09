using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Crab
{
	class Technicien
	{
		private int matricule;
		private string nom;
		private string prenom;
		private List<Visite> lesVisites;
		public Technicien(int matricule, string nom, string prenom)
		{
			this.matricule = matricule;
			this.nom = nom;
			this.prenom = prenom;
			this.lesVisites = new List<Visite>();
		}

		// Calcule le temps total total des visites prevues pour un technicien
		public int getTempsOccupe()
		{
			return 0;


		}//code non fourni 
		public void affecterVisite(Visite visite) { lesVisites.Add(visite); }
		public List<Visite> getLesVisites() { return this.lesVisites; }
	}
}
