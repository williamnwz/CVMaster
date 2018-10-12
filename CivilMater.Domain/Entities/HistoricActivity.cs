using System;
using System.Collections.Generic;
using System.Text;

namespace CivilMater.Domain.Entities
{
    public class HistoricActivity : Entity
    {

        public HistoricActivity()
        {

        }

        public HistoricActivity(StatusActivityEnum status, string description)
        {
            Status = status;
            Description = description;
            DataHistoric = DateTime.Now;
        }

        public HistoricActivity(StatusActivityEnum status)
        {
            Status = status;
            DataHistoric = DateTime.Now;
        }

        public string Description { get; set; }

        public DateTime DataHistoric { get; set; }

        public StatusActivityEnum Status { get; set; }
    }
}
