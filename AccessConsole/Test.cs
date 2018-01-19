using System;
using LinqToDB.Mapping;

namespace AccessConsole
{
    [Table( "Tests" )]
    public class Test
    {
        [Column]
        public int Age { get; set; }

        [Column]
        public string FirstName { get; set; }

        [Column, PrimaryKey]
        public Guid Id { get; set; }
    }
}