using LeetCode;

#region LongestSubstring   
LongestSubstring longestSubString = new LongestSubstring();

// مثال 1
string s1 = "abcabcbb";
int result1 = longestSubString.LengthOfLongestSubstring(s1);
Console.WriteLine($"longest String without repeat for \"{s1}\": {result1}");

// مثال 2
string s2 = "bbbbb";
int result2 = longestSubString.LengthOfLongestSubstring(s2);
Console.WriteLine($"طولانی‌ترین زیررشته بدون تکرار برای \"{s2}\": {result2}");

// مثال 3
string s3 = "pwwkew";
int result3 = longestSubString.LengthOfLongestSubstring(s3);
Console.WriteLine($"طولانی‌ترین زیررشته بدون تکرار برای \"{s3}\": {result3}");

// مثال‌های بیشتر (اختیاری)
string s4 = "";
int result4 = longestSubString.LengthOfLongestSubstring(s4);
Console.WriteLine($"طولانی‌ترین زیررشته بدون تکرار برای \"{s4}\": {result4}");

string s5 = "au";
int result5 = longestSubString.LengthOfLongestSubstring(s5);
Console.WriteLine($"طولانی‌ترین زیررشته بدون تکرار برای \"{s5}\": {result5}");

Console.ReadKey(); // برای نگه داشتن پنجره کنسول باز
#endregion

#region PalindromeChecker
Palindrome Palindrome = new();
Console.WriteLine("please imput a number:");
int number;

// بررسی معتبر بودن ورودی
while (!int.TryParse(Console.ReadLine(), out number))
{
    Console.WriteLine("input number is not valid, please input a valid number.");
}

bool result = Palindrome.IsPalindrome(number);

if (result)
{
    Console.WriteLine($"{number} is a Palindrome number.");
}
else
{
    Console.WriteLine($"{number} is'nt a Palindrome number.");
}

Console.WriteLine("Push enter to Exit");
Console.ReadLine();
#endregion

#region AddTwoNumbers


// create link list

ListNode l1 = new ListNode(2);
l1.next = new ListNode(4);
l1.next.next = new ListNode(3);

ListNode l2 = new ListNode(5);
l2.next = new ListNode(6);
l2.next.next = new ListNode(4);

//  create Solution
TwoNumbers twoNum = new TwoNumbers();

//  call AddTwoNumbers
ListNode listNode = twoNum.AddTwoNumbers(l1, l2);

// result
ListNode currentResult = listNode;
Console.WriteLine("Result:");
while (currentResult != null)
{
    Console.Write(currentResult.val + " ");
    currentResult = currentResult.next;
}
Console.WriteLine();

// ex2
ListNode l3 = new ListNode(0);
ListNode l4 = new ListNode(0);
ListNode listNode2 = twoNum.AddTwoNumbers(l3, l4);
Console.WriteLine("Result 2:");
ListNode currentResult2 = listNode2;
while (currentResult2 != null)
{
    Console.Write(currentResult2.val + " ");
    currentResult2 = currentResult2.next;
}
Console.WriteLine();

//  ex3
ListNode l5 = new(9);
l5.next = new ListNode(9);
l5.next.next = new ListNode(9);
l5.next.next.next = new ListNode(9);
l5.next.next.next.next = new ListNode(9);
l5.next.next.next.next.next = new ListNode(9);
l5.next.next.next.next.next.next = new ListNode(9);

ListNode l6 = new ListNode(9);
l6.next = new ListNode(9);
l6.next.next = new ListNode(9);
l6.next.next.next = new ListNode(9);

ListNode listNode3 = twoNum.AddTwoNumbers(l5, l6);
Console.WriteLine("Result 3:");
ListNode currentResult3 = listNode3;
while (currentResult3 != null)
{
    Console.Write(currentResult3.val + " ");
    currentResult3 = currentResult3.next;
}
Console.WriteLine();

Console.ReadKey();



#endregion

#region twoSum

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
