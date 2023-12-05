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
        readonly SortAnimals sortAnimals = new SortAnimals();

        public CircusTrain()
        {
            InitializeComponent();
        }

        private void AddAnimals_Click(object sender, EventArgs e)
        {
            List<Animal> animals = testCase.Scenario(3, 0, 0, 0, 2, 3);
            animals = sortAnimals.Sort(animals);
            train.AddWagons(animals);

            MessageBox.Show("Aantal wagons: " + train.Wagons.Count.ToString());

            foreach (Wagon wagon in train.Wagons)
            { 
                MessageBox.Show("Wagon " + train.Wagons.Count.ToString());

                foreach (Animal animal in wagon.AnimalsInWagon)
                {
                    MessageBox.Show(animal.Size.ToString() + " " + animal.Diet.ToString());
                }
            }

            lblAnimals.Text = animals.Count.ToString();
            lblWagons.Text = train.Wagons.Count.ToString();
        }
    }
}
