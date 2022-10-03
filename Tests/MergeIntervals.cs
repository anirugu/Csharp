using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Tests
{
    public class MergeIntervals
    {
        [Fact]
        public void Test()
        {
            
        }


        public int[][] Merge(int[][] intervals)
        {
            if (intervals == null || intervals.Length == 0 || intervals.Length == 1)
                return intervals;
            var dataSet = intervals.OrderBy(x=>x);
          
            //for(int i = 0; i < dataSet.Count(); i++)
            //{
            //    if (dataSet[i][1] > dataSet[i + 1][0])
            //    {
            //        dataSet[i][1] = dataSet[i + 1][1];
            //        dataSet.remove;
            //    }
            //}
            return new int[][] {};
        }
    }
}
