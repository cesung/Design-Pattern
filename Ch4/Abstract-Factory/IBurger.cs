namespace AbstractFactory
{
    public interface IBurger
    {
        void Prepare();

        void Bake();

        void Assemble();

        void Box();
    }
}