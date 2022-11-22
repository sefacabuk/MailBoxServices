using MailBoxServices.Business.Abstract;
using MailBoxServices.DataAccess.Abstract;
using MailBoxServices.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailBoxServices.Business.Concrete
{
    public class MailBoxManager : IMailBoxService
    {
        private IMailBoxRepository _mailBoxRepository;

        public MailBoxManager(IMailBoxRepository mailBoxRepository)
        {
            _mailBoxRepository = mailBoxRepository;
        }

        public MAIL_BOX CreateMailBox(MAIL_BOX mailBox)
        {
            return _mailBoxRepository.CreateMailBox(mailBox);
        }

        public void DeleteMailBox(string id)
        {

            _mailBoxRepository.DeleteMailBox(id);
        }

        public List<MAIL_BOX> GetAllMailBox()
        {
            return _mailBoxRepository.GetAllMailBox();
        }

        public MAIL_BOX GetMailBoxId(string id)
        {
            return _mailBoxRepository.GetMailBoxId(id);
        }

        public MAIL_BOX UpdateMailBox(MAIL_BOX mailBox)
        {
            return _mailBoxRepository.UpdateMailBox(mailBox);
        }
    }
}
