﻿using System;

class Program
{
        static void Main(string[] args)
        {
		string word = "Holberton";
		string word_first_3 =  word.Substring(1, 3);
        string word_last_2 = word.Substring(7);
        string middle_word = word.Substring(1, 7);
		Console.WriteLine("First 3 letters: " + word_first_3);
		Console.WriteLine("Last 2 letters: " + word_last_2);
		Console.WriteLine("Middle word: " + middle_word);
        }
}