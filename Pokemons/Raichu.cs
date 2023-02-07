using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame
{
    public class Raichu : Character
    {
        readonly float _HP = 600;
        readonly float _Damage = 90;
        public Raichu()
        {
            this
            .SetData(EDataType.Name, "Raichu")
            .SetData(EDataType.Damage, _Damage)
            .SetData(EDataType.HP, _HP)
            .SetData(EDataType.MaxHP, _HP)
            .SetData(EDataType.Image, Properties.Resources.Raichu);
        }

    }
}
