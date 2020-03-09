using System;

namespace gun_master_9000
{
    
    class Character {
        public string name;
        public Gun gun;
        //Metodo especial: Constructor
        //No tienen void, bool, y se llama exactamente igual que el nombre de la clase
        //Se manda a llamar cada vez que alguien quiera hacer una nueva instancia

        public Character(string name) {
            this.name = name;
        }

        public void Equip(Gun gun){
            this.gun = gun;
        }

        //La persona no dispara, jala el gatillo
        public void Shoot(Target target){
            if (this.gun ==null) {
                throw new System.InvalidOperationException("Character can't shoot without a gun.");
            }
            try {
                this.gun.Shoot(target);
            } catch (System.InvalidOperationException ex) {
                Console.WriteLine("*gun clicks*");
            }
            
        }
        public void Reload() {
            if (this.gun ==null) {
                throw new System.InvalidOperationException("Character can't reload without a gun.");
            }
            this.gun.Reload();
        }
    }
}
