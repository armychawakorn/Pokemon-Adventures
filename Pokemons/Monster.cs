using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame
{
    public class Monster : Character
    {
        readonly float _HP = 650 * 3;
        readonly float _Damage = 90;
        public Monster()
        {
            this
            .SetData(EDataType.Name, "Pikachu")
            .SetData(EDataType.Damage, _Damage)
            .SetData(EDataType.HP, _HP)
            .SetData(EDataType.MaxHP, _HP)
            .SetData(EDataType.Image, Properties.Resources.Beedrill_Monster_);
        }

    }
}
