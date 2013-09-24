using System;

namespace GeneralDataType
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//数组
			int[] numbers; 
			numbers = new int[10];
			// out = 2
			Console.WriteLine (numbers.Length);

			String[,] citys = new String[2, 2];
			// out = 4
			Console.WriteLine (citys.Length);

			char[][] letters = new char[26][];
			for (int i = 0; i < 26; i ++) {

				char[] bigAndSmall = new char[2];
				bigAndSmall [0] = 'A';
				bigAndSmall [1] = 'a';

				letters [i] = new char[2];
			}

			// out = 26
			Console.WriteLine (letters.Length);

			char[] singleLetter = (char[])letters.GetValue (0);
			// out = 2
			Console.WriteLine (singleLetter.Length);


			//as 
			object[] arr = new object[2];
			arr [0] = 123;
			arr [1] = "test";
			foreach (object temp in arr) {
				try {
					string s = (string)temp;
					Console.WriteLine (s);
				} catch (Exception e) {
					Console.WriteLine (e.StackTrace);
				}
			}

			for (int i = 0; i < arr.Length; i++) {
				string s = arr [i] as string;
				if (s != null)
					Console.WriteLine (i + ":" + s);
			}

			Object myObject = new Object (); 
			Boolean b1 = (myObject is Object);      
			Boolean b2 = (myObject is MainClass);

			// out = b1 = True, b2 = False
			Console.WriteLine ("b1 = " + b1 + ", b2 = " + b2);

			//string multiWords = "I am a developer.";
			//Console.WriteLine ("words num == " + multiWords.Split(" ").Length);
		}
	}
}
