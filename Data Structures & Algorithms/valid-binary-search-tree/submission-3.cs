/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public bool IsValidBST(TreeNode root) {
        return DFS(root, int.MinValue, int.MaxValue);
    }
    private bool DFS(TreeNode node, int minVal, int maxVal)
    {
        bool result = false;
        if(node == null)
        {
            return true;
        }
        if(node.val > minVal && node.val < maxVal)
        {   
            result = DFS(node.left, minVal, node.val) && DFS(node.right, node.val, maxVal);
        }
        return result;
    }
}
