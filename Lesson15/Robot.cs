using System;

namespace Lesson14{
    class Robot{

        private static int count;
        private string name = null!;
        private int weight;
        private byte[] coordinates = null!;

        public Robot(string name, int weight, byte[] coordinates) {
            Console.WriteLine("Object has been created");
            this.setValues(name, weight, coordinates);
            count++;
        }

        public Robot(string name) {
            Console.WriteLine("Object has been created");
           this.name = name;
           count++;
        }

        public Robot() {count++;}

        public void setValues(string name, int weight, byte[] coordinates){
            this.name = name;
            this.weight = weight;
            this.coordinates = coordinates;
        }
        public void printValues(){
            Console.Write(this.name + " weight: " + this.weight + ". Coordinates: ");
            foreach(byte el in this.coordinates)
                Console.Write(el + ", ");
            Console.WriteLine();
        }

        public static void Print(){
            Console.WriteLine("Count is: " + count);
        }
    }
}