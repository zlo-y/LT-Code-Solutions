public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<char>[] rows = new HashSet<char>[9];
        HashSet<char>[] cols = new HashSet<char>[9];
        HashSet<char>[] boxes = new HashSet<char>[9];

        for(int i = 0; i < 9; i ++){
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
            boxes[i] = new HashSet<char>();
        }
        
        for(int r = 0; r < 9; r++){
            for(int c = 0; c < 9; c++){
                char val = board[r][c];

                if(val == '.') continue;

                int boxIdx = (r/3) * 3 + (c/3);

                if(!rows[r].Add(val) || !cols[c].Add(val) || !boxes[boxIdx].Add(val)){
                    return false;
                }

            }
           
        }
        return true;
    }
}
