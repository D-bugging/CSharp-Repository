using ExemploHerdar.Model.Enums;

namespace ExemploHerdar.Model.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }
        public abstract double Area();
    }
}