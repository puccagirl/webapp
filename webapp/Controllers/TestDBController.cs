using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webapp.Controllers
{
    public class TestDBController : Controller
    {
        // GET: TestDB
        DataSet dcusr = new DataSet();
        //SqlConnection myCon = new SqlConnection(connectionString: "Server=DESKTOP-GU4U896\\SQLEXPRESS;Database=EMA;Trusted_Connection=True;");
        //asta de jos ii ip pe care ii serveru sql aka ip lu' ravel
        //SqlConnection myCon = new SqlConnection(connectionString: "Server=2a02:2f0e:120:5af:48b:1fc9:e9db:2cfe,1433; Database=EMA;User Id = admin;Password =hunter2;");

        SqlConnection myCon = new SqlConnection(connectionString: "Server = tcp:sqlema.database.windows.net, 1433; Initial Catalog = EMA; Persist Security Info=False;User ID = adminn; Password= Hunter22; MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;");

    public ActionResult Index()
        {

            try
            {
                //myCon.ConnectionString = @"EMA";
                myCon.Open();
            }
            catch (IOException e) { }

            //myCon.ConnectionString = "EMA";
            //myCon.Open();
            
            List<Models.User> user = new List<Models.User>();
            SqlDataAdapter dusr = new SqlDataAdapter("SELECT * FROM [Users]", myCon);
            dusr.Fill(dcusr,"Users");

            foreach (DataRow dr in dcusr.Tables["Users"].Rows)
            {
                String name = dr.ItemArray.GetValue(1).ToString();
                String pass = dr.ItemArray.GetValue(2).ToString();
                user.Add(new Models.User { username = name, password = pass });
            }
            myCon.Close();
            
            return View(user);
        }

        // GET: TestDB/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TestDB/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TestDB/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: TestDB/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TestDB/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: TestDB/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TestDB/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
