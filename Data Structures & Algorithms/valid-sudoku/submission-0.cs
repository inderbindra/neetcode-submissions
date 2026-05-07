public class Solution {
    public bool IsValidSudoku(char[][] board) {
        Dictionary<int, HashSet<char>> rowMap = new();
        Dictionary<int, HashSet<char>> colMap = new();
        Dictionary<(int row, int col), HashSet<char>> matrixMap = new();

        int r=0, c=0, row=0, col=0;
        for(r=0; r<board.Length; r++)
        {
            for(c=0; c<board[r].Length; c++)
            {
                if(board[r][c] == '.')
                {
                    continue;
                }
                row = r/3;
                col = c/3;
                if(rowMap.ContainsKey(r) && rowMap[r].Contains(board[r][c]) ||
                colMap.ContainsKey(c) && colMap[c].Contains(board[r][c]) ||
                matrixMap.ContainsKey((row,col)) && matrixMap[(row,col)].Contains(board[r][c]))
                {
                    return false;
                }
                rowMap.TryAdd(r, new HashSet<char>());
                rowMap[r].Add(board[r][c]);
                
                colMap.TryAdd(c, new HashSet<char>());
                colMap[c].Add(board[r][c]);

                matrixMap.TryAdd((row, col), new HashSet<char>());
                matrixMap[(row, col)].Add(board[r][c]);
            }
        }
        return true;
    }
}
