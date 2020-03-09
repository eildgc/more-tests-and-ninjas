using System;

namespace more_tests_and_ninjas {
    class Minigun : Gun {
        //Gun es la clase padre y Minigun es el children
        public Minigun(string name, int capacity) : base(name, capacity) {
            this.rounds = capacity;

        }
        //this is ely's code
        override public void Reload(){
            throw new System.InvalidOperationException("Minigun can't be reloaded");

        }
    }
}