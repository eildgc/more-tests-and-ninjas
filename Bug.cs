using System;

namespace gun_master_9000 {
    //Bug es un target
    //La itnerface en Target pone las reglas
    class Bug : Target {

        private bool dead = false;
        public void Shot() {
            this.dead = true;
        }
        public bool IsDead() {
            return this.dead;
        }
    }
}