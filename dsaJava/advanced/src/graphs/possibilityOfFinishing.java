package graphs;

import java.util.ArrayList;
import java.util.PriorityQueue;

public class possibilityOfFinishing {
    public static void main(String[] args) {

    }


    public int solve(int A, ArrayList<Integer> B, ArrayList<Integer> C) {
        int m=B.size();
        int[] inArray=new int[A+1];
        ArrayList<ArrayList<Integer>> edges=new ArrayList<ArrayList<Integer>>();
        for( int i=0;i<=A;i++)
        {
            edges.add(new ArrayList<Integer>());
        }
        for( int i=0;i<m;i++)
        {
            edges.get(B.get(i)).add(C.get(i));
            inArray[C.get(i)]++;
        }
        PriorityQueue<Integer> pq=new PriorityQueue<>();
        for(int i=1;i<=A;i++)
        {
            if(inArray[i]==0)pq.add(i);
        }

        while(pq.size()>0)
        {
            int p=pq.poll();
            A--;
            for(int  e: edges.get(p))
            {
                inArray[e]--;
                if(inArray[e]==0)pq.add(e);
            }
        }
        return (A==0)?1:0;
    }
}


