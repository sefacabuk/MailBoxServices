using MailBoxServices.Business.Abstract;
using MailBoxServices.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MailBoxServices.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class MailBoxController : ControllerBase
    {
        private IMailBoxService _mailBoxService;

        public MailBoxController(IMailBoxService mailBoxService)
        {
            _mailBoxService = mailBoxService;
        }

        [HttpGet]
        public List<MAIL_BOX> Get()
        {
            return _mailBoxService.GetAllMailBox();
        }

        [HttpGet("{id}")]
        public MAIL_BOX Get(string id)
        {
            return _mailBoxService.GetMailBoxId(id);
        }

        [HttpPost]
        public MAIL_BOX Post(MAIL_BOX mailBox)
        {
            return _mailBoxService.CreateMailBox(mailBox);
        }

        [HttpPut]
        public MAIL_BOX Put([FromBody] MAIL_BOX mailBox)
        {
            return _mailBoxService.UpdateMailBox(mailBox);
        }
       
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _mailBoxService.DeleteMailBox(id);
        }

    }
}
