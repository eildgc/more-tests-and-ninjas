using System;

namespace gun_master_9000 {
    //No tiene que ver conuna interface visual.
    //Esta interface te permite decir que es lo que deberia de tener sin decir el como
    //A todos los targets les puedes disparar y revisar si estan muertos
    //Tiene una caracteristica diferente a la clase por ser Interface, no define funcionalidad
    //Cualquier cosa puede ser un target, porque conceptualmente la interfaz no ata como gun a las guns.
    interface Target{
        void Shot ();
        bool IsDead();

    }
}