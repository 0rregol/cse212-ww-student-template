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
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        //create a data container
            double[] resultado = new double[length];
            // loop through the length of the array and fill it with the multiples of the number  
            for (int i = 0; i < length; i++) {
                // the first element of the array should be the number itself, so we multiply the number by (i + 1) to get the multiples
                resultado[i] = number * (i + 1);
            }
           // return the array
        return resultado; // replace this return statement with your own
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
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        // To rotate the list to the right by the specified amount, we can follow these steps:
        // 1. Determine the length of the list.
        int length = data.Count;
        // 2. Create a new list to hold the rotated elements.
        var finalList = data.GetRange(length - amount, amount);
        // 3. Add the remaining elements from the original list to the new list.
        finalList.AddRange(data.GetRange(0, length - amount));  
        // 4. Copy the elements from the new list back to the original list.
        for (int i = 0; i < length; i++) {
            // 5. Update the original list with the rotated values.
            data[i] = finalList[i];
        }
    
        
    }
}
