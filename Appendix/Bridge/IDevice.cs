namespace Bridge
{
    // The "implementation" interface declares methods common to all
    // concrete implementation classes. It doesn't have to match the
    // abstraction's interface. In fact, the two interfaces can be
    // entirely different. Typically the implementation interface
    // provides only primitive operations, while the abstraction
    // defines higher-level operations based on those primitives.
    public interface IDevice
    {
        bool IsEnable();

        void Enable();

        void Disable();

        int GetVolumn();

        void SetVolumn(int volumn);

        int GetChannel();

        void SetChannel(int channel);
    }
}

