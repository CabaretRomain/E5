using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDSssionSimple {
    public static class Session {

        private static char typeU;
        private static Participant pModif;

        private static FormConnexion fcon;
        private static FormPrinc fprinc;
        private static FormModifParticipant fmodifp;

        private static string selectedCategorie;

        public static char GetTypeU() {
            return typeU;
        }
        public static void SetTypeU(char type) {
            typeU = type;
        }
        public static FormConnexion GetGetFormConnexion() {
            return fcon;
        }
        public static void SetformConnexion(FormConnexion f) {
            fcon = f;
        }
        public static FormPrinc GetFormPrinc() {
            return fprinc;
        }
        public static void SetFormPrinc(FormPrinc f) {
            fprinc = f;

        }
        public static FormModifParticipant GetFormModifParticipant() {
            return fmodifp;
        }
        public static void SetformPrinc(FormModifParticipant f) {
            fmodifp = f;

        }
        public static Participant GetParticipantModif() {
            return pModif;
        }
        public static void SetParticipantModif(Participant p) {
            pModif = p; ;
        }

        // -- Categorie --

        public static string GetSelectedCategorie()
        {
            return selectedCategorie;
        }

        public static void SetSelectedCategorie(string newCategorie)
        {
            selectedCategorie = newCategorie;
        }


    }
}
