using System.Collections.Generic;
using System.Linq;
using CubeTest.TestCases;

namespace CubeTest
{
    public class CubeTestDataSource
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected static IEnumerable<object> BuildCalculateInnerVolumeTestCases()
        {
            var testCases = new[]
            { 
                  new VolumeTestCase { SideLength = 0, ExpectedVolume = 0 }
                , new VolumeTestCase { SideLength = 1, ExpectedVolume = 0 }
                , new VolumeTestCase { SideLength = 2, ExpectedVolume = 0 }
                , new VolumeTestCase { SideLength = 3, ExpectedVolume = 19 }
                , new VolumeTestCase { SideLength = 4, ExpectedVolume = 37 }
            };

            return testCases.Select(testCase => new object[]
            {  
                testCase.SideLength,
                testCase.ExpectedVolume            
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected static IEnumerable<object> BuildCalculateVolumeTestCases()
        {
            var testCases = new[]
            { 
                  new VolumeTestCase { SideLength = 0, ExpectedVolume = 0 }
                , new VolumeTestCase { SideLength = 1, ExpectedVolume = 1 }
                , new VolumeTestCase { SideLength = 2, ExpectedVolume = 8 }
                , new VolumeTestCase { SideLength = 3, ExpectedVolume = 27 }
            };

            return testCases.Select(testCase => new object[]
            {  
                testCase.SideLength,
                testCase.ExpectedVolume            
            });
        }
    }
}