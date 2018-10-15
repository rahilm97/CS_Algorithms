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