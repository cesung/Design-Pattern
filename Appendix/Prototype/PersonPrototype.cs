namespace Prototype
{
    public interface PersonPrototype
    {
        public Person ShallowClone();

        public Person DeepClone();
    }
}