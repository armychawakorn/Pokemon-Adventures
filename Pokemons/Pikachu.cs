using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame
{
    public class Pikachu : Character
    {
        readonly float _HP = 350;
        readonly float _Damage = 55;
        public Pikachu()
        {
            this
            .SetData(EDataType.Name, "Pikachu")
            .SetData(EDataType.Damage, _Damage)
            .SetData(EDataType.HP, _HP)
            .SetData(EDataType.MaxHP, _HP)
            .SetData(EDataType.Image, Properties.Resources.Pikachu);
        }

    }
}
