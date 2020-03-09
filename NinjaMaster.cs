using System;

namespace more_tests_and_ninjas {
class NinjaMaster : DodgingTarget {

        bool isDodging = true;

        bool dead = false;
        public void Shot() {
                this.Miss();
        }
        public bool IsDead() {
            return dead;
        }
        public void Dodge() {
            this.isDodging = true;
        }

        public void Hit() {
            this.isDodging = true;
        }
        public void Miss() {
            this.isDodging  = true;

        }


    }
}