using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Factory.Models
{
    public class Machine
    {
        public int MachineId { get; set; }
        [Required(ErrorMessage = "Machine name is required")]
        public string Name { get; set; }

        public DateTime InstallationDate { get; set; }

        public List<EngineerMachine> JoinEntities { get; }

    }
}