using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame
{
    public class Character
    {
        protected string? Name;
        protected float? Damage;
        protected float? HP;
        protected float? MaxHP;
        protected Bitmap? Image;
        public T GetData<T>(EDataType type)
        {
            object result = null;
            switch (type)
            {
                case EDataType.Name:
                    result = this.Name;
                    break;
                case EDataType.Damage:
                    result = this.Damage;
                    break;
                case EDataType.HP:
                    result = this.HP;
                    break;
                case EDataType.MaxHP:
                    result = this.MaxHP;
                    break;
                case EDataType.Image:
                    result = this.Image;
                    break;
            }
            return (T)Convert.ChangeType(result, typeof(T));
        }
        public Character SetData<T>(EDataType type,T value)
        {

            switch (type)
            {
                case EDataType.Name:
                    this.Name = value.ToString();
                    break;
                case EDataType.Damage:
                    this.Damage = float.Parse(value.ToString());
                    break;
                case EDataType.HP:
                    this.HP = float.Parse(value.ToString());
                    break;
                case EDataType.MaxHP:
                    this.MaxHP = float.Parse(value.ToString());
                    break;
                case EDataType.Image:
                    this.Image = (Bitmap)Convert.ChangeType(value, typeof(Bitmap));
                    break;
            }
            return this;
        }
        protected float RamdonValue(EDataType type)
        {
            switch(type)
            {
                case EDataType.Damage:
                    return new Random().NextSingle() * 10;
            }
            return 0;
        }
        public int RandomHP()
        {
            return Convert.ToInt32(new Random().NextSingle() * 5000);
        }
        public int RandomDamage()
        {
            return Convert.ToInt32(new Random().NextSingle() * 250);
        }
    }
    
    public enum EDataType
    {
        Name,
        Damage,
        HP,
        MaxHP,
        Image
    }

}
