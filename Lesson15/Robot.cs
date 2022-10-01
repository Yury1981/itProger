using System;

namespace Lesson14{
    class Robot{

        private static int count;
        private string name = null!;
        private int weight;
        private byte[] coordinates = null!;

        public Robot(string _name, int _weight, byte[] _coordinates) {
            Console.WriteLine("Object has been created");
            setValues(_name, _weight, _coordinates);
            count++;
        }

        public Robot(string _name) {
            Console.WriteLine("Object has been created");
           name = _name;
           count++;
        }

        public Robot() {count++;}

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

        public static void Print(){
            Console.WriteLine("Count is: " + count);
        }
    }
}