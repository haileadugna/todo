namespace Task3
{
    class PalindromeCheck{
        public void Check(){
            Console.WriteLine("Enter a word: ");
            string word = Console.ReadLine()?.Trim() ?? " ";
            string reversed = "";
            for (int i = word.Length - 1; i >= 0; i--){
                reversed += word[i];
            }
            if (word == reversed){
                Console.WriteLine("The word is a palindrome");
            }
            else{
                Console.WriteLine("The word is not a palindrome");
            }
        }
    }
}