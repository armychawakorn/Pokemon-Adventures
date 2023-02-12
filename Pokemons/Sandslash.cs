using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame
{
    public class Sandslash : Character
    {
        public Sandslash()
        {
            float _HP = this.RandomHP();
            float _Damage = this.RandomDamage();
            this
            .SetData(EDataType.Name, "Sandslash")
            .SetData(EDataType.Damage, _Damage)
            .SetData(EDataType.HP, _HP)
            .SetData(EDataType.MaxHP, _HP)
            .SetData(EDataType.Image, Properties.Resources.Sandslash);
        }

    }
}
