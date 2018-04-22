using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webapp.Models;


namespace webapp.Controllers
{
    public class EventsController : Controller
    {
        // GET: Events
        public ActionResult Index()
        {
            //we do not heve index so i put redirect to home insead
            //redirect to home page to see beautiful logo
            return Redirect(Url.Content("~/"));
            //return View();
        }

        // /events/addevent
        public ActionResult AddEvent()
        {            
            return View();
        }
        [HttpGet]
        public ActionResult AddEvent1()
        {
            //metoda apelata cand intru pe pagina de Add Event
            return View();
        }
        [HttpPost]
        public ActionResult AddEvent1(Event ev)
        {
            Afisare(ev);
          //  using (EMA dc = new EMA())
            {
             //  dc.Events.Add(ev);
             //  dc.SaveChanges();
            }


                //metoda apelata cand dau pe butoon
                //primeste parametru un obiect de tip Event, il cheama model
                // si campurile din modelu asta le foloseste sa trimita la db         

                //  foreach (string key in formCollection.AllKeys) {
                //     Response.Write("Key = "+key+"  ");
                //      Response.Write(formCollection[key]);
                //      Response.Write("<br/>");
                //  }                       

                return View();
        }
        public ActionResult Afisare(Event ev)
        {
            Response.Write("Name: ");
            Response.Write(ev.name);
            Response.Write("<br/>");
            Response.Write("Date: ");
            Response.Write(ev.date);
            Response.Write("<br/>");
            Response.Write("Descriprion: ");
            Response.Write(ev.description);
            return RedirectToAction("Index");
            // return Redirect(Url.Content("~/"));
        }
        public ActionResult Cancel()
        {
            return RedirectToAction("Index");
           // return Redirect(Url.Content("~/"));
        }
        public ActionResult Baga(Event model)
        {
            //CRUD stuff goes here
            /*
             *  Dracul nu se-nchină popii,
                Corb la corb nu-şi scoate ochii,
                Drac la drac un rău făcut,
                Cine dracu-a mai văzut?!
             * /

           /* {
                string connectionString =
                        ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                   // numa ca, aici tre facuta un "procedure" care-i scris in sql
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("spAddEmployee", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter paramName = new SqlParameter();
                    paramName.ParameterName = "@Name";
                    paramName.Value = employee.Name;
                    cmd.Parameters.Add(paramName);

                    SqlParameter paramGender = new SqlParameter();
                    paramGender.ParameterName = "@Gender";
                    paramGender.Value = employee.Gender;
                    cmd.Parameters.Add(paramGender);

                    SqlParameter paramCity = new SqlParameter();
                    paramCity.ParameterName = "@City";
                    paramCity.Value = employee.City;
                    cmd.Parameters.Add(paramCity);

                    SqlParameter paramDateOfBirth = new SqlParameter();
                    paramDateOfBirth.ParameterName = "@DateOfBirth";
                    paramDateOfBirth.Value = employee.DateOfBirth;
                    cmd.Parameters.Add(paramDateOfBirth);

                    con.Open();
                    cmd.ExecuteNonQuery();
                   
                }
            }*/



            return RedirectToAction("Index"); 

        }


        // /events/delevent
        public ActionResult DelEvent()
        {
            return View();
        }

        // /events/editevent/index
        public ActionResult EditEvent()
        {
            return View();
        }

        // /events/viewall

        public ActionResult ViewEvents()
        {
            return View();
        }
    }
}