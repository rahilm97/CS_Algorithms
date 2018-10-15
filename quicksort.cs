void quickSort (int[] array, int left, int right)
{
	int mid = left + (right - left) / 2;
	int pivot = arr[mid];
	int i = left, j = right;
	while (i <= j)
	{
		while (arr[i] < pivot)
		{
			i++;
		}
		while (arr[j] >= pivot)
		{
			j--;
		}
		if (i <= j)
		{
			int temp = arr[i];
			arr[i] = arr[j];
			arr[j] = temp;
		}
	}
	
	if (low < j)
	{
		quickSort(arr, low, j);
	}
	if (high > i)
	{
		quickSort(arr, i, high);
	}
}
