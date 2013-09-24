using System;

namespace GeneralDataType
{
	class FormatString
	{

		public static void initString() {
			// Declare without initializing.
			string message1;

			// Initialize to null.
			string message2 = null;

			// Initialize as an empty string.
			// Use the Empty constant instead of the literal "".
			string message3 = System.String.Empty;

			//Initialize with a regular string literal.
			string oldPath = "c:\\Program Files\\Microsoft Visual Studio 8.0";

			// Initialize with a verbatim string literal.
			string newPath = @"c:\Program Files\Microsoft Visual Studio 9.0";

			// Use System.String if you prefer.
			System.String greeting = "Hello World!";

			// In local variables (i.e. within a method body)
			// you can use implicit typing.
			var temp = "I'm still a strongly-typed System.String!";

			// Use a const string to prevent 'message4' from
			// being used to store another string value.
			const string message4 = "You can't get rid of me!";

			// Use the String constructor only when creating
			// a string from a char*, char[], or sbyte*. See
			// System.String documentation for details.
			char[] letters = { 'A', 'B', 'C' };
			string alphabet = new string(letters);


			string s1 = "A string is more ";
			string s2 = "than the sum of its chars.";

			// Concatenate s1 and s2. This actually creates a new
			// string object and stores it in s1, releasing the
			// reference to the original object.
			s1 += s2;

			System.Console.WriteLine(s1);
			// Output: A string is more than the sum of its chars.
		}

		public static void methodOne() {
			// Get user input.
			System.Console.WriteLine("请输入一个数字");
			string input = System.Console.ReadLine();

			// Convert the input string to an int.
			int j;
			System.Int32.TryParse(input, out j);

			// Write a different string each iteration.
			string s;
			for (int i = 0; i < 10; i++)
			{
				// A simple format string with no alignment formatting.
				s = System.String.Format("{0} times {1} = {2}", i, j, (i * j));
				System.Console.WriteLine(s);
			}

			//Keep the console window open in debug mode.
			//System.Console.ReadKey();
		}

		public static void methodTwo() {
			string s3 = "Visual C# Express";
			Console.WriteLine(s3.Substring(7, 2));
			// Output: "C#"

			Console.WriteLine(s3.Replace("C#", "Basic"));
			// Output: "Visual Basic Express"

			Console.WriteLine (s3);

			// Index values are zero-based
			int index = s3.IndexOf("C");
			Console.WriteLine (" index = " + index);
		}

		public static void methodThree() {
			string s5 = "Printing backwards";

			for (int i = 0; i < s5.Length; i++)
			{
				System.Console.Write(s5[s5.Length - i - 1]);
			}
			// Output: "sdrawkcab gnitnirP"
		}

		public static void methodFour() {
			System.Text.StringBuilder sb = new System.Text.StringBuilder();

			// Create a string composed of numbers 0 - 9
			for (int i = 0; i < 10; i++)
			{
				sb.Append(i.ToString());
			}
			System.Console.WriteLine(sb);  // displays 0123456789

			// Copy one character of the string (not possible with a System.String)
			sb[0] = sb[9];

			System.Console.WriteLine(sb);  // displays 9123456789
		}

		public static void methodFive(){
			string question = "hOW DOES mICROSOFT wORD DEAL WITH THE cAPS lOCK KEY?";
			System.Text.StringBuilder sb = new System.Text.StringBuilder(question);

			for (int j = 0; j < sb.Length; j++)
			{
				if (System.Char.IsLower(sb[j]) == true)
					sb[j] = System.Char.ToUpper(sb[j]);
				else if (System.Char.IsUpper(sb[j]) == true)
					sb[j] = System.Char.ToLower(sb[j]);
			}
			// Store the new string.
			string corrected = sb.ToString();
			System.Console.WriteLine(corrected);
			// Output: How does Microsoft Word deal with the Caps Lock key?        
		}

		public static void Main (string[] args) {
			//init string
			initString ();

			//格式字符串
			methodOne ();

			//子字符串
			methodTwo ();

			//访问各个字符
			methodThree ();

			//Stringbuffer
			methodFour ();
			methodFive ();

		}
	}
}

