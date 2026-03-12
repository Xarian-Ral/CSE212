public static class Arrays
{
    /// <summary>
    /// This function will produce an array of the needed length starting with the supplied number and followed by its multiples. For 
    /// example, multiples of 7 and 5 will result in: 7, 14, 21, 28, 35.  Assume that length is a positive integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Step 1: Create an array that can hold 'length' number of values.
        double[] result = new double[length];

        // Step 2: Loop through each index of the array from 0 up to length - 1.
        for (int i = 0; i < length; i++)
        {
            // Step 3: For each position in the array, calculate the multiple.
            // Since arrays start at index 0, multiply by (i + 1) to get the correct multiple.
            result[i] = number * (i + 1);
        }

        // Step 4: After filling the array with multiples, return the array.
        return result;
    }

    /// <summary>
    /// Rotate the list to the right by the amount. For example, if the data is 
    /// List<int> 1, 2, 3, 4, 5, 6, 7, 8, 9 and an amount is 3 then the list after the function runs should be 
    /// List<int> 7, 8, 9, 1, 2, 3, 4, 5, 6.  The value of amount will be in the range of 1.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than producing a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Step 1: Determine the index where the list should be split.
        // This is the total count minus the amount we want to rotate.
        int splitIndex = data.Count - amount;

        // Step 2: Create a list containing the last 'amount' elements.
        List<int> endPart = data.GetRange(splitIndex, amount);

        // Step 3: Create a list containing the first part of the original list.
        List<int> startPart = data.GetRange(0, splitIndex);

        // Step 4: Clear the original list so we can rebuild it.
        data.Clear();

        // Step 5: Add the elements that were at the end of the list first.
        data.AddRange(endPart);

        // Step 6: Add the elements from the beginning of the list after them.
        data.AddRange(startPart);
    }
}