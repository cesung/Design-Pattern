namespace Command
{
    public interface IStereo
    {
        string Name { get; set; }
        void On();
        void Off();
        void SetCd();
        void SetDvd();
        void SetRadio();
        void SetVolumn(int volumn);
    }

}