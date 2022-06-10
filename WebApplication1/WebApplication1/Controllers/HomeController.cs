using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {

        [HttpGet]
        public List<Tblsample> Get()
        {
            SampleDB1Context db = new SampleDB1Context();
            return db.Tblsamples.ToList();
        }

        [HttpPost]
        public string Post([FromBody] string sample)
        {
            SampleDB1Context db = new SampleDB1Context();
            Tblsample s = new Tblsample();
            s.Text = sample;
            db.Tblsamples.Add(s);
            db.SaveChanges();
            return "Success";
        }
        [HttpPut]
        public string Put([FromBody] Tblsample tblsample)
        {
            SampleDB1Context db = new SampleDB1Context();
            var tblsampleObj = db.Tblsamples.Where(x => x.Id == tblsample.Id);
            if (tblsampleObj != null)
            {
                db.Tblsamples.Update(tblsample);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }

        [HttpDelete]
        public string Delete([FromBody] int Id)
        {
            SampleDB1Context db = new SampleDB1Context();
            var tblsampleObj = db.Tblsamples.Where(x => x.Id == Id).FirstOrDefault();
            if (tblsampleObj != null)
            {
                db.Tblsamples.Remove(tblsampleObj);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }
    }
}
