using LinqToDB.Mapping;

namespace AccessConsole
{
    public class IC_INFO
    {
        [PrimaryKey]
        public string ICINFO_KEY { get; set; }

        public string ICINFO_VALUE { get; set; }
    }
}