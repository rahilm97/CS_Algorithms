// Assume that there is a Node class with a value and a next pointer

// Reverse the list and return the new head pointer
Node reverseList(Node head)
{
	Node prev = null;
	Node next = null;
	Node current = head;
	
	while (current != null)
	{
		next = current.next;
		current.next = prev;
		// Advance pointers
		prev = current;
		current = next;
	}
	head = prev;
	return head;
}

// Check if there is a cycle in the list
bool checkCycle(Node head)
{
	Node slow = head;
	Node fast = head;
	
	while (fast != null && fast.next != null)
	{
		slow = slow.next;
		fast = fast.next.next;
		if (slow == fast)
		{
			return true;
		}
	}
	return false;
}
