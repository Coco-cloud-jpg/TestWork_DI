using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Exoft_Task
{
    public class Client : IHuman
    {
        private IAnounceMessage _msger;
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public int Id { get; set; }
        public Client(IAnounceMessage msger = null) {
            _msger = msger;
        }
        public void AnounceArrival() {
            _msger?.SendMessage($"{Name} {Surname} has arrived at: " + DateTime.Now.ToString());
        }
        
    }
}
