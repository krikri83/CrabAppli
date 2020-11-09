using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Crab
{
	class Station
	{
		private int idStation;
		private string libelleEmplacement;
		private List<Borne> lesBornes;
		public Station(int idStation, string libelle, List<Borne> desBornes)
		{
			this.idStation = idStation;
			this.lesBornes = desBornes;
			this.libelleEmplacement = libelle;
		}

		public int getId() { return this.idStation; }
		public string getLibelleEmplacement() { return this.libelleEmplacement; }
		/// <summary>
		/// retourne une instance de classe Visite recensant toutes les bornes de la station 
		/// qui nécessitent d'être révisées, ou null s'il n'y a aucune borne à réviser
		/// </summary>
		public Visite getVisiteAfaire()
		{
			
			List<Borne> list = new List<Borne>();
			foreach (Borne b in this.lesBornes)
			{
				if (b.estaReviser() == true)
				{
					list.Add(b);
				}
			}
			Visite v = new Visite(list, this);
			return v;
		}
	}
}
