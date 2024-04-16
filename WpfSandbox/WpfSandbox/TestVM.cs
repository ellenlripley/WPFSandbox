using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WpfSandbox
{
    public class Pivot
    {
        public string DemandCategory { get; set; }

        public DateTime ReceiptDate { get; set; }

        public string Status { get; set; }

        public string LeadId { get; set; }

        public string Color { get; set; }
    }
   
    public  class TestVM
    {
        public TestVM(string dc, string nachname)
        {
            DemandCategory = dc;
            Color = nachname;

            Notifications = new List<SeamNotification>();

            for (int i = 0; i < 3; i++)
            {
                SeamNotification item = new SeamNotification();
                Notifications.Add(item);
            }

        }

        public string DemandCategory { get; set; }
        public string Color { get; set; }
        public List<SeamNotification> Notifications { get; set; }
    }

    public class SeamNotification
    {
        public string LeadId {
            get
            {
                return Guid.NewGuid().ToString();
            }
        }

        public DateTime ReceiptDate
        {
            get
            {
                return DateTime.Now;
            }
        }
        public string Status
        {
            get
            {
                return "Open";
            }
        }
    }

}
