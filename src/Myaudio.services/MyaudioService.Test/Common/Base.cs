using Myaudio.persistance;

namespace MyaudioService.Test.Common
{
    public class Base : IDisposable
    {
        protected readonly Context _context;

        public Base()
        {
            _context = ContextFactory.Create();
        }
        public void Dispose()
        {
            ContextFactory.Destroy(_context);
        }
    }
}
