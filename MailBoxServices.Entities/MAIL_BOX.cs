using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailBoxServices.Entities
{
    public class MAIL_BOX
    {
        public string ID { get; set; }
        public string MAIL_NAME { get; set; }
        public string SUBJECT { get; set; }
        public string CONTENT { get; set; }
        public DateTime DATE_TIME { get; set; }
        public bool ISREAD { get; set; } = false;
    }
}
