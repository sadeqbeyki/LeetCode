


#region twoSum
using LeetCode;

TwoSum twosum = new TwoSum();

Console.WriteLine("Please enter array numbers separated by spaces (example: 1 2 3 4):");
string numbersInput = Console.ReadLine();

Console.WriteLine("Please enter the target amount:");
string targetInput = Console.ReadLine();

try
{
    // تبدیل رشته ورودی اعداد به آرایه ای از اعداد صحیح
    int[] numbers = numbersInput.Split(' ')
                                 .Select(int.Parse)
                                 .ToArray();

    // تبدیل رشته ورودی هدف به عدد صحیح
    int target = int.Parse(targetInput);

    Console.WriteLine("nums : [" + string.Join(", ", numbers) + "]");
    Console.WriteLine("targ : " + target);

    // فراخوانی متد Zweisum و دریافت نتیجه
    int[] resultIndices = twosum.Zweisum(numbers, target);

    // چاپ نتیجه
    Console.WriteLine($"Indexes of numbers with sum {target}: [{resultIndices[0]}, {resultIndices[1]}]");
}
catch (FormatException)
{
    Console.WriteLine("The input format is invalid. Please enter the numbers and target correctly.");
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

#endregion
