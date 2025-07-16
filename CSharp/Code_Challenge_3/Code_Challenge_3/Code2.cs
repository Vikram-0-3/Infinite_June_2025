using System;

namespace box
{
    class Box
    {
        public int Length;
        public int Breadth;

        public void SetDimensions(int Length, int Breadth)
        {
            this.Length = Length;
            this.Breadth = Breadth;
        }

        public Box Add(Box SecondBox)
        {
            Box ResultBox = new Box();
            ResultBox.Length = this.Length + SecondBox.Length;
            ResultBox.Breadth = this.Breadth + SecondBox.Breadth;
            return ResultBox;
        }

        public void Display()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Box 3 Length & Breadth");
            Console.WriteLine("Length - " + Length);
            Console.WriteLine("Breadth - " + Breadth);
            Console.WriteLine("-------------------------------");
        }
    }

    class Code2
    {
        static void Main()
        {
            Box Box1 = new Box();
            Box Box2 = new Box();

            Console.Write("Enter length of Box 1: ");
            int L1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter breadth of Box 1: ");
            int B1 = Convert.ToInt32(Console.ReadLine());
            Box1.SetDimensions(L1, B1);

            Console.Write("Enter length of Box 2: ");
            int L2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter breadth of Box 2: ");
            int B2 = Convert.ToInt32(Console.ReadLine());
            Box2.SetDimensions(L2, B2);

            Box B3 = Box1.Add(Box2);
            B3.Display();
            Console.Read();
        }
    }
}