using System;

namespace Properties
{
    public class Base
    {
        private float _mass;
        public float Mass { get { return _mass; } set { _mass = value; } }

        private float _speed;
        public float Speed { get { return _speed; } }   // no setter

        public Base(float mass, float speed)
        {
            _mass = mass;
            _speed = speed;
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Base var1 = new Base(20, 6);

            Console.WriteLine("Mass = {0} - Speed = {1}", var1.Mass, var1.Speed);

            var1.Mass = 5f;

            Console.WriteLine("Mass = {0} - Speed = {1}", var1.Mass, var1.Speed);
        }
    }
}