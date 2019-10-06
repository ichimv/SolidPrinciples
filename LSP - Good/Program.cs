using LSP.CarpetCleaner;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarpetCleaner carpetHitter = new CarpetHitter();
            carpetHitter.Clean();

            ICarpetCleaner carpetVacuumCleaner = new CarpetVacuumCleaner();
            carpetVacuumCleaner.Clean();

        }
    }
}
