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

    Dictionary<int, int> inOrderIndexMap;
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        inOrderIndexMap = new();

        for(int i=0; i<inorder.Length; i++)
        {
            inOrderIndexMap.TryAdd(inorder[i], i);
        }
        return SplitTree(preorder, 0, 0, preorder.Length-1);
    }
    private TreeNode SplitTree(int[] preorder, int rootIndex, int left, int right)
    {
        TreeNode node = new TreeNode(preorder[rootIndex]);
        int mid = inOrderIndexMap[preorder[rootIndex]];

        if(left < mid)
        {
            node.left = SplitTree(preorder, rootIndex + 1, left, mid -1);
        }
        if(mid < right)
        {
            node.right = SplitTree(preorder, rootIndex + 1 + (mid-left), mid+1, right);
        }
        return node;
    }
}