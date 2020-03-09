using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace gun_master_9000 {
    [TestFixture]
    class UnitTests{

        [Test, Description("Character without Gun can't shoot")]
        public void CharacterWithoutGunTest() {
            Character john = new Character("John");
            Bug bug = new Bug();
            Exception ex = Assert.Throws<System.InvalidOperationException>(
                () => {
                    john.Shoot(bug);
                }
            );
        }
        [Test, Description("Character with Gun and without target can't shoot")]
        public void CharacterWithGunTest() {
            Character john = new Character("John");
            Gun revolver = new Gun("Revolver", 6);
            john.Equip(revolver);
            Exception ex = Assert.Throws<System.ArgumentException>(
                () => {
                    john.Shoot(null);
                }
            );
        }
        [Test, Description("Character with Gun and target can shoot only after reloading")]
        public void CharacterWithoutReloadTest(){
            Character john = new Character("John");
            Gun revolver = new Gun("Revolver", 6);
            john.Equip(revolver);
            Bug bug = new Bug();
            john.Shoot(bug);
            Assert.That(bug.IsDead(), Is.EqualTo(false));


            john.Reload();
            john.Shoot(bug);
            Assert.That(bug.IsDead(), Is.EqualTo(true));    
            }
            [Test, Description ("Minigun can be used as a gun")]
            //This is ely's code
            public void MinigunTest() {
                //Gun[] guns = new Gun[2];
                //new Gun(); 

                List<Gun> guns = new List<Gun>();

                Gun minigun = new Minigun("Minigun MK1", 99999);
                Gun revolver = new Gun("Revolver", 6);
                guns.Add(minigun);
                guns.Add(revolver);

                Bug bug = new Bug();

                guns[0].Shoot(bug);

                Assert.That(bug.IsDead(), Is.EqualTo(true));
                Assert.Throws<System.InvalidOperationException>(
                    () => {
                        guns[0].Reload();
                    }
                );
                guns[1].Reload();

            }

            [Test, Description("Try to shoot a dodging target")]
            public void DodgingTargetTest(){
                Character john = new Character("John");
                Gun revolver = new Gun("Revolver", 6);
                john.Equip(revolver);

                Neo theOne = new Neo();

                john.Reload();
                theOne.Dodge();
                john.Shoot(theOne);
                Assert.That(theOne.IsDead(), Is.EqualTo(false));

                john.Shoot(theOne);
                Assert.That(theOne.IsDead(), Is.EqualTo(true));

            }
    }
}