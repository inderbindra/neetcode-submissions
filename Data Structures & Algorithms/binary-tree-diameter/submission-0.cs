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
    int maxDiameter = 0;
    public int DiameterOfBinaryTree(TreeNode root) {
        DFS(root);
        return maxDiameter;
    }
    private int DFS(TreeNode root)
    {
        if(root == null)
        {
            return -1;
        }
        int leftHeight = DFS(root.left);
        int rightHeight = DFS(root.right);
        Console.WriteLine("Left Val = " + root.left?.val + " LeftH = " + leftHeight);
        Console.WriteLine("right Val = " + root.right?.val + " RightH = " + rightHeight);
        int diameter = 2 + leftHeight + rightHeight;
        maxDiameter = Math.Max(maxDiameter, diameter);
        Console.WriteLine("Diameter = " + diameter + " max = " + maxDiameter);
        return (1 + Math.Max(leftHeight, rightHeight));
    }
}

