using MailBoxServices.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailBoxServices.Business.Abstract
{
    public interface IMailBoxService
    {
        List<MAIL_BOX> GetAllMailBox();
        MAIL_BOX GetMailBoxId(string id);
        MAIL_BOX CreateMailBox(MAIL_BOX mailBox);
        MAIL_BOX UpdateMailBox(MAIL_BOX mailBox);
        void DeleteMailBox(string id);
    }
}
