package graphs;

import java.util.ArrayList;
import java.util.Comparator;
import java.util.PriorityQueue;

public class reversingEdges {
    public static void main(String[] args) {


    }

    int max=100001;
    public int reverseEdges(int A, ArrayList<ArrayList<Integer>> B) {
        int m=B.size();
        ArrayList<ArrayList<pair>> edges=new ArrayList<ArrayList<pair>>();

        for( int i=0;i<=A;i++)
        {
            edges.add(new ArrayList<pair>());
        }
        for(int i=0;i<m;i++)
        {
            edges.get(B.get(i).get(0)).add(new pair(0,B.get(i).get(1)));
            edges.get(B.get(i).get(1)).add(new pair(1,B.get(i).get(0)));
        }


        int[] sp=new int[A+1];
        for(int i=0;i<=A;i++)
        {
            sp[i]=max;
        }
        PriorityQueue<pair> pq=new PriorityQueue<pair>(new pairComparator());
        pq.add(new pair(0,1));
        sp[1]=0;
        while(pq.size()>0)
        {
            pair p=pq.poll();
            for(pair e: edges.get(p.node))
            {
                if(sp[e.node]>p.weight+e.weight)
                {
                    sp[e.node]=p.weight+e.weight;
                    pq.add(e);
                }

            }
        }
        return sp[A];
    }

}
class pair
{
    int weight;
    int node;
    public pair(int weight,int node)
    {
        this.weight=weight;
        this.node=node;
    }
}
class pairComparator implements Comparator<pair> {
    @Override
    public int compare(pair a, pair b) {
        if (a.weight < b.weight) return -1;
        if (a.weight > b.weight) return 1;
        return 0;
    }

}

