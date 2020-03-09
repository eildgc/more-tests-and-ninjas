using System;

namespace more_tests_and_ninjas {
class NinjaStudent : DodgingTarget {

        bool isDodging = false;

        bool dead = false;
        public void Shot() {
            if (this.isDodging) {
                this.Miss();
            } else {
                this.Hit(); 
            }
        }
        public bool IsDead() {
            return dead;
        }
        public void Dodge() {
            this.isDodging = true;
        }
        public void Hit() {
            this.dead = true;
        }
        public void Miss() {
        }

        public void MissingDodging(){
            Random r = new Random();
            int dodgingOpportunity = (int)Math.Floor(r.NextDouble() * 2);
            if (dodgingOpportunity == 1) {
                this.isDodging = true;
            } else {
                this.isDodging = false;
            }
        }
        public void MissingDodging2(){
            if (this.isDodging == true){
                this.isDodging = false;
            } else {
                this.isDodging = true;
            }
        }
    }
}