package graphs;

import java.util.ArrayList;
import java.util.PriorityQueue;

public class cycleInDirectedGraph {
    public static void main(String[] args) {

    }

    public static int solve(int A, ArrayList<ArrayList<Integer>> B) {
        int m=B.size();
        int[] inArray=new int[A+1];

        ArrayList<ArrayList<Integer>> edges=new ArrayList<ArrayList<Integer>>();
        for(int i=0;i<=A;i++)
        {
            edges.add(new ArrayList<Integer>());
        }
        for(int i=0;i<m;i++)
        {
            edges.get(B.get(i).get(0)).add(B.get(i).get(1));
            inArray[B.get(i).get(1)]++;
        }
        PriorityQueue<Integer> pq=new PriorityQueue<Integer>();

        for( int i=1;i<=A;i++)
        {
            if(inArray[i]==0)pq.add(i);
        }
        while(pq.size()>0)
        {
            int p=pq.poll();
            A--;
            for(int i: edges.get(p))
            {
                inArray[i]--;
                if(inArray[i]==0)pq.add(i);
            }
        }
        return (A==0)?0:1;
    }
}
