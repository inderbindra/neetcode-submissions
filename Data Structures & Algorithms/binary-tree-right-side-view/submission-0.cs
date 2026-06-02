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
    public List<int> RightSideView(TreeNode root) {
        List<int> result = new();

        if(root != null)
        {
            Queue<TreeNode> queue = new();
            queue.Enqueue(root);
            int queueLen = 0;

            TreeNode node = null;
            while(queue.Count > 0)
            {
                queueLen = queue.Count;
                for(int i=0; i<queueLen; i++)
                {
                    node = queue.Dequeue();
                    if(node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                    if(node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }
                    if(i == 0)
                    {
                        result.Add(node.val);
                    }
                }
            }
        }

        return result;
    }
}
