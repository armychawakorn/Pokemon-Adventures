namespace PokemonGame
{
    partial class GameInterface
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.VS_Image = new System.Windows.Forms.PictureBox();
            this.Pokemon_Image = new System.Windows.Forms.PictureBox();
            this.Monster_Image = new System.Windows.Forms.PictureBox();
            this.Battle_Button = new System.Windows.Forms.Button();
            this.PokemonHP_TextBox = new System.Windows.Forms.TextBox();
            this.PokemonHP_Bar = new System.Windows.Forms.ProgressBar();
            this.PokemonHP_Label = new System.Windows.Forms.Label();
            this.PokemonAttack_Label = new System.Windows.Forms.Label();
            this.PokemonAttack_TextBox = new System.Windows.Forms.TextBox();
            this.MonsterAttack_Label = new System.Windows.Forms.Label();
            this.MonsterAttack_TextBox = new System.Windows.Forms.TextBox();
            this.MonsterHP_Label = new System.Windows.Forms.Label();
            this.MonsterHP_TextBox = new System.Windows.Forms.TextBox();
            this.MonsterHP_Bar = new System.Windows.Forms.ProgressBar();
            this.ListPokemon = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.VS_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pokemon_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Monster_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // VS_Image
            // 
            this.VS_Image.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.VS_Image.Image = global::PokemonGame.Properties.Resources.VS;
            this.VS_Image.Location = new System.Drawing.Point(284, 9);
            this.VS_Image.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VS_Image.Name = "VS_Image";
            this.VS_Image.Size = new System.Drawing.Size(175, 150);
            this.VS_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.VS_Image.TabIndex = 0;
            this.VS_Image.TabStop = false;
            // 
            // Pokemon_Image
            // 
            this.Pokemon_Image.Location = new System.Drawing.Point(70, 23);
            this.Pokemon_Image.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pokemon_Image.Name = "Pokemon_Image";
            this.Pokemon_Image.Size = new System.Drawing.Size(131, 112);
            this.Pokemon_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pokemon_Image.TabIndex = 1;
            this.Pokemon_Image.TabStop = false;
            // 
            // Monster_Image
            // 
            this.Monster_Image.Location = new System.Drawing.Point(542, 23);
            this.Monster_Image.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Monster_Image.Name = "Monster_Image";
            this.Monster_Image.Size = new System.Drawing.Size(131, 112);
            this.Monster_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Monster_Image.TabIndex = 2;
            this.Monster_Image.TabStop = false;
            // 
            // Battle_Button
            // 
            this.Battle_Button.Location = new System.Drawing.Point(328, 172);
            this.Battle_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Battle_Button.Name = "Battle_Button";
            this.Battle_Button.Size = new System.Drawing.Size(82, 38);
            this.Battle_Button.TabIndex = 3;
            this.Battle_Button.Text = "Battle";
            this.Battle_Button.UseVisualStyleBackColor = true;
            this.Battle_Button.Click += new System.EventHandler(this.Battle_Button_Click);
            // 
            // PokemonHP_TextBox
            // 
            this.PokemonHP_TextBox.Location = new System.Drawing.Point(92, 206);
            this.PokemonHP_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PokemonHP_TextBox.Name = "PokemonHP_TextBox";
            this.PokemonHP_TextBox.ReadOnly = true;
            this.PokemonHP_TextBox.Size = new System.Drawing.Size(110, 23);
            this.PokemonHP_TextBox.TabIndex = 4;
            // 
            // PokemonHP_Bar
            // 
            this.PokemonHP_Bar.ForeColor = System.Drawing.Color.Red;
            this.PokemonHP_Bar.Location = new System.Drawing.Point(70, 150);
            this.PokemonHP_Bar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PokemonHP_Bar.Name = "PokemonHP_Bar";
            this.PokemonHP_Bar.Size = new System.Drawing.Size(132, 20);
            this.PokemonHP_Bar.TabIndex = 5;
            // 
            // PokemonHP_Label
            // 
            this.PokemonHP_Label.AutoSize = true;
            this.PokemonHP_Label.Location = new System.Drawing.Point(62, 208);
            this.PokemonHP_Label.Name = "PokemonHP_Label";
            this.PokemonHP_Label.Size = new System.Drawing.Size(23, 15);
            this.PokemonHP_Label.TabIndex = 6;
            this.PokemonHP_Label.Text = "HP";
            // 
            // PokemonAttack_Label
            // 
            this.PokemonAttack_Label.AutoSize = true;
            this.PokemonAttack_Label.Location = new System.Drawing.Point(42, 184);
            this.PokemonAttack_Label.Name = "PokemonAttack_Label";
            this.PokemonAttack_Label.Size = new System.Drawing.Size(41, 15);
            this.PokemonAttack_Label.TabIndex = 8;
            this.PokemonAttack_Label.Text = "Attack";
            // 
            // PokemonAttack_TextBox
            // 
            this.PokemonAttack_TextBox.Location = new System.Drawing.Point(92, 182);
            this.PokemonAttack_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PokemonAttack_TextBox.Name = "PokemonAttack_TextBox";
            this.PokemonAttack_TextBox.ReadOnly = true;
            this.PokemonAttack_TextBox.Size = new System.Drawing.Size(110, 23);
            this.PokemonAttack_TextBox.TabIndex = 7;
            // 
            // MonsterAttack_Label
            // 
            this.MonsterAttack_Label.AutoSize = true;
            this.MonsterAttack_Label.Location = new System.Drawing.Point(514, 186);
            this.MonsterAttack_Label.Name = "MonsterAttack_Label";
            this.MonsterAttack_Label.Size = new System.Drawing.Size(41, 15);
            this.MonsterAttack_Label.TabIndex = 12;
            this.MonsterAttack_Label.Text = "Attack";
            // 
            // MonsterAttack_TextBox
            // 
            this.MonsterAttack_TextBox.Location = new System.Drawing.Point(564, 184);
            this.MonsterAttack_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MonsterAttack_TextBox.Name = "MonsterAttack_TextBox";
            this.MonsterAttack_TextBox.ReadOnly = true;
            this.MonsterAttack_TextBox.Size = new System.Drawing.Size(110, 23);
            this.MonsterAttack_TextBox.TabIndex = 11;
            // 
            // MonsterHP_Label
            // 
            this.MonsterHP_Label.AutoSize = true;
            this.MonsterHP_Label.Location = new System.Drawing.Point(535, 211);
            this.MonsterHP_Label.Name = "MonsterHP_Label";
            this.MonsterHP_Label.Size = new System.Drawing.Size(23, 15);
            this.MonsterHP_Label.TabIndex = 10;
            this.MonsterHP_Label.Text = "HP";
            // 
            // MonsterHP_TextBox
            // 
            this.MonsterHP_TextBox.Location = new System.Drawing.Point(564, 208);
            this.MonsterHP_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MonsterHP_TextBox.Name = "MonsterHP_TextBox";
            this.MonsterHP_TextBox.ReadOnly = true;
            this.MonsterHP_TextBox.Size = new System.Drawing.Size(110, 23);
            this.MonsterHP_TextBox.TabIndex = 9;
            // 
            // MonsterHP_Bar
            // 
            this.MonsterHP_Bar.ForeColor = System.Drawing.Color.Red;
            this.MonsterHP_Bar.Location = new System.Drawing.Point(542, 150);
            this.MonsterHP_Bar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MonsterHP_Bar.Name = "MonsterHP_Bar";
            this.MonsterHP_Bar.Size = new System.Drawing.Size(132, 20);
            this.MonsterHP_Bar.TabIndex = 13;
            // 
            // ListPokemon
            // 
            this.ListPokemon.FormattingEnabled = true;
            this.ListPokemon.ItemHeight = 15;
            this.ListPokemon.Items.AddRange(new object[] {
            "Pikachu",
            "Raichu",
            "Sandshrew",
            "Sandslash"});
            this.ListPokemon.Location = new System.Drawing.Point(70, 253);
            this.ListPokemon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListPokemon.Name = "ListPokemon";
            this.ListPokemon.Size = new System.Drawing.Size(132, 64);
            this.ListPokemon.TabIndex = 14;
            // 
            // GameInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 346);
            this.Controls.Add(this.ListPokemon);
            this.Controls.Add(this.MonsterHP_Bar);
            this.Controls.Add(this.MonsterAttack_Label);
            this.Controls.Add(this.MonsterAttack_TextBox);
            this.Controls.Add(this.MonsterHP_Label);
            this.Controls.Add(this.MonsterHP_TextBox);
            this.Controls.Add(this.PokemonAttack_Label);
            this.Controls.Add(this.PokemonAttack_TextBox);
            this.Controls.Add(this.PokemonHP_Label);
            this.Controls.Add(this.PokemonHP_Bar);
            this.Controls.Add(this.PokemonHP_TextBox);
            this.Controls.Add(this.Battle_Button);
            this.Controls.Add(this.Monster_Image);
            this.Controls.Add(this.Pokemon_Image);
            this.Controls.Add(this.VS_Image);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(746, 385);
            this.MinimumSize = new System.Drawing.Size(746, 385);
            this.Name = "GameInterface";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.VS_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pokemon_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Monster_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox VS_Image;
        private PictureBox Pokemon_Image;
        private PictureBox Monster_Image;
        private Button Battle_Button;
        private TextBox PokemonHP_TextBox;
        private ProgressBar PokemonHP_Bar;
        private Label PokemonHP_Label;
        private Label PokemonAttack_Label;
        private TextBox PokemonAttack_TextBox;
        private Label MonsterAttack_Label;
        private TextBox MonsterAttack_TextBox;
        private Label MonsterHP_Label;
        private TextBox MonsterHP_TextBox;
        private ProgressBar MonsterHP_Bar;
        private ListBox ListPokemon;
    }
}