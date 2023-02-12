using System.Net;

namespace PokemonGame
{
    public partial class GameInterface : Form
    {
        public static GameInterface Instance;
        List<Character> Pokemons = new List<Character>();
        int PokemonIndex = 0;
        Character Pokemon;
        Character Monster;
        public GameInterface()
        {
            InitializeComponent();
            Pokemons.Add(new Pikachu());
            Pokemons.Add(new Raichu());
            Pokemons.Add(new Sandshrew());
            Pokemons.Add(new Sandslash());

            //Generate Monster
            Monster = new Monster();
            Monster_Image.Image = Monster.GetData<Bitmap>(EDataType.Image);
            MonsterHP_Bar.Value = Monster.GetData<int>(EDataType.HP) / new Monster().GetData<int>(EDataType.HP) * 100;
            MonsterAttack_TextBox.Text = Monster.GetData<float>(EDataType.Damage).ToString();
            MonsterHP_TextBox.Text = Monster.GetData<float>(EDataType.HP).ToString();


            ListPokemon.SelectedValueChanged += EventOnPlayerSelectedPokemon;

        }

        private void EventOnPlayerSelectedPokemon(object? sender, EventArgs e)
        {
            ListBox? lb = (ListBox)sender;
            if(lb.SelectedIndex < 0)
            {
                if (Pokemons.Count <= 0) { MessageBox.Show("คุณแพ้แล้ว"); return; } else { lb.SelectedIndex = 0; }
            }
            UpdatePokemon(Pokemons[lb.SelectedIndex]);
        }

        private void Battle_Button_Click(object sender, EventArgs e)
        {
            if(Pokemon == null)
            {
                MessageBox.Show("กรุณาเลือกPokemonออกมาสู้ก่อน!!");
                return;
            }
            Pokemon.SetData(EDataType.HP, Pokemon.GetData<float>(EDataType.HP) - Monster.GetData<float>(EDataType.Damage));
            PokemonHP_Bar.Value = HPCalculater<int>(Pokemon.GetData<float>(EDataType.HP), Pokemon.GetData<float>(EDataType.MaxHP));
            PokemonHP_TextBox.Text = Pokemon.GetData<float>(EDataType.HP).ToString();

            Monster.SetData(EDataType.HP, Monster.GetData<float>(EDataType.HP) - Pokemon.GetData<float>(EDataType.Damage));
            MonsterHP_Bar.Value = HPCalculater<int>(Monster.GetData<float>(EDataType.HP), Monster.GetData<float>(EDataType.MaxHP));
            MonsterHP_TextBox.Text = Monster.GetData<float>(EDataType.HP).ToString();
            if (Monster.GetData<float>(EDataType.HP) < 0)
            {
                MonsterHP_TextBox.Text = "0";
                MessageBox.Show("You win!!");
                return;
            }else if (Pokemon.GetData<float>(EDataType.HP) < 0)
            {
                MessageBox.Show(string.Format("{0} ของคุณตายแล้ว!", Pokemon.GetData<string>(EDataType.Name)));
                Pokemons.Remove(Pokemon);
                if (Pokemons.Count > 0)
                {
                    ListPokemon.Items.RemoveAt(PokemonIndex);
                    ListPokemon.SetSelected(0, true);
                    Pokemon = Pokemons[0];
                }
                if(Pokemons.Count == 0)
                {
                    MessageBox.Show("คุณแพ้แล้ว");
                    ListPokemon.Items.Clear();
                    PokemonHP_TextBox.Text = "0";
                    PokemonAttack_TextBox.Text = "0";
                    Pokemon_Image.Image = null;
                    Battle_Button.Visible = false;
                    return;
                }
            }
        }
        static T HPCalculater<T>(float baseHP, float MaxHP)
        {
            float? result = baseHP / MaxHP * 100f;
            if(result < 0)
            {
                result = 0;
            }
            return (T)Convert.ChangeType(result, typeof(T));
        }
        void UpdatePokemon(Character _Pokemon)
        {
            Pokemon = _Pokemon;
            Pokemon_Image.Image = Pokemon.GetData<Bitmap>(EDataType.Image);
            PokemonHP_Bar.Value = HPCalculater<int>(Pokemon.GetData<float>(EDataType.HP), Pokemon.GetData<float>(EDataType.MaxHP));
            PokemonAttack_TextBox.Text = Pokemon.GetData<float>(EDataType.Damage).ToString();
            PokemonHP_TextBox.Text = Pokemon.GetData<float>(EDataType.HP).ToString();
        }
    }
}