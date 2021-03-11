namespace DraftKingsOptimizeTeam.Models
{
    public class Salary
    {
        //Position,Name + ID,Name,ID,Roster Position,Salary,Game Info,TeamAbbrev,AvgPointsPerGame
        public string Position { get; set; }
        public string NameID { get; set; }
        public string Name { get; set; }
        public string ID { get; set; }
        public string RosterPosition { get; set; }
        public int SalaryValue { get; set; }
        public string GameInfo { get; set; }
        public string Team { get; set; }
        public string PPG { get; set; }

        public Salary(string[] values)
        {
            Position = values[0];
            NameID = values[1];
            Name = values[2];
            ID = values[3];
            RosterPosition = values[4];
            SalaryValue = int.Parse(values[5]);
            GameInfo = values[6];
            Team = values[7];
            PPG = values[8];
        }

    }
}
