using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsApp
{
    public class LearningItems
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
    }

    public class LearningData
    {
        public List<LearningItems> Animals { get; set; }
        public List<LearningItems> Letters { get; set; }
        public List<LearningItems> Numbers { get; set; }
        public List<LearningItems> Colors { get; set; }
        public List<LearningItems> Fruits { get; set; }
        public List<LearningItems> Shapes { get; set; }

        public LearningData()
        {
            Animals = new List<LearningItems>()
            {
                new LearningItems() { Name = "Lion", ImageUrl = "lion.png" },
                new LearningItems() { Name = "Fox", ImageUrl = "fox.png" },
                new LearningItems() { Name = "Tiger", ImageUrl = "tiger.png" },
                new LearningItems() { Name = "Elephant", ImageUrl = "Elephant.png" },
                new LearningItems() { Name = "Zebra", ImageUrl = "zebra.png" },
                new LearningItems() { Name = "Monkey", ImageUrl = "monkey.png" },
                new LearningItems() { Name = "Giraffe", ImageUrl = "giraffe.png" },
                new LearningItems() { Name = "Dog", ImageUrl = "Dog.png" },
                new LearningItems() { Name = "Cat", ImageUrl = "cat.png" },
                new LearningItems() { Name = "Rabbit", ImageUrl = "rabbit.png" },
                new LearningItems() { Name = "Horse", ImageUrl = "horse.png" },
            };


            Letters = new List<LearningItems>()
            {
               new LearningItems(){Name="a", ImageUrl="alphabet_a.png"},
               new LearningItems(){Name="b", ImageUrl="alphabet_b.png"},
               new LearningItems(){Name="c", ImageUrl="alphabet_c.png"},
               new LearningItems(){Name="d", ImageUrl="alphabet_d.png"},
               new LearningItems(){Name="e", ImageUrl="alphabet_e.png"},
               new LearningItems(){Name="f", ImageUrl="alphabet_f.png"},
               new LearningItems(){Name="g", ImageUrl="alphabet_g.png"},
               new LearningItems(){Name="h", ImageUrl="alphabet_h.png"},
               new LearningItems(){Name="i", ImageUrl="alphabet_i.png"},
               new LearningItems(){Name="j", ImageUrl="alphabet_j.png"},
               new LearningItems(){Name="k", ImageUrl="alphabet_k.png"},
               new LearningItems(){Name="l", ImageUrl="alphabet_l.png"},
               new LearningItems(){Name="m", ImageUrl="alphabet_m.png"},
               new LearningItems(){Name="n", ImageUrl="alphabet_n.png"},
               new LearningItems(){Name="o", ImageUrl="alphabet_o.png"},
               new LearningItems(){Name="p", ImageUrl="alphabet_p.png"},
               new LearningItems(){Name="q", ImageUrl="alphabet_q.png"},
               new LearningItems(){Name="r", ImageUrl="alphabet_r.png"},
               new LearningItems(){Name="s", ImageUrl="alphabet_s.png"},
               new LearningItems(){Name="t", ImageUrl="alphabet_t.png"},
               new LearningItems(){Name="u", ImageUrl="alphabet_u.png"},
               new LearningItems(){Name="v", ImageUrl="alphabet_v.png"},
               new LearningItems(){Name="w", ImageUrl="alphabet_w.png"},
               new LearningItems(){Name="x", ImageUrl="alphabet_x.png"},
               new LearningItems(){Name="y", ImageUrl="alphabet_y.png"},
               new LearningItems(){Name="z", ImageUrl="alphabet_z.png"},
            };

            Numbers = new List<LearningItems>()
            {
              new LearningItems() { Name = "One", ImageUrl = "one.png" },
              new LearningItems() { Name = "Two", ImageUrl = "two.png" },
              new LearningItems() { Name = "Three", ImageUrl = "three.png" },
              new LearningItems() { Name = "Four", ImageUrl = "four.png" },
              new LearningItems() { Name = "Five", ImageUrl = "five.png" },
              new LearningItems() { Name = "Six", ImageUrl = "six.png" },
              new LearningItems() { Name = "Seven", ImageUrl = "seven.png" },
              new LearningItems() { Name = "Eight", ImageUrl = "eight.png" },
              new LearningItems() { Name = "Nine", ImageUrl = "nine.png" },
              new LearningItems() { Name = "Ten", ImageUrl = "ten.png" },

            };

            Colors = new List<LearningItems>()
            {
               new LearningItems() { Name = "Black", ImageUrl = "color_black.png" },
               new LearningItems() { Name = "Blue", ImageUrl = "color_blue.png" },
               new LearningItems() { Name = "Gray", ImageUrl = "color_gray.png" },
               new LearningItems() { Name = "Green", ImageUrl = "color_green.png" },
               new LearningItems() { Name = "Orange", ImageUrl = "color_orange.png" },
               new LearningItems() { Name = "Purple", ImageUrl = "color_purple.png" },
               new LearningItems() { Name = "Red", ImageUrl = "color_red.png" },
               new LearningItems() { Name = "Yellow", ImageUrl = "color_yellow.png" },

            };

            Fruits = new List<LearningItems>()
           {
               new LearningItems { Name = "Apple", ImageUrl = "apple.png" },
               new LearningItems { Name = "Banana", ImageUrl = "banana.png" },
               new LearningItems { Name = "Orange", ImageUrl = "orange.png" },
               new LearningItems { Name = "Strawberry", ImageUrl = "strawberry.png" },
               new LearningItems { Name = "Mango", ImageUrl = "mango.png" },
               new LearningItems { Name = "Kiwi", ImageUrl = "kiwi.png" },
               new LearningItems { Name = "Watermelon", ImageUrl = "watermelon.png" },
               new LearningItems { Name = "Grapes", ImageUrl = "grapes.png" },
               new LearningItems { Name = "Pineapple", ImageUrl = "pineapple.png" },
               new LearningItems { Name = "Coconut", ImageUrl = "coconut.png" },
               new LearningItems { Name = "Peach", ImageUrl = "peach.png" },
               new LearningItems { Name = "Apricot", ImageUrl = "apricot.png" },
               new LearningItems { Name = "Guava", ImageUrl = "guava.png" },

           };

            Shapes = new List<LearningItems>()
            {
               new LearningItems() { Name = "Triangle", ImageUrl = "triangle.png" },
               new LearningItems() { Name = "Circle", ImageUrl = "circle.png" },
               new LearningItems() { Name = "Square", ImageUrl = "square.png" },
               new LearningItems() { Name = "Rectangle", ImageUrl = "rectangle.png" },
               new LearningItems() { Name = "Oval", ImageUrl = "oval.png" },
               new LearningItems() { Name = "Star", ImageUrl = "star.png" },
               new LearningItems() { Name = "Heart", ImageUrl = "heart.png" },
               new LearningItems() { Name = "Arrow", ImageUrl = "arrow.png" },
               new LearningItems() { Name = "Pyramid", ImageUrl = "pyramid.png" },
               new LearningItems() { Name = "Cube", ImageUrl = "cube.png" },

            };
        }

    }
}
