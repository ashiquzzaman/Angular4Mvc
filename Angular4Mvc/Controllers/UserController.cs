using Angular4Mvc.Models;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;

namespace Angular4Mvc.Controllers
{
    public class UserController : ApiController
    {
        private ApplicationDbContext _db;

        public UserController()
        {
            _db = new ApplicationDbContext();
        }
        // GET api/values
        public IHttpActionResult Get()
        {
            var result = _db.Users.ToList();
            _db.Dispose();
            return Ok(result);
        }

        // GET api/values/5
        public IHttpActionResult Get(int id)
        {
            var result = _db.Users.FirstOrDefault(u => u.Id == id);
            _db.Dispose();
            return Ok(result);
        }

        // POST api/values
        public IHttpActionResult Post([FromBody]User model)
        {
            _db.Users.Add(model);
            var result = _db.SaveChanges();
            _db.Dispose();
            return Ok(result);
        }

        // PUT api/values/5
        public IHttpActionResult Put(int id, [FromBody]User model)
        {
            _db.Users.Attach(model);
            _db.Entry(model).State = EntityState.Modified;
            var result = _db.SaveChanges();
            _db.Dispose();
            return Ok(result);
        }

        // DELETE api/values/5
        public IHttpActionResult Delete(int id)
        {
            var user = _db.Users.First(u => u.Id == id);
            _db.Users.Remove(user);
            var result = _db.SaveChanges();
            _db.Dispose();
            return Ok(result);
        }
    }
}
