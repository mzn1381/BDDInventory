namespace Inventory.Presentation.Test.Integration
{
    public interface IStartableHost : IHost
    {
        void Start();
        void Stop();
    }
}