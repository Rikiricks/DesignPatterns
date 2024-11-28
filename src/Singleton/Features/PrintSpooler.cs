namespace Singleton.Features
{
    public sealed class PrintSpooler
    {
        private static PrintSpooler _lazyInstance = null!;
        private static readonly object _lazyInstanceLock = new object();
        private readonly Queue<string> _queue = new();

        private PrintSpooler() { }

        public static PrintSpooler GetPrintSpooler()
        {
            //Make it thread safe
            lock (_lazyInstanceLock)
            {
                return _lazyInstance ??= new PrintSpooler();
            }
        }

        public void AddPrintJob(IEnumerable<string> documents)
        {
            if (documents == null) throw new ArgumentNullException(nameof(documents));
            //Make it thread safe
            lock (_queue)
            {
                foreach (var document in documents) _queue.Enqueue(document);
            }
        }

        public void ProcessPrintJob()
        {
            //Make it thread safe
            lock (_queue)
            {
                foreach (var document in _queue) Console.WriteLine(document);
                Console.WriteLine("Instance Call Finished");
            }
        }

    }
}
