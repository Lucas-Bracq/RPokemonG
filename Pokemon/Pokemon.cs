using UnityEngine;

namespace RPokemonG {

	class Pokemon : MonoBehaviour {
		private string espece;
		private Type type;
		private string description;

		private Nature nature;
		private Talent talent;
		private Statut statut;

		//etat = 1 vivant
		//etat = 0 KO
		private bool etat;

		private int pvBase;
		private int attaqueBase;
		private int attaqueSpeBase;
		private int defenseBase;
		private int defenseSpeBase;
		private int vitesseBase;

		private int currPv;
		private int currAttaque;
		private int currAttaqueSpe;
		private int currDefense;
		private int currDefenseSpe;
		private int currVitesse; 

		public Pokemon (int pv, int attaque, int attaqueSpe, int defense, int defenseSpe, int vitesse, PokemonType type, string espece, Talent talent, Nature nature, string description){

			this.currPv = pv;
			this.currAttaque = attaque;
            this.currAttaqueSpe = attaqueSpe;
            this.currDefense = defense;
            this.currDefenseSpe = defenseSpe;
            this.currVitesse = vitesse;

            this.talent = talent;
			this.type = type;

			this.etat = 1;
			this.statut = Statut.nul;

			this.espece = espece;

		}

		public void attaquer(Capacite capacite, Pokemon cible){
			capacite.utiliser(cible);
		}

		public void setStat(Nature nature){
			this.currPv = this.pvBase + 5 + 60 ;
			this.currAttaque = (this.attaqueBase + 5)* nature.getEffet()[0];
			this.currDefense = (this.defenseBase + 5)* nature.getEffet()[1];
			this.currVitesse = (this.vitesseBase + 5)* nature.getEffet()[2];
			this.currAttaqueSpe = (this.attaqueSpeBase + 5)* nature.getEffet()[3];
			this.currDefenseSpe = (this.defenseSpeBase + 5)* nature.getEffet()[4];
		}

		public int getCurrPv(){
	        return currPv;
	    }

	    public void setCurrPv(int pv){
	    	this.currPv = pv;  
	    }

	    public int getCurrAttaque(){
	    	return currAttaque;
	    }

	    public void setCurrAttaque(int attaque){
	    	this.currAttaque = attaque;
	    }

	    public int getCurrAttaqueSpe(){
	    	return currAttaqueSpe;
	    }

	    public void setCurrAttaqueSpe(int attaqueSpe){
	    	this.currAttaqueSpe = attaqueSpe;
	    }

	    public int getCurrDefense(){
	    	return currDefense;
	    }

	    public void setCurrDefense(int defense){
	    	this.currDefense = defense;
	    }

	    public int getCurrDefenseSpe(){
	    	return currDefense;
	    }

	    public void setCurrDefenseSpe(int defenseSpe){
	    	this.currDefenseSpe = defenseSpe;
	    }

	    public int getCurrVitesse(){
	    	return currVitesse;
	    }

	    public void setCurrVitesse(int vitesse){
	    	this.currVitesse = vitesse;
	    }

	    public String getEspece() {
	        return espece;
	    }

	    public Type getType() {
	        return type;
	    }

	    public String getDescription() {
	        return description;
	    }

	    public Nature getNature() {
	        return nature;
	    }

	    public Talent getTalent() { 
	    	return talent; 
	    }

	    public void setTalent (Talent talent) {
	     this.talent = talent;
	    }

	    public Statut getStatut() { 
	    	return statut; 
	    }

	    public void setStatut(Statut statut) { 
	    	this.statut = statut; 
	    }

	    public bool getEtat() { 
	    	return etat; 
	    }

	    public void setEtat(bool etat) {
	    	this.etat = etat;
	    }

	}

	enum Statut {
		nul,
		poison,
		paralysie,
		gel,
		brulure
	}
}