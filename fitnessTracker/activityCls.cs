using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitnessTracker
{
    class activityCls
    {
        String activityID, activityTitle, metric1, metric2, metric3;
        public String AID
        {
            get { return activityID; }
            set { activityID= value;}
        }
        public String ATitle
        {
            get { return activityTitle; }
            set { activityTitle = value; }
        }
        public String Ametric1
        {
            get { return metric1; }
            set { metric1 = value; }
        }
        public String Ametric2
        {
            get { return metric2; }
            set { metric2 = value; }
        }
        public String Ametric3
        {
            get { return metric3; }
            set { metric3 = value; }
        }
    }
}
