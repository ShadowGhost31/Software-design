namespace ForTest
{
    internal interface IResultManager
    {
        void SaveResult(string name, int errors, double timeInSeconds);
        void PrintResults();
    }
}
