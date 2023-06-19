using System;

namespace ClassLibrary2
{
    public class Class1
    {
        public double MinAVG(string[] marks)
        {
            if (marks == null || marks.Length == 0)
            {
                throw new ArgumentException("The 'marks' array cannot be null or empty");
            }
           



            int[] mark = Array.ConvertAll(marks, s => int.Parse(s));

            int sum = mark[0] + mark[1] + mark[2] + mark[3] + mark[4];


            double avg = (double)sum / marks.Length;
            double roundedavg = Math.Floor(avg);
            return roundedavg;
        }
    }
    }

