using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CivilMater.Domain.Entities
{
    public class Activity : Entity
    {
        public string Name { get; protected set; }

        public string Description { get; protected set; }

        public Collaborator Colaborator { get; protected set; }

        public Work Work { get; protected set; }

        public ICollection<HistoricActivity> HistoricActivities { get; set; }

        public void IncludeHistoricActivity(StatusActivityEnum status, string description = "")
        {
            if (HistoricActivities == null || HistoricActivities.Any() == false)
                HistoricActivities = new List<HistoricActivity>();

            HistoricActivity historicActivity = new HistoricActivity(status, description);
            historicActivity.CreateId();
            historicActivity.Active();

            HistoricActivities.Add(historicActivity);


        }

        public Activity ParentActivity { get; set; }

        public ICollection<Activity> SubActivities { get; set; }







    }
}
