using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDSssionSimple {
    public class Participant {

        private int id;
        private String nom;
        private String mail;
        private float balance;

       
         public Participant(int id,string name, string email, float balance)
         {
            this.id = id;
            this.nom = name;
            this.mail = email;
            this.balance = balance;
        }
        public Participant(int id, string name, string email) {
            this.id = id;
            this.nom = name;
            this.mail = email;
            this.balance = 0;
        }


        public int GetId() {
            return this.id;
        }
     
        public string GetNom()
        {
            return this.nom;
        }
        public float GetBalance() {
            return this.balance;
        }
        public void SetNom(string nom) { // A SUPRIMER
            this.nom = nom;
        }
        public string GetMail()
        {
            return this.mail;
        }
        
      
        public override string ToString()
        {
            return ""+ this.id+ '/'+ this.nom + '/' +this.mail + '/' + balance;
        }
        public override bool Equals(object autre) // return true si this et autre ont le même nom
        {
            //vérificationnon  nullité et type Participant de l'objet autre
            if ((autre == null) || !this.GetType().Equals(autre.GetType()))
            {
                return false;
            }
            else
            {
                Participant p = (Participant)autre;
                return (nom.Equals(p.nom)); // this et autre ont-ils bien le même nom ?
            }
        }
       
    }
}
