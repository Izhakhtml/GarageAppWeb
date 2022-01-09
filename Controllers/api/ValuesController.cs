using GarageAppWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GarageAppWeb.Controllers.api
{
    public class ValuesController : ApiController
    {
        static string stringCooection = "Data Source=LAPTOP-K0H6TSU4;Initial Catalog=GarageDB;Integrated Security=True;Pooling=False;MultipleActiveResultSets=True;Application Name=EntityFramework";
        static GarageClassesDataContext context = new GarageClassesDataContext(stringCooection);
        // GET api/<controller>
        public IHttpActionResult Get()
        {
            List<Car> cars = new List<Car>();
            foreach(Car item in context.Cars)
            {
                Car car = new Car();
                car.ID = item.ID;
                car.NameOwner = item.NameOwner;
                car.CarNumber = item.CarNumber;
                car.IfPastTest = item.IfPastTest;
                cars.Add(car);
            }
            return Ok(cars);
        }

        // GET api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            return Ok(context.Cars.First(item => item.ID == id));
        }

        // POST api/<controller>
        public IHttpActionResult Post(Car item)
        {
            context.Cars.InsertOnSubmit(item);
            context.SubmitChanges();
            return Ok("add user to system");
        }

        // PUT api/<controller>/5
        public IHttpActionResult Put(int id, Car value)
        {
            Car car = context.Cars.First(item => item.ID == id);
            car.NameOwner = value.NameOwner;
            car.CarNumber = value.CarNumber;
            car.IfPastTest = value.IfPastTest;
            context.SubmitChanges();
            return Ok("The changes have been saved successfully");
        }

        // DELETE api/<controller>/5
        public IHttpActionResult Delete(int id)
        {
            context.Cars.DeleteOnSubmit(context.Cars.First(item => item.ID == id));
            context.SubmitChanges();
            return Ok("the user delete from system");
        }
    }
}