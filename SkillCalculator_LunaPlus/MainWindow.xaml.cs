using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SkillCalculator_LunaPlus
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Cargar Niveles            
            cargarNiveles();
            //Cargar Razas
            cargarRazas();
                             
        }

        public void cargarNiveles()
        {
            for (int i = 1; i <= 150; i++)
            {
                lvlPJ.Items.Add(i.ToString());
            }
        }
        public void cargarRazas()
        {
            List<Raza> razas = new List<Raza>();
            razas.Add(new Raza("Humano"));
            razas.Add(new Raza("Elfo"));
            razas.Add(new Raza("Demon"));
            raza.ItemsSource = razas;
        }

        public class Raza
        {
            public string nombreRaza { get; set; }

            public Raza(String name)
            {
                nombreRaza = name;
            }            
        }
        public class Job1
        {
            public string nombreJob1 { get; set; }

            public Job1 (String name)
            {
                nombreJob1 = name;
            }
        }
        public class Job20
        {
            public string nombreJob20 { get; set; }

            public Job20(String name)
            {
                nombreJob20 = name;
            }
        }
        public class Job40
        {
            public string nombreJob40 { get; set; }

            public Job40(String name)
            {
                nombreJob40 = name;
            }
        }
        public class Job75
        {
            public string nombreJob75 { get; set; }

            public Job75(String name)
            {
                nombreJob75 = name;
            }
        }
        public class Job105
        {
            public string nombreJob105 { get; set; }

            public Job105(String name)
            {
                nombreJob105 = name;
            }
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void raza_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (raza.SelectedItem != null)
            {
                List<Job1> jobs1 = new List<Job1>();
                Raza selectRaza = (raza.SelectedItem as Raza);

                if (selectRaza.nombreRaza != "Demon")
                {
                    jobs1.Add(new Job1("Mago"));
                    jobs1.Add(new Job1("Guerrero"));
                    jobs1.Add(new Job1("Picaro"));
                }
                else
                {
                    jobs1.Add(new Job1("Majin"));
                }
                job1.ItemsSource = jobs1;
                job20.ItemsSource = null;
                job40.ItemsSource = null;
                job75.ItemsSource = null;
                job105.ItemsSource = null;
            }
        }
        
        private void job1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (job1.SelectedItem != null) {
                List<Job20> jobs20 = new List<Job20>();
                Raza selectRaza = (raza.SelectedItem as Raza);
                Job1 selectJob = (job1.SelectedItem as Job1);

                if (selectRaza.nombreRaza == "Humano" || selectRaza.nombreRaza == "Elfo")
                {
                    if (selectJob.nombreJob1 == "Mago")
                    {
                        jobs20.Add(new Job20("Claric"));
                        jobs20.Add(new Job20("Wizard"));
                    }
                    else if (selectJob.nombreJob1 == "Guerrero")
                    {
                        jobs20.Add(new Job20("Guard"));
                        jobs20.Add(new Job20("Warrior"));
                    }
                    else if (selectJob.nombreJob1 == "Picaro")
                    {
                        jobs20.Add(new Job20("Voyager"));
                        jobs20.Add(new Job20("Ruffian"));
                    }
                }
                else
                {
                    jobs20.Add(new Job20("Combat"));
                }
                job20.ItemsSource = jobs20;
            }
        }
        
        private void job20_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (job1.SelectedItem != null)
            {
                List<Job40> jobs40 = new List<Job40>();
                Raza selectRaza = (raza.SelectedItem as Raza);
                Job1 selectJob = (job1.SelectedItem as Job1);

                if (selectRaza.nombreRaza == "Humano" || selectRaza.nombreRaza == "Elfo")
                {
                    if (selectJob.nombreJob1 == "Mago")
                    {
                        if (selectRaza.nombreRaza == "Humano")
                        {
                            jobs40.Add(new Job40("Priest"));
                            jobs40.Add(new Job40("Monk"));
                            jobs40.Add(new Job40("Sorcerer"));
                        }
                        else
                        {
                            jobs40.Add(new Job40("Priest"));
                            jobs40.Add(new Job40("Sorcerer"));
                        }
                    }
                    else if (selectJob.nombreJob1 == "Guerrero")
                    {
                        if (selectRaza.nombreRaza == "Humano")
                        {
                            jobs40.Add(new Job40("Infantery"));
                            jobs40.Add(new Job40("Mercenary"));
                            jobs40.Add(new Job40("Swordman"));
                        }
                        else
                        {
                            jobs40.Add(new Job40("Infantery"));
                            jobs40.Add(new Job40("Swordman"));
                        }
                    }
                    else if (selectJob.nombreJob1 == "Picaro")
                    {
                        if (selectRaza.nombreRaza == "Humano")
                        {
                            jobs40.Add(new Job40("Archer"));
                            jobs40.Add(new Job40("Thief"));
                        }
                        else
                        {
                            jobs40.Add(new Job40("Archer"));
                            jobs40.Add(new Job40("Scout"));
                        }
                    }
                }
                else
                {
                    jobs40.Add(new Job40("Expert"));
                }
                job40.ItemsSource = jobs40;
            }
        }

        private void job40_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (job1.SelectedItem != null)
            {

                List<Job75> jobs75 = new List<Job75>();
                Raza selectRaza = (raza.SelectedItem as Raza);
                Job1 selectJob = (job1.SelectedItem as Job1);

                if (selectRaza.nombreRaza == "Humano" || selectRaza.nombreRaza == "Elfo")
                {
                    if (selectJob.nombreJob1 == "Mago")
                    {
                        if (selectRaza.nombreRaza == "Humano")
                        {
                            jobs75.Add(new Job75("Bishop"));
                            jobs75.Add(new Job75("Warlock"));
                            jobs75.Add(new Job75("Inquirer"));
                        }
                        else
                        {
                            jobs75.Add(new Job75("Bishop"));
                            jobs75.Add(new Job75("Warlock"));
                            jobs75.Add(new Job75("ElementalMaster"));
                        }
                    }
                    else if (selectJob.nombreJob1 == "Guerrero")
                    {
                        if (selectRaza.nombreRaza == "Humano")
                        {
                            jobs75.Add(new Job75("Knight"));
                            jobs75.Add(new Job75("Phalanx"));
                            jobs75.Add(new Job75("Gladiator"));
                        }
                        else
                        {
                            jobs75.Add(new Job75("Knight"));
                            jobs75.Add(new Job75("Phalanx"));
                            jobs75.Add(new Job75("RuneKnight"));
                        }
                    }
                    else if (selectJob.nombreJob1 == "Picaro")
                    {
                        if (selectRaza.nombreRaza == "Humano")
                        {
                            jobs75.Add(new Job75("Ranger"));
                            jobs75.Add(new Job75("TreasureHunter"));
                            jobs75.Add(new Job75("Assasin"));
                        }
                        else
                        {
                            jobs75.Add(new Job75("Ranger"));
                            jobs75.Add(new Job75("TreasureHunter"));
                            jobs75.Add(new Job75("RuneWalker"));
                        }
                    }
                }
                else
                {
                    jobs75.Add(new Job75("Master"));
                }
                job75.ItemsSource = jobs75;
            }
        }

        private void job75_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (job1.SelectedItem != null)
            {
                List<Job105> jobs105 = new List<Job105>();
                Raza selectRaza = (raza.SelectedItem as Raza);
                Job1 selectJob = (job1.SelectedItem as Job1);

                if (selectRaza.nombreRaza == "Humano" || selectRaza.nombreRaza == "Elfo")
                {
                    if (selectJob.nombreJob1 == "Mago")
                    {
                        if (selectRaza.nombreRaza == "Humano")
                        {
                            jobs105.Add(new Job105("GrandMaster"));
                            jobs105.Add(new Job105("SoulAlbiter"));
                            jobs105.Add(new Job105("Cardinal"));
                            jobs105.Add(new Job105("Necromancer"));
                        }
                        else
                        {
                            jobs105.Add(new Job105("GrandMaster"));
                            jobs105.Add(new Job105("SoulAlbiter"));
                            jobs105.Add(new Job105("Cardinal"));
                            jobs105.Add(new Job105("RuneMaster"));
                        }
                    }
                    else if (selectJob.nombreJob1 == "Guerrero")
                    {
                        if (selectRaza.nombreRaza == "Humano")
                        {
                            jobs105.Add(new Job105("SwordMaster"));
                            jobs105.Add(new Job105("Panzer"));
                            jobs105.Add(new Job105("Crusader"));
                            jobs105.Add(new Job105("Paladin"));
                            jobs105.Add(new Job105("Destroyer"));
                        }
                        else
                        {
                            jobs105.Add(new Job105("SwordMaster"));
                            jobs105.Add(new Job105("Panzer"));
                            jobs105.Add(new Job105("Crusader"));
                            jobs105.Add(new Job105("Paladin"));
                            jobs105.Add(new Job105("Magnus"));
                        }
                    }
                    else if (selectJob.nombreJob1 == "Picaro")
                    {
                        if (selectRaza.nombreRaza == "Humano")
                        {
                            jobs105.Add(new Job105("ArchRanger"));
                            jobs105.Add(new Job105("Sniper"));
                            jobs105.Add(new Job105("Entrapper"));
                            jobs105.Add(new Job105("BladeTaker"));
                        }
                        else
                        {
                            jobs105.Add(new Job105("ArchRanger"));
                            jobs105.Add(new Job105("Sniper"));
                            jobs105.Add(new Job105("Entrapper"));
                            jobs105.Add(new Job105("TemplarMaster"));
                        }
                    }
                }
                else
                {
                    jobs105.Add(new Job105("Abyss"));
                }
                job105.ItemsSource = jobs105;
            }
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            job105.ItemsSource = null;
            job75.ItemsSource = null;
            job40.ItemsSource = null;
            job20.ItemsSource = null;
            job1.ItemsSource = null;
            lvlPJ.SelectedIndex = -1;
            raza.SelectedIndex = -1;
            spDisponible.Text = "0";
            spRestante.Text = "0";
        }

        private void lvlPJ_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lvlPJ.SelectedItem != null) { 
                string lvl = lvlPJ.SelectedItem.ToString();
                int nivelPJ = int.Parse(lvl);
                int totalSP = 0;

                for (int i = 2; i <= nivelPJ; i++)
                {
                    totalSP = totalSP + 20 + CalcularExtraSP(i);
                }

                spDisponible.Text = totalSP.ToString();
                spRestante.Text = totalSP.ToString();
            }
        }

        public int CalcularExtraSP(int nivelPJ)
        {
            int extraSP = 0;

            if (nivelPJ > 10)
            {
                extraSP = (nivelPJ / 10);
                if ((nivelPJ % 10) == 0)
                {
                    extraSP = extraSP - 1;
                }
            }
            return extraSP;
        }
    }
}
