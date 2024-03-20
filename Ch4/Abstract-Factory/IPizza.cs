namespace AbstractFactory
{
    public interface IPizza
    {
        void Prepare();

        void Bake();

        void Cut();

        void Box();
    }
}