using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exoft_Task
{
    public class Mentor : IHuman
    {
        private IHuman _subordinate = null;
        public string Post { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Id { get; set; }

        public IHuman subordinate{
            get {
                return _subordinate ?? (_subordinate = new Client(new InConsole()));
            }
            set {
                if (_subordinate!=null) {
                    return;
                }
                if (value != null)
                    _subordinate = value;
            }
        }

    }
}
