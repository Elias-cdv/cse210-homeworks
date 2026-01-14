using System.IO.Pipelines;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Step 1: Create a double array with a size equal to the value of 'length'
        // Step 2: Use a loop to iterate through each index of the array
        // Step 3: For each index, calculate the multiple by multiplying 'number' by (index + 1)
        // Step 4: Store the calculated multiple in the array at the current index
        // Step 5: Return the completed array

        double[] multiplesList = new double[length];

        for (int i = 0; i < length; i++)
        {
            multiplesList[i] = number * (i + 1);
        }


        return multiplesList;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Step 1: Calculate the starting index of the elements to rotate by subtracting 'amount' from data.Count
        // Step 2: Extract the elements from the starting index to the end of the list
        // Step 3: Remove the extracted elements from the original list
        // Step 4: Insert the extracted elements at the beginning of the list

        int listElements = data.Count;
        int startIndex = listElements - amount;
        
        List<int> slice = data.GetRange(startIndex,amount);
        data.RemoveRange(startIndex, amount);

        data.InsertRange(0, slice);

    }
}
