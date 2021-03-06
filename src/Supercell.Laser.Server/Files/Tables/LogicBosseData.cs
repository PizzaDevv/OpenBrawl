namespace Supercell.Laser.Server.Files.Tables
{
using Supercell.Laser.Server.Files.CsvReader;
using Supercell.Laser.Server.Files.CsvHelpers;
    public class LogicBosseData : CsvData
    {
        public LogicBosseData(Row row, DataTable datatable) : base(row, datatable)
        {
            LoadData(this, GetType(), row);
        }

        public string Name { get; set; }

        public string TID { get; set; }

        public int PlayerCount { get; set; }

        public int RequiredCampaignProgressToUnlock { get; set; }

        public string Location { get; set; }

        public string AllowedHeroes { get; set; }

        public string Reward { get; set; }

        public int LevelGenerationSeed { get; set; }

        public string Map { get; set; }

        public string Boss { get; set; }

        public int BossLevel { get; set; }
    }
}
