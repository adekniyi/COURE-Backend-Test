int ScoreIncrement(int[] scores)
{
     // Return 0 for null or empty arrays
    if (scores == null || scores.Length == 0) 
        return 0;

    
    int totalScore = 0;
    for(int i = 0; i < scores.Length; i++)
    {
        // Add 1 for even numbers and 3 for odd numbers
        if(scores[i] % 2 ==0)
        {
            totalScore+=1;
        }else{
            totalScore+=3;
        }

        // Add 5 for each occurrence of the number 8

        if(scores[i] == 8)
        {
            totalScore+=5;
        }
    }

    return totalScore;
}


// Test Cases
var scores1 = new int[] { 1, 2, 3, 4, 5 }; // Expected Output: 11
var scores2 = new int[] { 15, 25, 35 };    // Expected Output: 9
var scores3 = new int[] { 8, 8 };          // Expected Output: 12
var scores4 = new int[] { 0 };             // Expected Output: 1

Console.WriteLine(ScoreIncrement(scores1));
Console.WriteLine(ScoreIncrement(scores2));
Console.WriteLine(ScoreIncrement(scores3));
Console.WriteLine(ScoreIncrement(scores4));