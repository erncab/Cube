using System;
using System.Collections.Generic;
using System.Web.Http;
using Cube.WebApi.Models;

namespace Cube.WebApi.Controllers
{
    public class CubeController : ApiController
    {
        // GET api/cube
        public IEnumerable<Pair> Get(VolumeType volumeType, string sides)
        {
            var arrSides = sides.Split(',');

            var pairs = new List<Pair>();

            foreach (var strSide in arrSides)
            {
                var side = Convert.ToInt32(strSide);

                var cube = new Cube(side);

                int volume;

                switch (volumeType)
                {
                    case VolumeType.FullCube:
                        volume = cube.GetVolume();
                        break;

                    case VolumeType.InnerCube:
                        volume = cube.GetInnerVolume();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException("volumeType", volumeType, null);
                }

                pairs.Add(new Pair { Side = side, Volume = volume });
            }

            return pairs;
        }
    }
}
