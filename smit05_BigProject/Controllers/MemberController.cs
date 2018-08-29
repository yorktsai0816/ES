using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using smit05_BigProject.Models;

namespace smit05_BigProject.Controllers {
    public class MemberController : Controller {
        MarketGoEntities db = new MarketGoEntities();
        //---------------------------------------------------------------
        // 會員註冊_主辦
        // v2_082918_E_尚未加上bool
        public ActionResult Member_register_host() {
            var mgmh = new Models.MGmember();
            return View(mgmh);
        }
        [HttpPost]
        public ActionResult Member_register_host(MGmember mgmh) {
            if (string.IsNullOrEmpty(mgmh.M_account)) {
                return View("Member_register_host", mgmh);
            }
            else {
                mgmh.M_identity = "1";
                db.MGmembers.Add(mgmh);
                db.SaveChanges();
                Session["memberHost_ID"] = mgmh.M_ID;
                Session["memberHost_identity"] = mgmh.M_identity;
                //return Content(Session["memberHost_identity"].ToString()); //確認數值用
                return Content("<script>alert('會員註冊成功');window.location.href='/Member/Member_register_host'</script>");
            }
        }

        // 會員註冊_攤主
        // v2_082918_E_尚未加上bool
        public ActionResult Member_register_seller() {
            var mgms = new MGmember();
            return View(mgms);
        }
        [HttpPost]
        public ActionResult Member_register_seller(MGmember mgms) {
            if (string.IsNullOrEmpty(mgms.M_account)) {
                return View("Member_register_seller", mgms);
            }
            else {
                mgms.M_identity = "2";
                db.MGmembers.Add(mgms);
                db.SaveChanges();
                Session["memberSeller_ID"] = mgms.M_ID;
                Session["memberSeller_identity"] = mgms.M_identity;
                //return Content(Session["memberSeller_identity"].ToString()); //確認數值用
                return Content("<script>alert('會員註冊成功');window.location.href='/Member/Member_register_seller'</script>");
            }
        }

        // 會員註冊_一般會員
        // v2_082918_E_尚未加上bool
        public ActionResult Member_register() {
            var mgm = new MGmember();
            return View(mgm);
        }
        [HttpPost]
        public ActionResult Member_register(MGmember mgm) {
            if (string.IsNullOrEmpty(mgm.M_account)) {
                return View("Member_register", mgm);
            }
            else {
                mgm.M_identity = "3";
                db.MGmembers.Add(mgm);
                db.SaveChanges();
                Session["member_ID"] = mgm.M_ID;
                Session["member_identity"] = mgm.M_identity;
                //return Content(Session["memberSeller_identity"].ToString()); //確認數值用
                return Content("<script>alert('會員註冊成功');window.location.href='/Member/Member_register'</script>");
            }
        }
        //---------------------------------------------------------------
    }
}