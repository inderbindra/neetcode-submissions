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
    public List<List<int>> LevelOrder(TreeNode root) 
    {
        List<List<int>> result = new();

        if(root != null)
        {
            Queue<TreeNode> queue = new();

            queue.Enqueue(root);
            int queueLength = 0;

            List<int> currentList = null;
            TreeNode node = null;
            while(queue.Count > 0)
            {
                currentList = new();
                queueLength = queue.Count;
                for(int i=0; i<queueLength; i++)
                {
                    node = queue.Dequeue();
                    if(node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }
                    if(node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                    currentList.Add(node.val);
                }
                result.Add(currentList);
            }
        }
        return result;
    }
}
