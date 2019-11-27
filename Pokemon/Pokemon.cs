namespace RPokemonG {

	abstract class Pokemon {
		protected e_Pokemon espece;
		protected e_Type[] types;
		protected string description;
		protected Nature nature;
		protected e_Talent talent;
		protected e_Statut statut;
		protected int pvBase;
		protected int attaqueBase;
		protected int attaqueSpeBase;
		protected int defenseBase;
		protected int defenseSpeBase;
		protected int vitesseBase;

		private int currPv;
		private int currAttaque;
		private int currAttaqueSpe;
		private int currDefense;
		private int currDefenseSpe;
		private int currVitesse;
		private float precision;
		private float esquive;

		protected Capacite[] capacitesApprenables;
		protected Capacite[] capacitesApprises;

		public void attaquer(Capacite capacite, Pokemon cible, Pokemon lanceur){
			capacite.utiliser(cible, lanceur);
		}

		/*public void setStat(Nature nature){
			this.currPv = this.pvBase + 5 + 60 ;
			this.currAttaque = (this.attaqueBase + 5)* nature.getEffet()[0];
			this.currDefense = (this.defenseBase + 5)* nature.getEffet()[1];
			this.currVitesse = (this.vitesseBase + 5)* nature.getEffet()[2];
			this.currAttaqueSpe = (this.attaqueSpeBase + 5)* nature.getEffet()[3];
			this.currDefenseSpe = (this.defenseSpeBase + 5)* nature.getEffet()[4];
		}*/

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

		public float getPrecision(){
			return precision;
		}

		public void setPrecision(float precision){
			this.precision = precision;
		}

		public float getEsquive(){
			return esquive;
		}

		public void setEsquive(float esquive){
			this.esquive = esquive;
		}
	    public e_Pokemon getEspece() {
	        return espece;
	    }

	    public e_Type[] getType() {
	        return types;
	    }

	    public string getDescription() {
	        return description;
	    }

	    public Nature getNature() {
	        return nature;
	    }

	    public e_Talent getTalent() { 
	    	return talent; 
	    }

	    public void setTalent (e_Talent talent) {
	     this.talent = talent;
	    }

	    public e_Statut getStatut() { 
	    	return statut; 
	    }

	    public void setStatut(e_Statut statut) { 
	    	this.statut = statut; 
	    }

	}
}