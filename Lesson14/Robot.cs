using System;

namespace Lesson14{
    class Robot{
        private string name = null!;
        private int weight;
        private byte[] coordinates = null!;

        public void setValues(string _name, int _weight, byte[] _coordinates){
            name = _name;
            weight = _weight;
            coordinates = _coordinates;
        }
        public void printValues(){
            Console.Write(name + " weight: " + weight + ". Coordinates: ");
            foreach(byte el in coordinates)
                Console.Write(el + ", ");
            Console.WriteLine();
        }
    }
}