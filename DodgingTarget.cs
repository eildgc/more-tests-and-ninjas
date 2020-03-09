using System;

namespace gun_master_9000 {
    //Hace todo lo que hace la interfaz target mas otras cosas que haremos aqui
    interface DodgingTarget : Target {
        void Dodge();
        void Hit();
        void Miss();    
    }
}