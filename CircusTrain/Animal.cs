using CircusTrain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrain
{
    public class Animal
    {
        public Diets Diet {  get; private set; }
        public Sizes Size { get; private set; }
        public string Name { get; private set; }

        public Animal(string name, Diets diet, Sizes size)
        {
            Name = name;
            Diet = diet;
            Size = size;
        }

        public Animal(Diets diet, Sizes size)
        {
            Diet = diet;
            Size = size;
        }
    }
}
