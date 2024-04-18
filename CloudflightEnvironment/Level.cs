namespace CloudflightEnvironment
{
    abstract class Level
    {
        public int LevelNumber { get; private set; }
        public string FolderPath { get; private set; }
        public string[] input { get; set; }
        public Level(int levelNumber)
        {
            LevelNumber = levelNumber;
            FolderPath = $"../../../level{levelNumber}/";
            input = File.ReadAllLines(FolderPath + $"level{levelNumber}_example.in");
        }

        public abstract List<string> Solve();

        public void WriteOutput(string number)
        {
            File.WriteAllLines(FolderPath + $"level{LevelNumber}_{number}.out", Solve());
        }
        public void ShowConsole()
        {
            List<string> strings = Solve();
            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }
        }

        public void SolveAll()
        {
            for(int i = 1; i <= 5; i++)
            {
                input = File.ReadAllLines(FolderPath + $"level{LevelNumber}_{i}.in");
                WriteOutput(i.ToString());
            }
        }
    }
}
