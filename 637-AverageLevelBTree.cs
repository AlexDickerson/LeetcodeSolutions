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
    Stack<TreeNode> nodeStack;
    public IList<double> AverageOfLevels(TreeNode root) {
        Stack<TreeNode> nodeStack = new Stack<TreeNode>();
        List<double> avgs = new();
        nodeStack.Push(root);

        BTLevelAvg(nodeStack, ref avgs);

        return avgs;
    }

    private void BTLevelAvg(Stack<TreeNode> nodeStack, ref List<double> avgs){
        double avg = 0;
        int count = nodeStack.Count;

        Stack<TreeNode> newStack = new();

        foreach(var node in nodeStack){
            var val = node.val;
            avg += val;
            if(node.left != null) newStack.Push(node.left);
            if(node.right != null) newStack.Push(node.right);
        }

        avg = avg / count;
        avgs.Add(avg);
        
        if(newStack.Count >= 1) BTLevelAvg(newStack, ref avgs);
        else return;
    }
}