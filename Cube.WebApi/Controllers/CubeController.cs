using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;
using Cube.WebApi.Models;

namespace Cube.WebApi.Controllers
{
    [EnableCors("http://localhost:4200", "*", "*")]
    public class CubeController : ApiController
    {
        // GET api/cube
        public IEnumerable<CubeVM> Get(string sides)
        {
            var arrSides = sides.Split(',');

            var pairs = new List<CubeVM>();

            foreach (var strSide in arrSides)
            {
                var side = Convert.ToInt32(strSide);

                var cube = new Cube(side);

                var volume = cube.GetVolume();
                var innerCubeVolume = cube.GetInnerVolume();

                pairs.Add(new CubeVM
                {
                    Side = side, 
                    Volume = volume, 
                    InnerCubeVolume = innerCubeVolume
                });
            }

            return pairs;
        }
    }
}
