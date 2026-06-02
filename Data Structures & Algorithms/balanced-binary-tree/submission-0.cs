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
     public bool IsBalanced(TreeNode root) {
        return DFS(root).isBalanced;
    }
    private (int height, bool isBalanced) DFS(TreeNode root)
    {
        if(root == null)
        {
            return (-1, true);
        }
        (int height, bool isBalanced)left = DFS(root.left);
        (int height, bool isBalanced)right = DFS(root.right);
        (int height, bool isBalanced) node = (0, false);
        node.isBalanced = (left.isBalanced && right.isBalanced) && (Math.Abs(left.height - right.height) <=1);
        node.height = 1 + Math.Max(left.height, right.height);
        return node;
    }
}
