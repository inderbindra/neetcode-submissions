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
    int count=0, val=0;
    public int KthSmallest(TreeNode root, int k) {
        DFS(root, k);
        return val;
    }
    private void DFS(TreeNode node, int k)
    {
        if(node == null)
        {
            return;
        }
        DFS(node.left, k);
        count++;
        if(count == k)
        {
            val = node.val;
            return;
        }
        DFS(node.right, k);
    }
}
