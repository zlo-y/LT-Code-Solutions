public class Solution {
    public int BinaryGap(int n) {
       int rec = 0;
       int index = 0;
       int last = -1;

       while(n > 0){
        if((n & 1) == 1){
            if(last != -1)
                rec = Math.Max(rec , index - last);
               last = index;
        }
        n >>= 1;
        index++;
       }
       return rec;
       
    }
}
