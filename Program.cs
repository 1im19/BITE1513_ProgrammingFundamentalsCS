using System;
using System.Collections.Specialized;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.IsolatedStorage;
using System.Net;

namespace ProgrammingFundamentalsCS
{
    class Lab1
    {
		//static means "associated with a type instead of any one instance of the type".
		static void Question1_1()
        {
            Console.WriteLine("Hello.\nI am a second year student from FKE\n"); //Writeline writes a string, then makes a new line
            Console.Write("My name is Aniza Othman"); //Write writes a string, but then writes a new string in the same line
        }

		static void Question1_2()
		{
			Console.WriteLine("*********************************");
			Console.WriteLine("*****          UTEM         *****");
			Console.WriteLine("*********************************");
		}

		static void Question1_3()
		{
			Console.WriteLine("10");
			Console.WriteLine(" 9");
			Console.WriteLine(" 8");
			Console.WriteLine(" 7           x");
			Console.WriteLine(" 6 x");
			Console.WriteLine(" 5                    x");
			Console.WriteLine(" 4   x");
			Console.WriteLine(" 3               x");
			Console.WriteLine(" 2     x");
			Console.WriteLine(" 1 x");
			Console.WriteLine(" 0 1 2 3 4 5 6 7 8 9 10");
		}
		
		//public is for members of other class to access this member
		public static void Question1()
		{
			Question1_1();
			Console.WriteLine();
			Question1_2();
			Console.WriteLine();
			Question1_3();
		}

		public static void Question2()
		{
			try
			{
				string program1, university1;
				int year1;

				Console.Write("Enter your program: \t");
				program1 = Console.ReadLine();
				Console.Write("\nEnter your university: \t");
				university1 = Console.ReadLine();
				Console.Write("\nEnter your year of study: \t");
				year1 = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("\n\nWelcome");
			}
			catch (IOException e3)
			{
				Console.WriteLine("Error in Lab1.Question2: ", e3);
			}
		}
	}

	class Lab2
	{
		public static void Question1()
		{
			try
			{
				int S1;
				double A1;

				Console.WriteLine("A = sqrt(S^5 + 2^4)");
				Console.Write("Please key in the value of S: \t");
				S1 = Convert.ToInt32(Console.ReadLine());
				A1 = Math.Sqrt(Math.Pow(S1, 5) + Math.Pow(2, 4)); //Calling Math Class for Square Root and Power Function
				Console.WriteLine("A = \t" + A1);
			}
			catch(IOException e5)
			{
				Console.WriteLine("Error in Lab2.Question1: ", e5);
			}
		}

		public static void Question2()
		{
			try
			{
				int C1;
				double F1;

				Console.WriteLine("F = (C * 9/5) + 32");
				Console.Write("Please key in the value of C: \t");
				C1 = Convert.ToInt32(Console.ReadLine());
				F1 = ((double)C1 * 9 / 5) + 32;
				Console.WriteLine("F = \t" + F1);
			}
			catch (IOException e6)
			{
				Console.WriteLine("Error in Lab2.Question2: ", e6);
			}
		}

		public static void Question3()
		{
			try
			{
				int r1;
				double Volume1;

				Console.WriteLine("Volume = 4 / 3 * pi * r ^ 3");
				Console.Write("Please key in the value of r: \t");
				r1 = Convert.ToInt32(Console.ReadLine());
				Volume1 = 4 / 3 * Math.PI * Math.Pow(r1, 3);
				Console.WriteLine("Volume = \t" + Volume1);
			}
			catch (IOException e7)
			{
				Console.WriteLine("Error in Lab2.Question3: ", e7);
			}
		}

		public static void Question4()
		{
			try
			{
				int b1, c1, d1, e1;
				double ANSWER1;

				Console.WriteLine("ANSWER = (b+c)^1/2 * (d-e)");
				Console.Write("Please key in the value of b: \t");
				b1 = Convert.ToInt32(Console.ReadLine());
				Console.Write("Please key in the value of c: \t");
				c1 = Convert.ToInt32(Console.ReadLine());
				Console.Write("Please key in the value of d: \t");
				d1 = Convert.ToInt32(Console.ReadLine());
				Console.Write("Please key in the value of e: \t");
				e1 = Convert.ToInt32(Console.ReadLine());
				ANSWER1 = (Math.Sqrt(b1 + c1)) * (d1 - e1);
				Console.WriteLine("ANSWER = \t" + ANSWER1);
			}
			catch (IOException e8)
			{
				Console.WriteLine("Error in Lab2.Question4: ", e8);
			}
		}
	}

	class Lab4
	{
		public static void Question1()
		{
			for(int i1 = 0; i1 < 200; i1++)
			{
				Console.WriteLine("Muhammad Aiman Bin Mohd Nor Azman");
			}
		}

		public static void Question2()
		{
			int i2 = 3;

			while(i2 <= 222)
			{
				Console.Write(i2 + " ");
				i2 += 3;
			}

			Console.WriteLine();
		}

		public static void Question3()
		{
			for(int i3 = 50; i3 > 0; i3--)
			{
				Console.Write(i3 + " ");
			}

			Console.WriteLine();
		}

		public static void Question4()
		{
			int i4 = 300;

			while(i4 <= 500)
			{
				if(i4 % 3 == 0 && i4 % 7 == 0)
				{
					Console.Write(i4 + " ");
				}
				i4++;
			}

			Console.WriteLine();
		}

		public static void Question5()
		{
			try
			{
				const int size1 = 10;
				int[] input1 = new int[size1]; //array declaration
				int sum1 = 0;
				float average1;

				Console.WriteLine("Please enter 10 number");

				for (int i5 = 0; i5 < size1; i5++)
				{
					Console.Write("Number " + (i5 + 1) + ": \t");
					input1[i5] = Convert.ToInt32(Console.ReadLine());
					sum1 += input1[i5];
				}

				average1 = (float)sum1 / size1;
				Console.WriteLine("Sum: \t" + sum1);
				Console.WriteLine("Average: \t" + average1);
			}
			catch(IOException e10)
			{
				Console.WriteLine("Error in Lab4.Question5: ", e10);
			}
			
		}

		public static void Question6()
		{
			try
			{
				int mark1;
				do
				{
					Console.Write("Please insert the mark, or any number smaller than 0 or greater than 100 to stop: \t");
					mark1 = Convert.ToInt32(Console.ReadLine());

					if (mark1 >= 0 && mark1 < 40)
					{
						Console.WriteLine("Grade C");
					}
					else if (mark1 >= 40 && mark1 < 70)
					{
						Console.WriteLine("Grade B");
					}
					else if (mark1 >= 0 && mark1 <= 100)
					{
						Console.WriteLine("Grade A");
					}
				} while (mark1 >= 0 && mark1 <= 100);
			}
			catch(IOException e11)
			{
				Console.WriteLine("Error in Lab4.Question6: ", e11);
			}
		}

		//ref is a pass by reference
		static void Question7v1(ref int useranswer1, int num1, int num2, char operation1)
		{
			try
			{
				Console.Write("What is " + num1 + " " + operation1 + " " + num2 + "? : \t");
				useranswer1 = Convert.ToInt32(Console.ReadLine());
			}
			catch (IOException e12)
			{
				Console.WriteLine("Error in Function7v1: ", e12);
			}
		}

		static void Question7v2(ref char choice1, int useranswer1, int actualanswer1, int attempt1, int maxattempt1, int num1, int num2, char operation1)
		{
			try
			{
				while (useranswer1 != actualanswer1 && attempt1 < maxattempt1)
				{
					attempt1++;
					Console.WriteLine("Wrong Answer, Try again!\n");
					Question7v1(ref useranswer1, num1, num2, operation1);
					if (attempt1 >= maxattempt1)
					{
						Console.WriteLine();
						Console.WriteLine("Oopps!\n\n");
					}
				}

				if (useranswer1 == actualanswer1)
				{
					Console.WriteLine();
					Console.WriteLine("Right Answer, Congratulation\n\n");
				}

				Console.Write("Do you want to try again? (Y/N) : \t");
				choice1 = Convert.ToChar(Console.ReadLine());
				if (choice1 == 'Y' || choice1 == 'y')
				{
					attempt1 = 0;
					Console.WriteLine("\n");
				}
			}
			catch (IOException e13)
			{
				Console.WriteLine("Error in Function7v2: ", e13);
			}
		}

		static void Question7v3(ref int useranswer1, ref char choice1, int num1, int num2, char operation1, int actualanswer1, int attempt1, int maxattempt1)
		{
			Question7v1(ref useranswer1, num1, num2, operation1);
			Question7v2(ref choice1, useranswer1, actualanswer1, attempt1, maxattempt1, num1, num2, operation1);
		}

		public static void Question7()
		{
			int max1 = 50;
			int num1, num2;
			int useranswer1 = 0, actualanswer1;
			int attempt1 = 1, maxattempt1 = 3;
			int operationtype1;
			char choice1 = 'N';
			char operation1;

			do
			{
				Random random = new Random(); // generates random numbers. C# can generate different random number when run at a separate time
				num1 = random.Next(0, max1 + 1); //ranges of random numbers
				num2 = random.Next(0, max1 + 1);
				operationtype1 = random.Next(0, 3 + 1);

				if (operationtype1 == 1)
				{
					operation1 = '+';
					actualanswer1 = num1 + num2;
					Question7v3(ref useranswer1, ref choice1, num1, num2, operation1, actualanswer1, attempt1, maxattempt1);
				}
				else if (operationtype1 == 2)
				{
					operation1 = '-';
					actualanswer1 = num1 - num2;
					Question7v3(ref useranswer1, ref choice1, num1, num2, operation1, actualanswer1, attempt1, maxattempt1);
				}
				else if (operationtype1 == 3)
				{
					operation1 = 'x';
					actualanswer1 = num1 * num2;
					Question7v3(ref useranswer1, ref choice1, num1, num2, operation1, actualanswer1, attempt1, maxattempt1);
				}
			} while (choice1 == 'Y' || choice1 == 'y');
		}
	}

	class Lab5
	{
		static void Question1a()
		{
			Console.WriteLine("Without Functions:");
			Console.WriteLine("()()\n(^_^)\n(____)o");
			Console.WriteLine();
			Console.WriteLine(" ___\n('v')\n( )\nv v");
			Console.WriteLine();
			Console.WriteLine("  ()\n (  )\n(    )\n  ||");
			Console.WriteLine();
		}

		static void Question1bv1()
		{
			Console.WriteLine("1st Function: ");
			Console.WriteLine("()()\n(^_^)\n(____)o");
			Console.WriteLine();
		}

		static void Question1bv2()
		{
			Console.WriteLine("2nd Function:");
			Console.WriteLine(" ___\n('v')\n( )\nv v");
			Console.WriteLine();
		}

		static void Question1bv3()
		{
			Console.WriteLine("3rd Function:");
			Console.WriteLine("  ()\n (  )\n(    )\n  ||");
			Console.WriteLine();
		}

		static void Question1b()
		{
			Console.WriteLine("With Functions: \n");
			Question1bv1();
			Console.WriteLine();
			Question1bv2();
			Console.WriteLine();
			Question1bv3();
		}

		public static void Question1()
		{
			Question1a();
			Console.WriteLine();
			Question1b();
		}

		static void Question2a()
		{
			try
			{
				double A2;
				double A3, A4, A5;

				Console.WriteLine("Without Function: \n");
				Console.Write("Please insert the value of A: \t");
				A2 = Convert.ToDouble(Console.ReadLine());
				A3 = Math.Pow(A2, 2);
				A4 = Math.Pow(A2, 3);
				A5 = Math.Pow(A2, 4);
				Console.WriteLine("A^2: \t" + A3);
				Console.WriteLine("A^3: \t" + A4);
				Console.WriteLine("A^4: \t" + A5);
			}
			catch(IOException e15)
			{
				Console.WriteLine("Error in Lab5.Question2a: ", e15);
			}
		}


		static void Question2bv1_1(double A2)
		{
			double A3, A4, A5;

			A3 = Math.Pow(A2, 2);
			A4 = Math.Pow(A2, 3);
			A5 = Math.Pow(A2, 4);
			Console.WriteLine("A^2: \t" + A3);
			Console.WriteLine("A^3: \t" + A4);
			Console.WriteLine("A^4: \t" + A5);
		}

		static void Question2bv1()
		{
			try
			{
				double A2;

				Console.Write("Please insert the value of A: \t");
				A2 = Convert.ToDouble(Console.ReadLine());
				Question2bv1_1(A2);
			}
			catch(IOException e16)
			{
				Console.WriteLine("Error in Lab5.Question2bv1: ", e16);
			}
		}

		static double Question2bv2_1()
		{
			try
			{
				double A2;

				Console.Write("Please insert the value of A: \t");
				A2 = Convert.ToDouble(Console.ReadLine());
				return A2;
			}
			catch(IOException e17)
			{
				Console.WriteLine("Error in Lab5.Question2bv2_1: ", e17);
				return 0;
			}
		}

		static double Question2bv2_2(double A2)
		{
			double A3;

			A3 = Math.Pow(A2, 2);
			return A3;
		}

		static double Question2bv2_3(double A2)
		{
			double A4;

			A4 = Math.Pow(A2, 3);
			return A4;
		}

		static double Question2bv2_4(double A2)
		{
			double A5;

			A5 = Math.Pow(A2, 4);
			return A5;
		}

		static void Question2bv2()
		{
			double A2;
			double A3, A4, A5;

			A2 = Question2bv2_1();
			A3 = Question2bv2_2(A2);
			A4 = Question2bv2_3(A2);
			A5 = Question2bv2_4(A2);
			Console.WriteLine("A^2: \t" + A3);
			Console.WriteLine("A^3: \t" + A4);
			Console.WriteLine("A^4: \t" + A5);
		}


		static void Question2bv3_1(ref double A2)
		{
			try
			{
				Console.Write("Please insert the value of A: \t");
				A2 = Convert.ToDouble(Console.ReadLine());
			}
			catch(IOException e18)
			{
				Console.WriteLine("Error in Lab5.Question2bv3_1: ", e18);
			}
		}

		static void Question2bv3_2(ref double A3, ref double A4, ref double A5, double A2)
		{
			A3 = Math.Pow(A2, 2);
			A4 = Math.Pow(A2, 3);
			A5 = Math.Pow(A2, 4);
			Console.WriteLine("A^2: \t" + A3);
			Console.WriteLine("A^3: \t" + A4);
			Console.WriteLine("A^4: \t" + A5);
		}

		static void Question2bv3()
		{
			double A2 = 0;
			double A3 = 0, A4 = 0, A5 = 0;

			Question2bv3_1(ref A2);
			Question2bv3_2(ref A3, ref A4, ref A5, A2);
		}

		static void Question2b()
		{
			try
			{
				int questionchoice4_1_1;
				do
				{
					Console.WriteLine("1 - receive input A via parameter, calculate and display");
					Console.WriteLine("2 - receive input A via parameter, calculate and return result");
					Console.WriteLine("3 - receive input A  via parameter, calculate and updates results via reference parameter");
					Console.Write("\nPlease choose the function: \t");
				    questionchoice4_1_1 = Convert.ToInt32(Console.ReadLine());
					if (questionchoice4_1_1 == 1)
					{
						Console.WriteLine();
						Question2bv1();
						Console.WriteLine();
					}
					else if (questionchoice4_1_1 == 2)
					{
						Console.WriteLine();
						Question2bv2();
						Console.WriteLine();
					}
					else if (questionchoice4_1_1 == 3)
					{
						Console.WriteLine();
						Question2bv3();
						Console.WriteLine(); 
					}
				} while (questionchoice4_1_1 >= 1 && questionchoice4_1_1 <= 3);
			}
			catch(IOException e19)
			{
				Console.WriteLine("Error in Lab5.Question2b : ", e19);
			}
		}

		public static void Question2()
		{
			try
			{
				char questionchoice4_1;

				do
				{
					Console.Write("Please choose 'a' for 'without function', 'b' for 'with function' or any other input to cancel: \t");
					questionchoice4_1 = Convert.ToChar(Console.ReadLine());
					if (questionchoice4_1 == 'a')
					{
						Console.WriteLine();
						Question2a();
						Console.WriteLine();
					}
					else if (questionchoice4_1 == 'b')
					{
						Console.WriteLine();
						Question2b();
						Console.WriteLine();
					}
				} while (questionchoice4_1 == 'a' || questionchoice4_1 == 'b');
			}
			catch(IOException e20)
			{
				Console.WriteLine("Error in Lab5.Question2: ", e20);
			}
		}

		static void Question3a()
		{
			try
			{
				int win1, draw1, loss1;
				int points1;

				for (int i6 = 0; i6 < 10; i6++)
				{
					Console.WriteLine("Enter how many games that team " + (i6 + 1) + " has:");
					Console.Write("won: \t");
					win1 = Convert.ToInt32(Console.ReadLine());
					Console.Write("draw: \t");
					draw1 = Convert.ToInt32(Console.ReadLine());
					Console.Write("lost: \t");
					loss1 = Convert.ToInt32(Console.ReadLine());
					while (win1 + draw1 + loss1 != 30)
					{
						Console.WriteLine("\nInvalid input. The total number of games is 30.\n\n");
						Console.WriteLine("Enter how many games that team " + (i6 + 1) + " has:");
						Console.Write("won: \t");
						win1 = Convert.ToInt32(Console.ReadLine());
						Console.Write("draw: \t");
						draw1 = Convert.ToInt32(Console.ReadLine());
						Console.Write("lost: \t");
						loss1 = Convert.ToInt32(Console.ReadLine());
					}
					points1 = win1 * 3 + draw1;
					Console.WriteLine("Team " + (i6 + 1) + " gets " + points1 + " points\n");
				}
			}
			catch(IOException e21)
			{
				Console.WriteLine("Error in lab5.Question3a: ", e21);
			}
		}

		static void Question3bv1_1(int win1, int draw1, int i6)
		{
			int points1;
			points1 = win1 * 3 + draw1;
			Console.WriteLine("Team " + (i6 + 1) + " gets " + points1 + " points\n");
		}

		static void Question3bv1()
		{
			try
			{
				int win1, draw1, loss1;
				int points1;

				for (int i6 = 0; i6 < 10; i6++)
				{
					Console.WriteLine("Enter how many games that team " + (i6 + 1) + " has:");
					Console.Write("won: \t");
					win1 = Convert.ToInt32(Console.ReadLine());
					Console.Write("draw: \t");
					draw1 = Convert.ToInt32(Console.ReadLine());
					Console.Write("lost: \t");
					loss1 = Convert.ToInt32(Console.ReadLine());
					while (win1 + draw1 + loss1 != 30)
					{
						Console.WriteLine("\nInvalid input. The total number of games is 30.\n\n");
						Console.WriteLine("Enter how many games that team " + (i6 + 1) + " has:");
						Console.Write("won: \t");
						win1 = Convert.ToInt32(Console.ReadLine());
						Console.Write("draw: \t");
						draw1 = Convert.ToInt32(Console.ReadLine());
						Console.Write("lost: \t");
						loss1 = Convert.ToInt32(Console.ReadLine());
					}
					Question3bv1_1(win1, draw1, i6);
				}
			}
			catch (IOException e22)
			{
				Console.WriteLine("Error in lab5.Question3bv1: ", e22);
			}
		}

		static int Question3bv2_1()
		{
			try
			{
				int win1;

				Console.Write("won: \t");
				win1 = Convert.ToInt32(Console.ReadLine());

				return win1;
			}
			catch(IOException e23)
			{
				Console.WriteLine("Error in lab5.Question3bv2_1: ", e23);
				return 0;
			}	
		}

		static int Question3bv2_2()
		{
			try
			{
				int draw1;

				Console.Write("draw: \t");
				draw1 = Convert.ToInt32(Console.ReadLine());

				return draw1;
			}
			catch (IOException e24)
			{
				Console.WriteLine("Error in lab5.Question3bv2_2: ", e24);
				return 0;
			}
		}

		static int Question3bv2_3()
		{
			try
			{
				int loss1;

				Console.Write("lost: \t");
				loss1 = Convert.ToInt32(Console.ReadLine());

				return loss1;
			}
			catch (IOException e25)
			{
				Console.WriteLine("Error in lab5.Question3bv2_3: ", e25);
				return 0;
			}
		}

		static int Question3bv2_4(int win1, int draw1)
		{
			int points1;

			points1 = win1 * 3 + draw1;

			return points1;
		}

		static void Question3bv2()
		{
			int win1, draw1, loss1;
			int points1;

			for (int i6 = 0; i6 < 10; i6++)
			{
				Console.WriteLine("Enter how many games that team " + (i6 + 1) + " has: ");
				win1 = Question3bv2_1();
				draw1 = Question3bv2_2();
				loss1 = Question3bv2_3();
				while (win1 + draw1 + loss1 != 30)
				{
					Console.WriteLine("\nInvalid input. The total number of games is 30.\n\n");
					Console.WriteLine("Enter how many games that team " + (i6 + 1) + " has: ");
					win1 = Question3bv2_1();
					draw1 = Question3bv2_2();
					loss1 = Question3bv2_3();

				}
				points1 = Question3bv2_4(win1, draw1);
				Console.WriteLine("Team " + (i6 + 1) + " gets " + points1 + " points\n");
			}
		}

		static void Question3bv3_1(ref int win1)
		{
			try
			{
				Console.Write("won: \t");
				win1 = Convert.ToInt32(Console.ReadLine());
			}
			catch (IOException e25)
			{
				Console.WriteLine("Error in lab5.Question3bv3_1: ", e25);
			}
		}

		static void Question3bv3_2(ref int draw1)
		{
			try
			{
				Console.Write("draw1: \t");
				draw1 = Convert.ToInt32(Console.ReadLine());
			}
			catch (IOException e27)
			{
				Console.WriteLine("Error in lab5.Question3bv3_2: ", e27);
			}
		}

		static void Question3bv3_3(ref int loss1)
		{
			try
			{
				Console.Write("lost: \t");
				loss1 = Convert.ToInt32(Console.ReadLine());
			}
			catch (IOException e28)
			{
				Console.WriteLine("Error in lab5.Question3bv3_3: ", e28);
			}
		}

		static void Question3bv3_4(ref int points1, int win1, int draw1)
		{
			points1 = win1 * 3 + draw1;
		}

		static void Question3bv3()
		{
			int win1 = 0, draw1 = 0, loss1 = 0;
			int points1 = 0;

			for (int i6 = 0; i6 < 10; i6++)
			{
				Console.WriteLine("Enter how many games that team " + (i6 + 1) + " has:");
				Question3bv3_1(ref win1);
				Question3bv3_2(ref draw1);
				Question3bv3_3(ref loss1);
				while (win1 + draw1 + loss1 != 30)
				{
					Console.WriteLine("\nInvalid input. The total number of games is 30.\n\n");
					Console.WriteLine("Enter how many games that team " + (i6 + 1) + " has:");
					Question3bv3_1(ref win1);
					Question3bv3_2(ref draw1);
					Question3bv3_3(ref loss1);
				}
				Question3bv3_4(ref points1, win1, draw1);
				Console.WriteLine("Team " + (i6 + 1) + " gets " + points1 + " points\n");
			}
		}

		static void Question3b()
		{
			try
			{
				int questionchoice4_2_1;
				do
				{
					Console.WriteLine("1 - receive input A via parameter, calculate and display");
					Console.WriteLine("2 - receive input A via parameter, calculate and return result");
					Console.WriteLine("3 - receive input A  via parameter, calculate and updates results via reference parameter");
					Console.Write("Please choose the function: \t");
					questionchoice4_2_1 = Convert.ToInt32(Console.ReadLine());
					if (questionchoice4_2_1 == 1)
					{
						Console.WriteLine();
						Question3bv1();
						Console.WriteLine();
					}
					else if (questionchoice4_2_1 == 2)
					{
						Console.WriteLine();
						Question3bv2();
						Console.WriteLine();
					}
					else if (questionchoice4_2_1 == 3)
					{
						Console.WriteLine();
						Question3bv3();
						Console.WriteLine();
					}
				} while (questionchoice4_2_1 >= 1 && questionchoice4_2_1 <= 3);
			}
			catch(IOException e29)
			{
				Console.WriteLine("Error in Lab5.Question3b: ", e29);
			}
		}

		public static void Question3()
		{
			try
			{
				char questionchoice4_2;

				do
				{
					Console.Write("Please choose 'a' for 'without function', 'b' for 'with function' or any other input to cancel: \t");
					questionchoice4_2 = Convert.ToChar(Console.ReadLine());
					if (questionchoice4_2 == 'a')
					{
						Console.WriteLine();
						Question3a();
						Console.WriteLine();
					}
					else if (questionchoice4_2 == 'b')
					{
						Console.WriteLine();
						Question3b();
						Console.WriteLine();
					}
				} while (questionchoice4_2 == 'a' || questionchoice4_2 == 'b');
			}
			catch(IOException e30)
			{
				Console.WriteLine("Error in Lab5.Question3: ", e30);
			}
		}
	}

	class Lab6
	{
		static void Question1v1(ref string character1)
		{
			try
			{
				do
				{
					Console.Write("Please enter 2 character here: \t");
					character1 = Console.ReadLine();
					// Object.Length measures the length of a string
					if (character1.Length != 2)
					{
						Console.WriteLine("\nInvalid Input!\n");
					}
				} while (character1.Length != 2);
			}
			catch(IOException e32)
			{
				Console.WriteLine("Error in Lab6.Question1v1: ", e32);
			}
		}

		static void Question1v2(string character1)
		{
			char[] character2 = new char[200];
			character2 = (character1.ToLower()).ToCharArray();
			Console.WriteLine("Characters sorted in alphabetical order");
			if (character2[0] < character2[1])
			{
				Console.WriteLine(character1[0] + "" + character1[1]);
			}
			else
			{
				Console.WriteLine(character1[1] + "" + character1[0]);
			}
		}

		public static void Question1()
		{
			string character1 = "";

			Question1v1(ref character1);
			Console.WriteLine();
			Question1v2(character1);
		}

		static void Question2v1(ref string[] name1)
		{
			try
			{
				Console.WriteLine("Please enter 10 names:");
				for (int i7 = 0; i7 < 10; i7++)
				{
					Console.Write((i7 + 1) + ". \t");
					name1[i7] = Console.ReadLine();
				}
			}
			catch(IOException e33)
			{
				Console.WriteLine("Error in Lab6.Question2v1: ", e33);
			}
		}

		static void Question2v2(ref char[] character3, string[] name1)
		{
			Console.WriteLine("The name starts with H and N are:");
			for (int i8 = 0; i8 < 10; i8++)
			{
				character3 = (name1[i8].ToUpper()).ToCharArray();
				if (character3[0] == 'H' || character3[0] == 'N')
				{
					Console.WriteLine(name1[i8]);
				}
			}
		}

		public static void Question2()
		{
			string[] name1 = new string[10];
			char[] character3 = new char[200];

			Question2v1(ref name1);
			Console.WriteLine();
			Question2v2(ref character3, name1);
		}

		static void Question3v1(ref string character4)
		{
			try
			{
				do
				{
					Console.Write("Please enter 10 characters: \t");
					character4 = Console.ReadLine();
					if (character4.Length != 10)
					{
						Console.WriteLine("\nInvalid Input!\n");
					}
				} while (character4.Length != 10);
			}
			catch(IOException e34)
			{
				Console.WriteLine("Error in Lab6.Question3v1: ", e34);
			}
		}

		static void Question3v2(ref int count1, string character4)
		{
			count1 = 0;
			char[] character5 = new char[200];

			character5 = (character4.ToLower()).ToCharArray();

			for(int i9 = 0; i9 < character4.Length; i9++)
			{
				if (character5[i9] != 'a' && character5[i9] != 'e' && character5[i9] != 'i' && character5[i9] != 'o' && character5[i9] != 'u')
				{
					count1++;
				}
			}
			Console.WriteLine("There is/are " + count1 + " consonants in your letters");
		}

		public static void Question3()
		{
			string character4 = "";
			int count1 = 0;

			Question3v1(ref character4);
			Console.WriteLine();
			Question3v2(ref count1, character4);
		}

		static void Question4v1(ref string[] animal1)
		{
			try
			{
				Console.WriteLine("Please enter 5 animals:");
				for (int i10 = 0; i10 < 5; i10++)
				{
					Console.Write((i10 + 1) + ". \t");
					animal1[i10] = Console.ReadLine();
				}
			}
			catch(IOException e35)
			{
				Console.WriteLine("Error in Lab6.Question4v1: ", e35);
			}
		}

		static void Question4v2(ref char[] character6, ref bool isCat1, string[] animal1)
		{
			isCat1 = false;
			Console.WriteLine("List of all animals in Uppercase: ");
			for (int i11 = 0; i11 < 5; i11++)
			{
				character6 = (animal1[i11].ToUpper()).ToCharArray();
				for (int j1 = 0; j1 < character6.Length; j1++)
				{
					Console.Write(character6[j1]);
				}

				if (character6[0] == 'C' && character6[1] == 'A' && character6[2] == 'T')
				{
					isCat1 = true;
				}

				if (i11 < 4)
				{
					Console.Write(", ");
				}
			}
			Console.WriteLine(".");
			if (isCat1)
			{
				Console.WriteLine("The list contains my favourite pet.");
			}
		}

		public static void Question4()
		{
			string[] animal1 = new string[6];
			char[] character6 = new char[200];
			bool isCat1 = false;

			Question4v1(ref animal1);
			Console.WriteLine();
			Question4v2(ref character6, ref isCat1, animal1);
		}

		static void Question5v1(ref string[] car1)
		{
			try
			{
				Console.WriteLine("Please enter 10 car brands:");
				for (int i12 = 0; i12 < 10; i12++)
				{
					Console.Write((i12 + 1) + ". \t");
					car1[i12] = Console.ReadLine();
				}
			}
			catch(IOException e36)
			{
				Console.WriteLine("Error in Lab6.Question5v1: ", e36);
			}
		}

		static void Question5v2(ref char[] character7, string[] car1)
		{
			int k1 = 1;
			Console.WriteLine("Cars that is developed by Proton are: ");
			for (int i13 = 0; i13 < 10; i13++)
			{
				character7 = (car1[i13].ToLower()).ToCharArray();

				if (character7[0] == 'e' && character7[1] == 'x' && character7[2] == 'o' && character7[3] == 'r' && character7[4] == 'a')
				{
					Console.WriteLine(k1 + ". \t" + car1[i13]);
					k1++;
				}
				else if (character7[0] == 'p' && character7[1] == 'e' && character7[2] == 'r' && character7[3] == 's' && character7[4] == 'o' && character7[5] == 'n' && character7[6] == 'a')
				{
					Console.WriteLine(k1 + ". \t" + car1[i13]);
					k1++;
				}
				else if (character7[0] == 's' && character7[1] == 'a' && character7[2] == 'g' && character7[3] == 'a')
				{
					Console.WriteLine(k1 + ". \t" + car1[i13]);
					k1++;
				}
				else if (character7[0] == 'p' && character7[1] == 'r' && character7[2] == 'e' && character7[3] == 'v' && character7[4] == 'e')
				{
					Console.WriteLine(k1 + ". \t" + car1[i13]);
					k1++;
				}
				else if (character7[0] == 'p' && character7[1] == 'e' && character7[2] == 'r' && character7[3] == 'd' && character7[4] == 'a' && character7[5] == 'n' && character7[6] == 'a')
				{
					Console.WriteLine(k1 + ". \t" + car1[i13]);
					k1++;
				}
				else if (character7[0] == 'i' && character7[1] == 'r' && character7[2] == 'i' && character7[3] == 's')
				{
					Console.WriteLine(k1 + ". \t" + car1[i13]);
					k1++;
				}
				else if (character7[0] == 's' && character7[1] == 'u' && character7[2] == 'p' && character7[3] == 'r' && character7[4] == 'i' && character7[5] == 'm' && character7[6] == 'a')
				{
					Console.WriteLine(k1 + ". \t" + car1[i13]);
					k1++;
				}
			}
		}

		public static void Question5()
		{
			string[] car1 = new string[11];
			char[] character7 = new char[200];

			Question5v1(ref car1);
			Console.WriteLine();
			Question5v2(ref character7, car1);
		}

		static void Question6v1(ref string[] name2, ref string[] IC1)
		{
			try
			{
				Console.WriteLine("Insert 10 names and IC numbers:");
				for (int i14 = 0; i14 < 10; i14++)
				{
					do
					{
						Console.Write((i14 + 1) + ". Name: \t");
						name2[i14] = Console.ReadLine();
						Console.Write("IC number: \t");
						IC1[i14] = Console.ReadLine();
						if (IC1[i14].Length != 12)
						{
							Console.WriteLine("Invalid IC number.\n");
						}
					} while (IC1[i14].Length != 12);
				}
			}
			catch(IOException e37)
			{
				Console.WriteLine("Error in Lab6.Question6v1: ", e37);
			}
		}

		static void Question6v2(ref char[] oldest1, ref char[] character8, ref string oldest2, string[] name2, string[] IC1)
		{
			int j3 = 0;
			oldest1[0] = '9'; oldest1[1] = '9'; oldest1[2] = '1'; oldest1[3] = '2'; oldest1[4] = '3'; oldest1[5] = '1';
			for (int i15 = 0; i15 < 10; i15++)
			{
				j3 = 0;
				character8 = IC1[i15].ToCharArray();
				Console.WriteLine((i15 + 1) + ". Name: \t" + name2[i15]);

				while (character8[j3] - '0' == oldest1[j3] - '0' && j3 < 6)
				{
					if (character8[j3] - '0' == oldest1[j3] - '0')
					{
						j3++;
					}
				}

				if (character8[j3] - '0' < oldest1[j3] - '0')
				{
					for (int k1 = 0; k1 < 6; k1++)
					{
						oldest1[k1] = character8[k1];
					}
					oldest2 = name2[i15];
				}
			}

			Console.WriteLine("The oldest person in the list is " + oldest2);
		}

		public static void Question6()
		{
			string[] name2 = new string[11]; string[] IC1 = new string[11]; string oldest2 = "";
		    char[] character8 = new char[200]; char[] oldest1 = new char[7];

			Question6v1(ref name2, ref IC1);
			Console.WriteLine();
			Question6v2(ref oldest1, ref character8, ref oldest2, name2, IC1);
		}

		static void Question8v1(ref string[] name3, ref string[] gender1, ref int[] score1)
		{
			try
			{
				string gender2;
				Console.WriteLine("Please insert 10 names and their gender and score.");
				for (int i16 = 0; i16 < 10; i16++)
				{
					do
					{
						Console.Write((i16 + 1) + ". Name: \t");
						name3[i16] = Console.ReadLine();
						Console.Write("Gender: \t");
						gender1[i16] = Console.ReadLine();
						gender2 = gender1[i16].ToLower();
						if (gender2 != "male" && gender2 != "female")
						{
							Console.WriteLine("Invalid gender.");
						}
						else
						{
							Console.Write("Score: \t");
							score1[i16] = Convert.ToInt32(Console.ReadLine());
							if (score1[i16] < 0)
							{
								Console.WriteLine("Invalid score.");
							}
						}
					} while (gender2 != "male" && gender2 != "female");
				}
			}
			catch(IOException e38)
			{
				Console.WriteLine("Error in Lab6.Question8v1: ", e38);
			}
		}

		static void Question8v2(ref int male1, ref int female1, ref int highest1, ref int lowest1, ref string highest2, ref string lowest2, string[] name3, string[] gender1, int[] score1)
		{
			male1 = 0;
			female1 = 0;
			highest1 = lowest1 = 0;

			for (int i17 = 0; i17 < 10; i17++)
			{
				if (gender1[i17] == "male")
				{
					male1++;
				}
				else if (gender1[i17] == "female")
				{
					female1++;
				}

				if (score1[i17] > highest1)
				{
					highest1 = score1[i17];
					highest2 = name3[i17];
				}

				if (i17 == 0)
				{
					lowest1 = score1[i17];
					lowest2 = name3[i17];
				}
				else
				{
					if (score1[i17] < lowest1)
					{
						lowest1 = score1[i17];
						lowest2 = name3[i17];
					}
				}
			}

			Console.WriteLine("The number of");
			Console.WriteLine("Males: \t" + male1);
			Console.WriteLine("Females: \t" + female1 + "\n");
			Console.WriteLine("The person with the highest score is " + highest2);
			Console.WriteLine( "The person with the lowest score is " + lowest2);
		}

		public static void Question8()
		{
			string[] name3 = new string[11]; string[] gender1 = new string[11];
			string highest2 = "", lowest2 = "";
			int[] score1 = new int[11]; 
			int male1 = 0, female1 = 0, highest1 = 0, lowest1 = 0;

			Question8v1(ref name3, ref gender1, ref score1);
			Console.WriteLine();
			Question8v2(ref male1, ref female1, ref highest1, ref lowest1, ref highest2, ref lowest2, name3, gender1, score1);
		}

		static void Question9v1(ref string[] playername1, ref int[] weapon1)
		{
			try
			{
				Console.WriteLine("Please enter 10 player names and number of weapons for each player:");
				for (int i18 = 0; i18 < 10; i18++)
				{
					Console.Write("Player " + (i18 + 1) + " name: \t");
					playername1[i18] = Console.ReadLine();
					do
					{
						Console.Write("Number of weapons: \t");
						weapon1[i18] = Convert.ToInt32(Console.ReadLine());
						if (weapon1[i18] < 0)
						{
							Console.WriteLine("Invalid Input.\n");
						}
					} while (weapon1[i18] < 0);
				}
			}
			catch(IOException e39)
			{
				Console.WriteLine("Error in Lab6.Question9v1: ", e39);
			}
		}

		static void Question9v2(ref int temp1, ref string temp2, string[] playername1, int[] weapon1)
		{
			int i19 = 0;
			do
			{
				if (weapon1[i19] < weapon1[i19 + 1])
				{
					temp1 = weapon1[i19];
					temp2 = playername1[i19];
					weapon1[i19] = weapon1[i19 + 1];
					playername1[i19] = playername1[i19 + 1];
					weapon1[i19 + 1] = temp1;
					playername1[i19 + 1] = temp2;
					i19 = 0;
				}
				else
				{
					i19++;
				}
			} while (i19 < 9);

			Console.WriteLine("List of player names and number of weapons from highest to lowest:");
			for (int i20 = 0; i20 < 10; i20++)
			{
				Console.WriteLine((i20 + 1) + ". " + playername1[i20] + " " + weapon1[i20] + " weapon(s)");
			}
		}

		public static void Question9()
		{
			string[] playername1 = new string[11];
			string temp2 = "";
			int[] weapon1 = new int[11];
			int temp1 = 0;

			Question9v1(ref playername1, ref weapon1);
			Console.WriteLine();
			Question9v2(ref temp1, ref temp2, playername1, weapon1);
		}

		static void ExtraQuestion_1(ref string[] IC2, ref int[] gamelevel1)
		{
			try
			{
				Console.WriteLine("Insert 5 last 4 of IC numbers and game level");
				for (int i21 = 0; i21 < 5; i21++)
				{
					do
					{
						Console.Write((i21 + 1) + ". Last 4 IC Number: \t");
						IC2[i21] = Console.ReadLine();
						if (IC2[i21].Length > 4)
						{
							Console.WriteLine("Invalid Input.");
						}
						else
						{
							Console.Write("Game level: \t");
							gamelevel1[i21] = Convert.ToInt32(Console.ReadLine());
							if (gamelevel1[i21] < 0)
							{
								Console.WriteLine("Invalid Game Level");
							}
						}
					} while (IC2[i21].Length > 4 || gamelevel1[i21] < 0);
				}
			}
			catch(IOException e40)
			{
				Console.WriteLine("Error in Lab6.ExtraQuestionv1: ", e40);
			}
		}

		static void ExtraQuestion_2(string[] IC2, int[] gamelevel1)
		{
			Console.WriteLine("LAST FOUR NO IC  GAME LEVEL\n");
			for (int i22 = 0; i22 < 5; i22++)
			{
				Console.WriteLine("       " + IC2[i22] + "         " + gamelevel1[i22]);
			}
		}

		static void ExtraQuestion_3(ref int female2, ref int male2, ref char[] character9, string[] IC2)
		{
			female2 = 0;
			male2 = 0;
			for (int i23 = 0; i23 < 5; i23++)
			{
				character9 = IC2[i23].ToCharArray();
				if ((character9[3] - '0') % 2 == 0)
				{
					female2++;
				}
				else
				{
					male2++;
				}
			}
			Console.WriteLine("There are " + female2 + " female players and " + male2 + " male players");
		}

		static void ExtraQuestion_4(ref int highest3, ref string highest4, string[] IC2, int[] gamelevel1)
		{
			highest3 = 0;
			for (int i24 = 0; i24 < 5; i24++)
			{
				if (gamelevel1[i24] > highest3)
				{
					highest3 = gamelevel1[i24];
					highest4 = IC2[i24];
				}
			}
			Console.WriteLine(highest4 + " plays the highest game level: " + highest3);
		}

		static void ExtraQuestion_5(string[] IC2, int[] gamelevel1)
		{
			int temp3;
			string temp4;
			int i25 = 0;
			do
			{
				if (gamelevel1[i25] < gamelevel1[i25 + 1])
				{
					temp3 = gamelevel1[i25];
					temp4 = IC2[i25];
					gamelevel1[i25] = gamelevel1[i25 + 1];
					IC2[i25] = IC2[i25 + 1];
					gamelevel1[i25 + 1] = temp3;
					IC2[i25 + 1] = temp4;
					i25 = 0;
				}
				else
				{
					i25++;
				}
			} while (i25 < 4);

			Console.WriteLine("SORTED LIST BASED ON GAME LEVEL (HIGHEST TO LOWEST)\n");
			Console.WriteLine("LAST FOUR NO IC  GAME LEVEL\n");
			for (int i26 = 0; i26 < 5; i26++)
			{
				Console.WriteLine("       " + IC2[i26] + "         " + gamelevel1[i26]);
			}
		}

		public static void ExtraQuestion()
		{
			string[] IC2 = new string[6];
			string highest4 = "";
			char[] character8 = new char[200]; char[] character9 = new char[200];
			int[] gamelevel1 = new int[6];
			int female2 = 0, male2 = 0, highest3 = 0;

			ExtraQuestion_1(ref IC2, ref gamelevel1);
			ExtraQuestion_2(IC2, gamelevel1);
			ExtraQuestion_3(ref female2, ref male2, ref character9, IC2);
			ExtraQuestion_4(ref highest3, ref highest4, IC2, gamelevel1);
			ExtraQuestion_5(IC2, gamelevel1);
		}
	}

	class Lab7
	{
		static void Question1v1(ref string[] playername2, ref string[] gender3, ref int[] age1, ref int[] armour1)
		{
			int i27 = 0;
			string path1 = @"C:\Users\Muhammad Aiman\source\repos\ProgrammingFundamentalsCS\ProgrammingFundamentalsCS\details.txt";

			//File.Exists checks if a file exists
			if (File.Exists(path1))
			{
				//StreamReader is a class that reads the file
				//File.OpenText Open a text file for read
				using(StreamReader streamreader = File.OpenText(path1))
				{
					string file1;
					//loops every line while there's still a text to read
					while ((file1 = streamreader.ReadLine()) != null)
					{
						//Substring takes part of a string. The arguement taken is (startindex, length)
						playername2[i27] = file1.Substring(0,6);
						gender3[i27] = file1.Substring(9,1);
						age1[i27] = Convert.ToInt32(file1.Substring(14, 2));
						armour1[i27] = Convert.ToInt32(file1.Substring(19,3));
						i27++;
					}
				}
			}
			else
			{
				Console.WriteLine("File not found.");
			}
		}

		static void F1(ref int agecount1, string[] gender3, int[] age1)
		{
			agecount1 = 0;
			string path2 = @"C:\Users\Muhammad Aiman\source\repos\ProgrammingFundamentalsCS\ProgrammingFundamentalsCS\Analysis.txt";
			//CreateText Creates a new text in a text file and overwrites if exists
			using (StreamWriter streamwriter1 = File.CreateText(path2))
			{
				for (int i28 = 0; i28 < 10; i28++)
				{
					if (gender3[i28] == "M" && age1[i28] >= 15)
					{
						agecount1++;
						Console.WriteLine(agecount1);
					}
				}
				streamwriter1.WriteLine("The number of male players aged 15 years and above = " + agecount1);
			}
		}

		static void F2(ref int highest5, ref string highest6, string[] playername2, int[] armour1)
		{
			highest5 = 0;
			string path3 = @"C:\Users\Muhammad Aiman\source\repos\ProgrammingFundamentalsCS\ProgrammingFundamentalsCS\Analysis.txt";
			//AppendText adds a new text in an existing file. Preventing the file to overwrite by CreateText method
			using (StreamWriter streamwriter2 = File.AppendText(path3))
			{
				for (int i29 = 0; i29 < 10; i29++)
				{
					if (armour1[i29] > highest5)
					{
						highest5 = armour1[i29];
						highest6 = playername2[i29];
					}
				}
				streamwriter2.WriteLine("\nThe player that has highest armour = " + highest6);
			}
			Console.WriteLine("End of operation. Please check 'Analysis.txt' for verification");
		}

		public static void Question1()
		{
			string[] playername2 = new string[11]; string[] gender2 = new string[11];
			string highest6 = "";
			int[] age1 = new int[11]; int[] armour1 = new int[11];
			int agecount1 = 0, highest5 = 0;

			Question1v1(ref playername2, ref gender2, ref age1, ref armour1);
			F1(ref agecount1, gender2, age1);
			F2(ref highest5, ref highest6, playername2, armour1);
		}
	}
	class Program
    {
		static void FLab1()
		{
			try
			{
				int queestionchoice1;

				do
				{
					Console.WriteLine("Lab 1 - Introduction to Visual C++ Program");
					Console.Write("Please select question range from 1 and 2, or key in other inputs to cancel: \t");
					queestionchoice1 = Convert.ToInt32(Console.ReadLine());

					if (queestionchoice1 == 1)
					{
						Console.WriteLine();
						Lab1.Question1();
						Console.WriteLine();
					}
					else if (queestionchoice1 == 2)
					{
						Console.WriteLine();
						Lab1.Question2();
						Console.WriteLine();
					}
				} while (queestionchoice1 == 1 || queestionchoice1 == 2);
			}
			catch(IOException e2)
			{
				Console.WriteLine("Error in Function Lab1: ", e2);
			}
		}

		static void FLab2()
		{
			try
			{
				int queestionchoice2;

				do
				{
					Console.WriteLine("Lab 2 - Introduction to C# and Problem Solving");
					Console.Write("Please select question range from 1 and 4, or key in other inputs to cancel: \t");
					queestionchoice2 = Convert.ToInt32(Console.ReadLine());

					if (queestionchoice2 == 1)
					{
						Console.WriteLine();
						Lab2.Question1();
						Console.WriteLine();
					}
					else if (queestionchoice2 == 2)
					{
						Console.WriteLine();
						Lab2.Question2();
						Console.WriteLine();
					}
					else if (queestionchoice2 == 3)
					{
						Console.WriteLine();
						Lab2.Question3();
						Console.WriteLine();
					}
					else if (queestionchoice2 == 4)
					{
						Console.WriteLine();
						Lab2.Question4();
						Console.WriteLine();
					}
				} while (queestionchoice2 >= 1 && queestionchoice2 <= 4);
			}
			catch (IOException e4)
			{
				Console.WriteLine("Error in Function Lab2: ", e4);
			}
		}

		static void FLab4()
		{
			try
			{
				int questionchoice3;

				do
				{
					Console.WriteLine("Lab 4 - Selection and Repetition");
					Console.WriteLine("NOTE: QUESTION 1 TO 4 IS MERGED TO OUTPUT NUMBER 1, QUESTION 5 IS OUTPUT 2, QUESTION 6 IS OUTPUT 3 AND EXERCISE IS OUTPUT 4");
					Console.Write("Please select question range from 1 and 4, or key in other inputs to cancel: \t");
					questionchoice3 = Convert.ToInt32(Console.ReadLine());
					if (questionchoice3 == 1)
					{
						Console.WriteLine();
						Lab4.Question1();
						Console.WriteLine();
						Lab4.Question2();
						Console.WriteLine();
						Lab4.Question3();
						Console.WriteLine();
						Lab4.Question4();
						Console.WriteLine();
					}
					else if (questionchoice3 == 2)
					{
						Console.WriteLine();
						Lab4.Question5();
						Console.WriteLine();
					}
					else if (questionchoice3 == 3)
					{
						Console.WriteLine();
						Lab4.Question6();
						Console.WriteLine();
					}
					else if (questionchoice3 == 4)
					{
						Console.WriteLine();
						Lab4.Question7();
						Console.WriteLine();
					}
				} while (questionchoice3 >= 1 && questionchoice3 <= 4);
			}
			catch(IOException e9)
			{
				Console.WriteLine("Error in Function Lab4: ", e9);
			}
		}

		static void FLab5()
		{
			try
			{
				int questionchoice4;

				do
				{
					Console.WriteLine("Lab 5 - Functions");
					Console.Write("Please select question range from 1 and 3, or key in other inputs to cancel: \t");
					questionchoice4 = Convert.ToInt32(Console.ReadLine());
					if (questionchoice4 == 1)
					{
						Console.WriteLine();
						Lab5.Question1();
					}
					else if (questionchoice4 == 2)
					{
						Console.WriteLine();
						Lab5.Question2();
						Console.WriteLine();
					}
					else if (questionchoice4 == 3)
					{
						Console.WriteLine();
						Lab5.Question3();
						Console.WriteLine();
					}
				} while (questionchoice4 >= 1 && questionchoice4 <= 3);
			}
			catch (IOException e14)
			{
				Console.WriteLine("Error in Function Lab5: ", e14);
			}
		}

		static void FLab6()
		{
			try
			{
				int questionchoice5;

				do
				{
					Console.WriteLine("Lab 6 - String and Array");
					Console.WriteLine("NOTE: QUESTION 7 AND 10 ARE SKIPPED DUE TO FUNCTIONS AND ARRAY ARE ALREADY USED FOR EVERY QUESTION.");
					Console.WriteLine("QUESTION 8 BECOMES OUTPUT 7 AND QUESTION 9 BECOMES OUTPUT 8");
					Console.WriteLine("EXTRA: OUTPUT 9 CONTAINS AN EXTRA QUESTION.");
					Console.Write("Please select question range from 1 and 9, or key in other inputs to cancel: \t");
					questionchoice5 = Convert.ToInt32(Console.ReadLine());
					if (questionchoice5 == 1)
					{
						Console.WriteLine();
						Lab6.Question1();
						Console.WriteLine();
					}
					else if (questionchoice5 == 2)
					{
						Console.WriteLine();
						Lab6.Question2();
						Console.WriteLine();
					}
					else if (questionchoice5 == 3)
					{
						Console.WriteLine();
						Lab6.Question3();
						Console.WriteLine();
					}
					else if (questionchoice5 == 4)
					{
						Console.WriteLine();
						Lab6.Question4();
						Console.WriteLine();
					}
					else if (questionchoice5 == 5)
					{
						Console.WriteLine();
						Lab6.Question5();
						Console.WriteLine();
					}
					else if (questionchoice5 == 6)
					{
						Console.WriteLine();
						Lab6.Question6();
						Console.WriteLine();
					}
					else if (questionchoice5 == 7)
					{
						Console.WriteLine();
						Lab6.Question8();
						Console.WriteLine();
					}
					else if (questionchoice5 == 8)
					{
						Console.WriteLine();
						Lab6.Question9();
						Console.WriteLine();
					}
					else if (questionchoice5 == 9)
					{
						Console.WriteLine();
						Lab6.ExtraQuestion();
						Console.WriteLine();
					}
				} while (questionchoice5 >= 1 && questionchoice5 <= 9);
			}
			catch(IOException e31)
			{
				Console.WriteLine("Error in function Lab6: ", e31);
			}
		}


		static void Main(string[] args)
        {
			//try is a normal code that it runs
			try
			{
				int topicchoice1;

				do
				{
					Console.WriteLine("BITE1513 - Programming Fundamentals (using C#)\n");
					Console.WriteLine("1 - Lab 1: Introduction to C# Program");
					Console.WriteLine("2 - Lab 2: Introduction to C# and Problem Solving");
					Console.WriteLine("3 - Lab 4: Selection and Repetition");
					Console.WriteLine("4 - Lab 5: Functions");
					Console.WriteLine("5 - Lab 6: String and Arrays");
					Console.WriteLine("6 - Lab 7: Input Output File");
					Console.Write("\n Please choose topic: \t");
					topicchoice1 = Convert.ToInt32(Console.ReadLine());
					if (topicchoice1 == 1)
					{
						Console.WriteLine();
						FLab1();
						Console.WriteLine();
					}
					else if (topicchoice1 == 2)
					{
						Console.WriteLine();
						FLab2();
						Console.WriteLine();
					}
					else if (topicchoice1 == 3)
					{
						Console.WriteLine();
						FLab4();
						Console.WriteLine();
					}
					else if (topicchoice1 == 4)
					{
						Console.WriteLine();
						FLab5();
						Console.WriteLine();
					}
					else if(topicchoice1 == 5)
					{
						Console.WriteLine();
						FLab6();
						Console.WriteLine();
					}
					else if (topicchoice1 == 6)
					{
						Console.WriteLine();
						Lab7.Question1();
						Console.WriteLine();
					}
				} while (topicchoice1 >= 1 && topicchoice1 <= 6);
			}
			//catch is an exception that it catch if an error occured during the code in the try block runs.
			catch(IOException e1)
			{
				Console.WriteLine("Error in the program: ", e1);
			}
		}
    }
}
