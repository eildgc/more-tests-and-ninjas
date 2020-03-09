using System;

namespace more_tests_and_ninjas {
class NinjaStudent : DodgingTarget {

        bool isDodging = false;

        bool dead = false;
        public void Shot() {
            if (this.isDodging) {
                this.Miss();
            }else {
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
            this.isDodging  = false;

        }

        public void MissingDodging(){
            Random r = new Random();
            int dodgingOpportunity = (int)Math.Floor(r.NextDouble() * 2);
            if (dodgingOpportunity == 2) {
                this.Dodge();
                Console.WriteLine("Ninja Student dodged!");
            } else {
                this.Miss();
                Console.WriteLine("Ninja Student was hit!");
            }

        }

        public void MissingDodging2(){
            if (this.isDodging = true){
                this.isDodging = false;
            } else {
                this.isDodging = true;
            }
        }
    }
}