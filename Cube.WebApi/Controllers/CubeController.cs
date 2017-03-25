using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;
using Cube.WebApi.Models;

namespace Cube.WebApi.Controllers
{
    [EnableCors("http://localhost:4201", "*", "*")]
    public class CubeController : ApiController
    {
        // GET api/cube
        public IEnumerable<CubeVM> Get(string sides)
        {
            var arrSides = sides.Split(',');

            var cubeVms = new List<CubeVM>();

            foreach (var strSide in arrSides)
            {
                var side = Convert.ToInt32(strSide);

                var cube = new Cube(side);

                var volume = cube.GetVolume();
                var innerCubeVolume = cube.GetInnerVolume();

                cubeVms.Add(new CubeVM
                {
                    Side = side, 
                    Volume = volume, 
                    InnerCubeVolume = innerCubeVolume
                });
            }

            return cubeVms;
        }
    }
}
