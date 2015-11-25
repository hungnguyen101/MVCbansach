using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCbansach.Models;
using PagedList;
using System.Security.Cryptography;
using System.Text;
using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;


namespace MVCbansach.Controllers
{
    public class AccountController : Controller
    {
        BookStoreOnlineEntities db = new BookStoreOnlineEntities();
        AccountService.AccountClient serv = new AccountService.AccountClient();
        
        // GET: Account
        [HttpGet]
        public ActionResult Login()
        {
            Session["username"] = null;
            return View("Login");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel AccountOjb)
        {
            if (AccountOjb.Username != null && AccountOjb.Password != null)
            {
                if (ModelState.IsValid)
                {
                    AccountService.Account account = serv.Authenticate(AccountOjb.Username, getMd5Hash(AccountOjb.Password));
                    if (account == null)
                    {
                        ModelState.AddModelError("", "Tên đăng nhập hoặc tài khoản không đúng");
                        ViewBag.LoginFaild = "Tên đăng nhập hoặc tài khoản không đúng";
                        return RedirectToAction("Login", "Account");
                    }
                    else
                    {
                        Session["username"] = AccountOjb.Username;
                        Session["userid"] = serv.findById(account.id).id;
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    ViewBag.LoginFaild = "Kiểm tra thông tin không hợp lệ";
                    return RedirectToAction("Login", "Account", AccountOjb);
                }
            }
            else
            {
                ViewBag.LoginFaild = "Vui lòng nhập chính xác thông tin";
                return RedirectToAction("Login", "Account", AccountOjb);
            }
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UpdatePassword()
        {
            //not sign in
            if (Session["userid"] == null)
            {
                ViewBag.LoginFaild = "Vui lòng đăng nhập";
                return RedirectToAction("Login", "Account");
            }
            else
            {
                string CurrentPassword = Request["CurrentPassword"];
                string ReNewPassword = Request["ReNewPassword"];
                string NewPassword = Request["NewPassword"];
                long AccountId = Convert.ToInt64(Session["userid"]);

                // find account
                AccountService.Account account = serv.findById(Convert.ToInt64(AccountId));

                // indentify account
                if (account.Password != getMd5Hash(CurrentPassword))
                {
                    Session["ErrorMessage"] = "Password này không đúng với password hiện tại";
                    return RedirectToAction("MyAccount", "Account");
                }
                else
                {
                    // compare two new password
                    if (NewPassword != ReNewPassword)
                    {
                        Session["ErrorMessage"] = "Password này không đúng với password hiện tại";
                        return RedirectToAction("MyAccount", "Account");
                    }
                    else
                    {
                        // set new password to current account
                        account.Password = getMd5Hash(NewPassword);
                        bool UpdateResult = serv.update(account);
                        if (UpdateResult == false)
                        {
                            Session["ErrorMessage"] = "Đổi mật khẩu thất bại";
                        }
                        else
                        {
                            Session["SuccessMessage"] = "Đổi password thành công";
                        }                       
                        return RedirectToAction("MyAccount", "Account");
                    }                    
                }
            }      
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UpdateInformation()
        {
            //not sign in
            if (Session["userid"] == null)
            {
                ViewBag.LoginFaild = "Vui lòng đăng nhập";
                return RedirectToAction("Login", "Account");
            }
            else
            {
                string Name = Request["Fullname"];
                string Address = Request["Address"];
                string Phone = Request["Phone"];
                string Email = Request["Email"];
                long AccountId = Convert.ToInt64(Session["userid"]);

                // find account
                AccountService.Account account = serv.findById(Convert.ToInt64(AccountId));

                // set new information
                account.Fullname = Name;
                account.Address = Address;
                account.Phone = Phone;
                account.Email = Email;

                bool UpdateResult = serv.update(account);
                if (UpdateResult == false)
                {
                    Session["ErrorMessage"] = "Cập nhật thông tin thất bại";
                }
                else
                {
                    Session["SuccessMessage"] = "Cập nhật thông tin thành công";
                }
                return RedirectToAction("MyAccount", "Account");
                
            }
        }

        // Register account
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(AccountService.Account AccountObj)
        {
            // set data default
            AccountObj.Status = true;
            AccountObj.CreatedAt = DateTime.Now;
            AccountObj.GroupId = "admin";


            // insert an account 
            long InsertResult = serv.insert(AccountObj);
            if ( InsertResult == -1) // if it's not work
            {
                return RedirectToAction("Index", "Home");
                
            }
            else
            {
                ViewBag.LoginSucess = "Đăng ký thành công";
                return RedirectToAction("Login", "Account", InsertResult);
            }
        }

        public ActionResult Logout()
        {
            Session.RemoveAll();
            return RedirectToAction("Index","Home");
        }

        private bool isValidContentype(string contentType)
        {
            return contentType.Equals("image/png") || contentType.Equals("image/gif") ||
                contentType.Equals("image/jpg") || contentType.Equals("image/jpeg");
        }

        private bool isValidContentLength(int ContentLength)
        {
            return ((ContentLength / 2014) / 1024) < 1; //1mb
        }



        [HttpPost]
        public ActionResult UploadFile(HttpPostedFileBase photo)
        {
            if (!isValidContentype(photo.ContentType))
            {
                ViewBag.Error = "Chỉ được phép upload những file png, jpeg, gif, jpg";
                return RedirectToAction("MyAccount", "Account");
            }
            else if (!isValidContentLength(photo.ContentLength))
            {
                ViewBag.Error = "Dung lượng hình quá lớn. Kích cỡ phù hợp là nhỏ hơn 1 MB";
                return RedirectToAction("MyAccount", "Account");
            }
            else
            {
                if (photo.ContentLength > 0)
                {
                    var fileName = Path.GetFileName(photo.FileName);
                    var path = Path.Combine(Server.MapPath("~/Content/Upload/Avatar"), fileName);
                    photo.SaveAs(path);

                    AccountService.Account account = serv.findById(Convert.ToInt64(Session["userid"]));

                    // set new information
                    account.Avatar = fileName;

                    bool UpdateResult = serv.update(account);
                    if (UpdateResult == false)
                    {
                        Session["ErrorMessage"] = "Cập nhật avatar thất bại";
                    }
                    else
                    {
                        Session["SuccessMessage"] = "Cập nhật avartar thành công";
                    }
                    return RedirectToAction("MyAccount", "Account");
                }
            }
            return RedirectToAction("MyAccount", "Account");
        }


        private string UploadImage(string filename)
        {
            string url = @"https://api.imgur.com/3/image";
            string key = @"Client-ID 453ed82ac0c751b";
            WebRequest req = WebRequest.Create(url);
            req.Headers.Add(HttpRequestHeader.Authorization, key);
            req.Method = "POST";
            byte[] data = System.IO.File.ReadAllBytes(filename);
            using (var stream = req.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }
            var response = (HttpWebResponse)req.GetResponse();

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            JObject json = JObject.Parse(responseString);
            string link = json["data"]["link"].ToString();
            return link;
        }

        public ActionResult List()
        {
            return View();
        }

        public PartialViewResult LeftPartPartial()
        {
            return PartialView();
        }
        public ActionResult MyAccount()
        {
            AccountService.Account Account = new AccountService.Account();
            if (Session["userid"] == null)
            {
                return RedirectToAction("Login", "Account");
            }
            else
            {
                Account = serv.findById(Convert.ToInt64( Session["userid"]));
                if (Account == null)
                {
                    ViewBag.LoginSucess = "Account doesn't exist!";
                    return RedirectToAction("Login", "Account");
                }
            }
            return View(Account);
        }
        public PartialViewResult _HeaderPartial()
        {
            return PartialView();
        }
        static string getMd5Hash(string input)
        {
            // Create a new instance of the MD5CryptoServiceProvider object.
            MD5 md5Hasher = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
    }
}