using MailBoxServices.DataAccess.Abstract;
using MailBoxServices.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailBoxServices.DataAccess.Concrete
{
    public class MailBoxRepository : IMailBoxRepository
    {
        public MAIL_BOX CreateMailBox(MAIL_BOX mailBox)
        {
            using (var mailBoxDbContext = new MailBoxDbContext())
            {
                mailBox.ID = Guid.NewGuid().ToString();
                mailBoxDbContext.MailBox.Add(mailBox);
                mailBoxDbContext.SaveChanges();
                return mailBox;

            }
        }

        public void DeleteMailBox(string id)
        {
            using (var mailBoxDbContext = new MailBoxDbContext())
            {
                var deleteMailBox = GetMailBoxId(id);
                mailBoxDbContext.MailBox.Remove(deleteMailBox);
                mailBoxDbContext.SaveChanges();
            }
        }

        public List<MAIL_BOX> GetAllMailBox()
        {
            using (var mailBoxDbContext = new MailBoxDbContext())
            {
                return mailBoxDbContext.MailBox.ToList();

            }
        }

        public MAIL_BOX GetMailBoxId(string id)
        {
            using (var mailBoxDbContext = new MailBoxDbContext())
            {
                return mailBoxDbContext.MailBox.Find(id);
            }
        }

        public MAIL_BOX UpdateMailBox(MAIL_BOX mailBox)
        {
            using (var mailBoxDbContext = new MailBoxDbContext())
            {
                mailBoxDbContext.MailBox.Update(mailBox);
                mailBoxDbContext.SaveChanges();
                return mailBox;

            }
        }
    }
}
