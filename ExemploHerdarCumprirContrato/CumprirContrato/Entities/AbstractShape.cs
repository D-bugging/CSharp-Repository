using ExemploCumprirContrato.Model.Enums;

namespace ExemploCumprirContrato.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}