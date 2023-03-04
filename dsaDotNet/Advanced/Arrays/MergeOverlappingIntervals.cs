using System;
using System.Linq;

namespace dsaDotNet.Advanced.Arrays
{
	

public class Interval
    {
        public int start;
        public int end;
        public Interval() { start = 0; end = 0; }
        public Interval(int s, int e) { start = s; end = e; }
    }

    class MergeOverlappingIntervals
    {
        public List<Interval> merge(List<Interval> intervals)
        {
            intervals.Sort((x, y) =>
            {
                return x.start.CompareTo(y.start);
            });
            List<Interval> ans = new List<Interval>();
            Stack<Interval> st = new Stack<Interval>();
            st.Push(intervals[0]);
            for (int i = 1; i < intervals.Count(); i++)
            {
                if (intervals[i].start < st.Peek().end)
                {
                    st.Peek().end = Math.Max(intervals[i].end, st.Peek().end); ;
                }
                else
                {
                    st.Push(intervals[i]);
                }

            }

            while (st.Count() > 0)
            {
                ans.Add(st.Pop());
            }
            List<Interval> result = new List<Interval>();

            return ans;


        }
    }
}

