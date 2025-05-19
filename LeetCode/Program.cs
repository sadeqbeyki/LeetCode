using LeetCode;
using System;

#region Longest Common prefix
var solution = new LongestCommon();

Console.WriteLine(solution.LongestCommonPrefix(new string[] { "flower", "flotter", "flighter" }));

Console.WriteLine(solution.LongestCommonPrefix(new string[] { "dog", "racecar", "car" }));

Console.WriteLine(solution.LongestCommonSuffix(new string[] { "flower", "flotter", "flighter" }));


#endregion

#region ArrayHelper     
Console.Write("Please enter the elements of the first array with spaces: ");
string input1 = Console.ReadLine();
int[] array1 = input1.Split(' ').Select(int.Parse).ToArray();

// گرفتن ورودی آرایه دوم از کاربر
Console.Write("Please enter the elements of the first array with spaces: ");
string input2 = Console.ReadLine();
int[] array2 = input2.Split(' ').Select(int.Parse).ToArray();

// ادغام دو آرایه با استفاده از متد arrayhelper
int[] mergedarray = ArrayHelper.MergeArrays(array1, array2);
Console.WriteLine($"Merged array: {ArrayHelper.ArrayToString(mergedarray)}");

// مرتب کردن آرایه ادغام شده با استفاده از متد arrayhelper
ArrayHelper.SortArray(mergedarray);
Console.WriteLine($"Sorted array: {ArrayHelper.ArrayToString(mergedarray)}");

// پیدا کردن و نمایش عدد میانی
double med = ArrayHelper.FindMedian(mergedarray);
Console.WriteLine($"Median Number: {med}");

#endregion

#region  Median of Two Sorted Arrays


MedianOfTwoSortedArrays median = new();

// Example 1
int[] nums1_1 = { 1, 3 };
int[] nums2_1 = { 2 };
Console.WriteLine($"Median of [{string.Join(",", nums1_1)}] and [{string.Join(",", nums2_1)}] is: {median.FindMedianSortedArrays(nums1_1, nums2_1)}");

// Example 2
int[] nums1_2 = { 1, 2 };
int[] nums2_2 = { 3, 4 };
Console.WriteLine($"Median of [{string.Join(",", nums1_2)}] and [{string.Join(",", nums2_2)}] is: {median.FindMedianSortedArrays(nums1_2, nums2_2)}");

// Additional test cases
int[] nums1_3 = { };
int[] nums2_3 = { 1 };
Console.WriteLine($"Median of [{string.Join(",", nums1_3)}] and [{string.Join(",", nums2_3)}] is: {median.FindMedianSortedArrays(nums1_3, nums2_3)}");

int[] nums1_4 = { 2 };
int[] nums2_4 = { };
Console.WriteLine($"Median of [{string.Join(",", nums1_4)}] and [{string.Join(",", nums2_4)}] is: {median.FindMedianSortedArrays(nums1_4, nums2_4)}");

int[] nums1_5 = { 1, 5 };
int[] nums2_5 = { 2, 3, 4 };
Console.WriteLine($"Median of [{string.Join(",", nums1_5)}] and [{string.Join(",", nums2_5)}] is: {median.FindMedianSortedArrays(nums1_5, nums2_5)}");
#endregion

#region LongestSubstring   
LongestSubstring longestSubString = new LongestSubstring();

// مثال 1
string s1 = "abcabcbb";
int result1 = longestSubString.LengthOfLongestSubstring(s1);
Console.WriteLine($"longest String without repeat for \"{s1}\": {result1}");

// مثال 2
string s2 = "bbbbb";
int result2 = longestSubString.LengthOfLongestSubstring(s2);
Console.WriteLine($"longest String without repeat for \"{s2}\": {result2}");

// مثال 3
string s3 = "pwwkew";
int result3 = longestSubString.LengthOfLongestSubstring(s3);
Console.WriteLine($"longest String without repeat for \"{s3}\": {result3}");

// مثال‌های بیشتر (اختیاری)
string s4 = "";
int result4 = longestSubString.LengthOfLongestSubstring(s4);
Console.WriteLine($"longest String without repeat for \"{s4}\": {result4}");

string s5 = "au";
int result5 = longestSubString.LengthOfLongestSubstring(s5);
Console.WriteLine($"longest String without repeat for \"{s5}\": {result5}");

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
