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
    public int MaxDepth(TreeNode root) {
        if(root == null) return 0;
        if(root.left == null && root.right == null) return 1;
        
        return TreeNodeDepth(root);
    }

    private int TreeNodeDepth(TreeNode node){
        if(node.right == null && node.left == null) return 1;

        var leftDepth = 0;
        var rightDepth = 0;

        if(node.left != null) leftDepth = TreeNodeDepth(node.left) + 1;
        if(node.right != null) rightDepth = TreeNodeDepth(node.right) + 1;

        if(leftDepth >= rightDepth) return leftDepth;
        else return rightDepth;
    }
}