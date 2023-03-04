package Subsets;

import java.util.ArrayList;
import java.util.Collections;
import java.util.Comparator;

public class subset {
    public static void main(String[] args) {
        subset.subsets(new ArrayList<Integer>());
    }

        public static ArrayList<ArrayList<Integer>> subsets(ArrayList<Integer> A) {
            ArrayList<ArrayList<Integer>> answer=new ArrayList<>();
            Collections.sort(A);
            int index=-1;
            for(int i=0;i<Math.pow(2, A.size());i++){
                ArrayList<Integer> eles=new ArrayList<>();
                for(int j=0;j<A.size();j++){
                    if((i&(1<<j))!=0){
                        eles.add(A.get(j));
                    }
                }
                answer.add(eles);
            }
            Collections.sort(answer, new Comparator<ArrayList<Integer>>() {
                @Override
                public int compare(ArrayList<Integer> o1, ArrayList<Integer> o2) {
                    if(o1.size()>0 && o2.size()>0){
                        for(int i=0;i<Math.min(o1.size(), o2.size());i++){
                            if(o1.get(i)!=o2.get(i))
                                return o1.get(i)-o2.get(i);
                        }
                    }
                    return 0;
                }
            });
            return answer;
        }

}
