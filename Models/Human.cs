using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exoft_Task
{
    public interface IHuman
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Id { get; set; }

        public void Deconstruct(out string Name, out string Surname, out int Id)
        {
            Name = this.Name;
            Surname = this.Surname;
            Id = this.Id;
        }

    }
    public static class Creator{
        static string[] names = new[] {
            "John","Hugh","Evy","Chlorine","Aezakmi"};
        static string[] surnames = new[] {
            "Smith","Black","White","Brown","Erasor"};
        public static IHuman SetDefault(IAnounceMessage msger = null) {
            var rng = new Random();
            return new Client(msger)
            {
                Name = names[rng.Next(0, names.Length)],
                Surname = surnames[rng.Next(0, surnames.Length)],
                Id = rng.Next(0, int.MaxValue)
            };
        }
        public static IHuman SetDefaultMentor()
        {
            var rng = new Random();
            return new Mentor()
            {
                Name = names[rng.Next(0, names.Length)],
                Surname = surnames[rng.Next(0, surnames.Length)],
                Id = rng.Next(0, int.MaxValue),
                subordinate = SetDefault()
            };
        }
    }
}
