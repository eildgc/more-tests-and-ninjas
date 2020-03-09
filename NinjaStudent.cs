using System;

namespace more_tests_and_ninjas {
class NinjaStudent : Target {

        private bool dead = false;
        public void Shot() {
            this.dead = true;
        }
        public bool IsDead() {
            return this.dead;
        }
    }
}