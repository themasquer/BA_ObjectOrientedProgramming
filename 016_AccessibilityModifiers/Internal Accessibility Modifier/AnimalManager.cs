using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_AccessibilityModifiers.Internal_Accessibility_Modifier
{
    public class AnimalManager
    {
        public void Set()
        {
            Animal animal = new Animal(); // yukarıya ve projeye hiç bir referans eklemeden erişebiliyoruz. aynı assembly'de olması yeterli
            animal.id1_internal = 1;
            animal.Id1_internal = 1;
            animal.SetAnimal();
        }
    }
}
