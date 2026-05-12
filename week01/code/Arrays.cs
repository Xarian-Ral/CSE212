using System;
using System.Collections.Generic;

public static class Arrays
{
    /// <summary>
    /// This function creates an array of size length starting with numbers followed by multiples.
    /// </summary>
    public static double[] MultiplesOf(double number, int length)
    {
        // 1. Create an array of size length
        // 2. Loop from index 0 to length - 1
        // 3. For each index i, calculate (i + 1) * number
        // 4. Store that value in the array
        // 5. Return the array

        double[] result = new double[length];

        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

        return result;
    }

    /// <summary>
    /// Rotate the data to the right by the amount given.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // 1. Determine the split index (data.Count - amount)
        // 2. Get the first part (from index 0 to splitIndex)
        // 3. Get the second part (from splitIndex to end)
        // 4. Clear the original list
        // 5. Add the second part first, then add the first part

        int splitIndex = data.Count - amount;

        List<int> firstPart = data.GetRange(0, splitIndex);
        List<int> secondPart = data.GetRange(splitIndex, amount);

        data.Clear();

        data.AddRange(secondPart);
        data.AddRange(firstPart);
    }
}