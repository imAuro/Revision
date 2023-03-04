package graphs;

import java.util.ArrayList;
import java.util.Comparator;
import java.util.PriorityQueue;

public class djkstra {
    public static void main(String[] args) {

    }
    int max=100001;
    public static ArrayList<Integer> solve(int A, ArrayList<ArrayList<Integer>> B, int C) {
        int m=B.size();
        int maxtime=100000001;
        boolean[] visited=new boolean[A];
        ArrayList<Integer> time=new ArrayList<Integer>();
        for(int i=0;i<A;i++)
        {
            time.add(maxtime);
        }
        ArrayList<ArrayList<Pair>> edges=new ArrayList<ArrayList<Pair>>();
        for( int i=0;i<A;i++)
        {
            edges.add(new ArrayList<Pair>());
        }
        for(int i=0;i<m;i++)
        {
            edges.get(B.get(i).get(0)).add(new Pair(B.get(i).get(2),B.get(i).get(1)));
            edges.get(B.get(i).get(1)).add(new Pair(B.get(i).get(2),B.get(i).get(0)));
        }

        PriorityQueue<Pair> pq=new PriorityQueue<Pair>(new timeComparator());
        pq.add(new Pair(0,C));
        time.set(C,0);
        while(pq.size()>0)
        {
            Pair p= pq.poll();
            if(visited[p.node]) continue;
            visited[p.node]=true;
            for(Pair e: edges.get(p.node))
            {
                if(visited[e.node]) continue;

                if(time.get(e.node)>p.time+e.time)
                {
                    time.set(e.node,p.time+e.time);
                    pq.add(new Pair(time.get(e.node),e.node));
                }
            }
        }
        for( int i=0;i<time.size();i++)
        {
            if(time.get(i)==maxtime) time.set(i,-1);
        }

        return time;

    }
}

class timeComparator implements Comparator<Pair>{

    @Override
    public int compare(Pair p1,Pair p2)
    {
        if(p1.time<p2.time) return -1;
        if(p1.time>p2.time) return 1;
        return 0;
    }
}
class Pair {
    public int time;
    public int node;
    public Pair(int time,int node)
    {
        this.time=time;
        this.node=node;
    }
}

