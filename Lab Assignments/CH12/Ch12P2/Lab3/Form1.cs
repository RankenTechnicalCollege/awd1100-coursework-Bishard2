using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        private List<Champion> champions = new List<Champion>();
        public Form1()
        {
            InitializeComponent();
            InitializeChampions();
        }
        private void InitializeChampions()
        {
            champions.Add(new Champion("Ruckus", ChampionType.FRONT_LINE, new Ability("Miniguns"), new Ability("Missile Launcher"), new Ability("Emitter"), new Ability("Advance"), new Ability("Hexa Fire")));
            champions.Add(new Champion("Makoa", ChampionType.FRONT_LINE, new Ability("Cannon"), new Ability("Dredge Anchor"), new Ability("Shell Shield"), new Ability("Shell Spin"), new Ability("Ancient Rage")));
            champions.Add(new Champion("Drogoz", ChampionType.DAMAGE, new Ability("Rocket Launcher"), new Ability("Fire Spit"), new Ability("Salvo"), new Ability("Thrust"), new Ability("Dragon Punch")));
            champions.Add(new Champion("Tyra", ChampionType.DAMAGE, new Ability("Auto Rifle"), new Ability("Nade Launcher"), new Ability("Fire Bomb"), new Ability("Hunter's Mark"), new Ability("Crossfire")));
            champions.Add(new Champion("Grover", ChampionType.SUPPORT, new Ability("Throwing Axe"), new Ability("Crippling Throw"), new Ability("Blossom"), new Ability("Vine"), new Ability("Whirlwind")));
            champions.Add(new Champion("Evie", ChampionType.FLANK, new Ability("Ice Staff"), new Ability("Ice Block"), new Ability("Blink"), new Ability("Soar"), new Ability("Ice Storm")));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string input = txtName.Text.Trim().ToLower();
            Champion found = champions.FirstOrDefault(c => c.Name.ToLower() == input);

            lstOutput.Items.Clear();

            if (found != null)
            {
                lstOutput.Items.Add(found.Name);
                lstOutput.Items.Add(found.Type.ToString());
                lstOutput.Items.Add($"LeftMouse: {found.LeftMouse.Name}");
                lstOutput.Items.Add($"RightMouse: {found.RightMouse.Name}");
                lstOutput.Items.Add($"Q: {found.Q.Name}");
                lstOutput.Items.Add($"F: {found.F.Name}");
                lstOutput.Items.Add($"E: {found.E.Name}");
            }
            else
            {
                lstOutput.Items.Add("Champion not found");
            }
        }
    }
    public enum ChampionType
    {
        FRONT_LINE = 0,
        DAMAGE = 1,
        SUPPORT = 2,
        FLANK = 3
    }
}
