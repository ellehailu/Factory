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

        [Required(ErrorMessage = "Machine installation date is required")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = false)]
        public DateTime InstallationDate { get; set; }

        public List<EngineerMachine> JoinEntities { get; }

    }
}