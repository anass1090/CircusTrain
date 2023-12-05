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
            List<Animal> animals = testCase.Scenario(2, 1, 1, 1, 5, 1);
            train.DistributeAnimals(animals);

            lblAnimals.Text = "Dieren resterend: " + animals.Count.ToString();
            lblWagons.Text = "Aantal wagons: " + train.Wagons.Count.ToString();
        }
    }
}
