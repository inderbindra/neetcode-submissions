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
    int goodNodes = 0;
    public int GoodNodes(TreeNode root) {
        DFS(root, int.MinValue);
        return goodNodes;
    }
    private void DFS(TreeNode node, int prev)
    {
        if(node == null)
        {
            return;
        }
        if(node.val >= prev)
        {
            prev = node.val;
            goodNodes++;
        }
        DFS(node.left, prev);
        DFS(node.right, prev);
    }
}
