using real.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace real.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Code()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Code(string mobile, string activation)
        {
            dbDataContext db = new dbDataContext();

            var cur = (from p in db.sms_dbs where p.mobile == mobile && p.activation == activation && p.is_used == false select p).SingleOrDefault();
            if (cur != null)
            {
                cur.is_used = true;
                db.SubmitChanges();
                int examID = db.sms_ExamCreate_2(mobile);

                sms_exam _obj;
                _obj = db.sms_exams.SingleOrDefault(x => x.id == examID);
                
                return Redirect("~/home/exam/"+ _obj.quidval);
            }
            else
            {
                ViewBag.Message = "Код болон дугаараа шалгана уу.";
                return View();
            }
        }

        [HttpGet]
        public ActionResult Exam(string guid)
        {
            this.Session["guid"] = Request.Url.ToString().Split('/').Last();
            return View();
        }

        public ActionResult Quiz()
        {
            MessagesRepository _messageRepository = new MessagesRepository();
            return PartialView("_Quiz", _messageRepository.GetQuizAsuult(this.Session["guid"].ToString()));
        }

        public ActionResult QuizChoice()
        {
            MessagesRepository _messageRepository = new MessagesRepository();
            return PartialView("_QuizChoice", _messageRepository.GetQuizHariult(4034));
        }

        public PartialViewResult _QuizChoice(int qid)
        {
            MessagesRepository _messageRepository = new MessagesRepository();
            var vm = _messageRepository.GetQuizHariult(qid);
            return PartialView(vm);
        }

        //public ActionResult QuizChoice(int qid)
        //{
        //    MessagesRepository _messageRepository = new MessagesRepository();
        //    return PartialView("_QuizChoice", _messageRepository.GetQuizHariult(qid));
        //}

        public ActionResult GetMessages()
        {
            MessagesRepository _messageRepository = new MessagesRepository();
            return PartialView("_MessagesList", _messageRepository.GetAllMessages());

            //dbDataContext db = new dbDataContext();
            //var list = (from c in db.sms_dbs orderby c.id descending select c).Take(10);
            //return PartialView("_MessagesList", list);
        }
    }
}