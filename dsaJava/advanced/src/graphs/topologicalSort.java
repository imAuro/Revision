package graphs;

import java.util.ArrayList;
import java.util.PriorityQueue;

public class topologicalSort {
    public static void main(String[] args) {

    }
    public  static ArrayList<Integer> solve(int A, ArrayList<ArrayList<Integer>> B) {
        int m=B.size();
        ArrayList<ArrayList<Integer>> edges= new ArrayList<>();
        int[] inArray=new int[A+1];
        for (int i=0;i<=A;i++)
        {
            edges.add(new ArrayList<>());
        }
        for (ArrayList<Integer> integers : B) {
            edges.get(integers.get(0)).add(integers.get(1));
            inArray[integers.get(1)]++;
        }
        PriorityQueue<Integer> pq= new PriorityQueue<>();
        for(int i=1;i<=A;i++)
        {
            if(inArray[i]==0)pq.add(i);
        }
        ArrayList<Integer> result=new ArrayList<Integer>();
        while(pq.size()>0)
        {
            int p=pq.poll();
            result.add(p);
            for( int e: edges.get(p))
            {
                inArray[e]--;
                if(inArray[e]==0) pq.add(e);
            }
        }
        return result;

    }

}

