using System;

namespace Capstone
{  
    class PalindromeTester
    {
        static void Main(String[] args)
        {
        
            int palindromeCount = 0, length;
            String words;
            int left, right;

            Console.WriteLine("enter a word, phrase, or sentence (blank line to stop): ");
            words=Console.ReadLine();

            while(!String.IsNullOrEmpty(words)){
                length=words.Length;
                left= 0;
                right= length-1;

                for(int i = length-1; i>=0;i--){
                    while(!(Char.IsLetter(words[left]))){
                    left++;
                    if(left>(length-1))
                        break;
                    }
                    while(!(Char.IsLetter(words[right]))){
                    right--;
                    if(right<0)
                        break;
                    }
                    if(left>(length-1)||right<0){
                    Console.WriteLine("Invalid input. Please try again.\n");
                    break;
                    }

                    char leftChar = Char.ToLower(words[left]);
                    char rightChar = Char.ToLower(words[right]);
                    if(leftChar != rightChar){
                    Console.WriteLine("Not a palindrome\n");
                    break;
                    }

                    left++;
                    right--;

                    if(i==0||left>(length-1)||right<0){
                    palindromeCount++;
                    Console.WriteLine("palindrome\n");
                    break;
                    }

                }

                Console.WriteLine("enter a word, phrase, or sentence (blank line to stop): ");
                words=Console.ReadLine();
            }

            Console.WriteLine("You found " + palindromeCount + " palindromes.\n");
            Console.WriteLine("Thank you for using PalindromeTester.");

        }
    }
}
