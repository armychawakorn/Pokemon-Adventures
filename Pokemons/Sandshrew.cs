using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame
{
    public class Sandshrew : Character
    {
        readonly float _HP = 500;
        readonly float _Damage = 75;
        public Sandshrew()
        {
            this
            .SetData(EDataType.Name, "Sandshrew")
            .SetData(EDataType.Damage, _Damage)
            .SetData(EDataType.HP, _HP)
            .SetData(EDataType.MaxHP, _HP)
            .SetData(EDataType.Image, Properties.Resources.Sandshrew);
        }

    }
}
