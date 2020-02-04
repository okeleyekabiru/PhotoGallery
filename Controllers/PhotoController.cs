using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using WebApi.Services;

namespace ConsumingExtermalApi.Controllers
{
    public class PhotoController:Controller
    {
       

        public async Task<ActionResult>  Index()
        {
           var model = await ApiHelper.GetAll();
           return View(model);
        }
    }
}