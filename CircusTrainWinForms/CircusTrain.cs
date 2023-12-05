using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CircusTrain;

namespace CircusTrainWinForms
{
    public partial class CircusTrain : Form
    {
        readonly Train train = new Train();
        readonly Case testCase = new Case();

        public CircusTrain()
        {
            InitializeComponent();
        }

        private void AddAnimals_Click(object sender, EventArgs e)
        {
            List<Animal> animals = testCase.Scenario((int)numSC.Value, (int)numMC.Value, (int)numLC.Value, (int)numSH.Value, (int)numMH.Value, (int)numLH.Value);

            train.DistributeAnimals(animals);

            if(train.Wagons != null)
            {
                listWagons.Items.Clear();

                foreach (Wagon wagon in train.Wagons)
                {
                    listWagons.Items.Add(wagon);
                    listWagons.DisplayMember = "WagonNumber";
                }
            }
        }
        private void ListWagons_SelectedIndexChanged(object sender, EventArgs e)
        {
            Wagon SelectedWagon = (Wagon)listWagons.SelectedItem;

            if (SelectedWagon != null)
            {
                listAnimalsinWagon.Items.Clear();

                foreach(Animal animal in SelectedWagon.AnimalsInWagon)
                {
                    string animalInfo = animal.Size.ToString() + " " + animal.Diet.ToString();
                    listAnimalsinWagon.Items.Add(animalInfo);
                }
            }
        }
    }
}
