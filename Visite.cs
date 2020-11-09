using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Crab
{
    class Visite
    {
        /// <summary>
        /// état de la visite : 'p' pour programmée, 'a' pour affectée, 'r' pour réalisée
        /// </summary>
        private char etat;
        /// <summary>
        /// durée totale en minutes requise pour réaliser l'ensemble des révisions
        /// prévues sur les bornes de la station
        /// </summary>
        private int dureeTotale;
        /// <summary>
        /// la station concernée par la visite
        /// </summary>
        private Station laStation;
        /// <summary>
        /// la collection des bornes de la Station concernées par la visite
        /// </summary>
        private List<Borne> lesBornes;
        /// <summary>
        /// ce constructeur valorise tous les attributs privés de la classe Visite, y compris l'état et la 
        /// durée totale de la visite
        /// </summary>
        /// <param name="lesBornesAVisiter"></param>
        /// <param name="uneStation"></param>
        public Visite(List<Borne> lesBornesAVisiter, Station uneStation)
        {
            this.etat = 'p';
            this.lesBornes = lesBornesAVisiter;
            this.laStation =  uneStation;
            this.dureeTotale = 0;
        }

		public int getDureeTotale() { return this.dureeTotale; }
        public char getEtat() { return this.etat; }
        /// <summary>
        /// modifie l'état de la visite, de 'p' programmée à 'a' affectée, ou de 'a' affectée à 'r' réalisée
        /// </summary>
        public void changerEtat() {

			if (this.etat == 'p')
				this.etat = 'a';
			if(this.etat == 'a')
				this.etat = 'r';
        }
    }
}
