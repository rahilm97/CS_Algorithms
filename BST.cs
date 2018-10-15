// This file contains binary search tree algorithms.
// Assume there is a binary search tree class with a value and left and right pointer.

void inorderTraversal(TreeNode root)
{
	if (root == null)
	{
		return null;
	}
	inorderTraversal(root.left);
	Console.WriteLine(root.val);
	inorderTraversal(root.right);
}


TreeNode invertTree(TreeNode root)
{
	if (root == null)
	{
		return null;
	}
	
	TreeNode temp = root.left;
	root.left = invertTree(root.right);
	root.right = invertTree(temp);
	return root;
}