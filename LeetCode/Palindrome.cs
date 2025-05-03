public class Palindrome
{

    public bool IsPalindrome(int x)
    {
        // اعداد منفی و اعدادی که رقم آخرشان 0 است (به جز خود 0)، نمی‌توانند Palindrome باشند
        if (x < 0 || (x % 10 == 0 && x != 0))
            return false;

        int reversed = 0;
        while (x > reversed)
        {
            reversed = reversed * 10 + x % 10;
            x /= 10;
        }

        // برای اعداد با تعداد رقم زوج: x == reversed
        // برای اعداد با تعداد رقم فرد: x == reversed / 10 (چون رقم وسط اهمیتی نداره)
        return x == reversed || x == reversed / 10;

    }
}
