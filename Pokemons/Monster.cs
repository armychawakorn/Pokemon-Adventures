using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame
{
    public class Monster : Character
    {
        public Monster()
        {
            float _HP = this.RandomHP() * 2;
            float _Damage = this.RandomDamage() * 2;
            this
            .SetData(EDataType.Name, "Pikachu")
            .SetData(EDataType.Damage, _Damage)
            .SetData(EDataType.HP, _HP)
            .SetData(EDataType.MaxHP, _HP)
            .SetData(EDataType.Image, Properties.Resources.Beedrill_Monster_);
        }

    }
}
