using System;

namespace more_tests_and_ninjas {
    class Boss : DodgingTarget,MoreLives {

        bool isDodging = false;
        bool dead = false;
        int lives = 1;
        public void LivesQuantity(int lives){
            this.lives = lives;
        }
        public void Shot() {
            lives -= 1;
            if (lives == 0){
                this.dead = true;
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
    }
}