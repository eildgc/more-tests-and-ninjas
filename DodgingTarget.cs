using System;

namespace more_tests_and_ninjas {
    //Hace todo lo que hace la interfaz target mas otras cosas que haremos aqui
    interface DodgingTarget : Target {
        void Dodge();
        void Hit();
        void Miss();    
    }
}