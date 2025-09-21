using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercise_5
{
    internal class Ex05
    {
        static void Main()
        {
            Ex01();
            Ex02();
            Ex03();
            Ex04();
            Ex5();
            Ex06();
            Ex07();
            Ex08();
            Ex09();
            Ex10();
        }
        /// <summary>
        /// Create a random integer values array, then create functions that:
        ///1.to calculate the average value of array elements.
        ///</summary>
        static void Ex01()
        {
            Random random = new Random();
            int[] numbers = new int[10];

            // Tạo mảng ngẫu nhiên
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 101);
            }

            // In mảng
            Console.WriteLine("Mang so ngau nhien:");
            Console.WriteLine(string.Join(", ", numbers));

            // Tính trung bình
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            double average = (double)sum / numbers.Length;

            // In kết quả
            Console.WriteLine($"Gia tri trung binh = {average:F2}");
        }
        /// <summary>
        /// 2.to test if an array contains a specific value.
        /// </summary>
        static void Ex02()
        {
            Random random = new Random();
            int[] numbers = new int[10];

            // Tạo mảng ngẫu nhiên
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 21);
            }

            // In mảng
            Console.WriteLine("Mang so ngau nhien:");
            Console.WriteLine(string.Join(", ", numbers));

            // Nhập số cần tìm
            Console.Write("Nhap gia tri can kiem tra: ");
            string? input = Console.ReadLine();
            if (!int.TryParse(input, out int target))
            {
                Console.WriteLine("Gia tri nhap vao khong hop le.");
                return;
            }

            // Kiểm tra tồn tại
            bool found = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == target)
                {
                    found = true;
                    break;
                }
            }

            // In kết quả
            if (found)
            {
                Console.WriteLine($"Mang co chua gia tri {target}.");
            }
            else
            {
                Console.WriteLine($"Mang khong chua gia tri {target}.");
            }
        }

        /// <summary>
        ///3.to find the index of an array element.
        ///</summary>
        static void Ex03()
        {
            Random random = new Random();
            int[] numbers = new int[10];

            // Tạo mảng ngẫu nhiên
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 21);
            }

            // In mảng
            Console.WriteLine("Mang so ngau nhien:");
            Console.WriteLine(string.Join(", ", numbers));

            // Nhập giá trị cần tìm
            Console.Write("Nhap gia tri can tim: ");
            string? input = Console.ReadLine();
            if (!int.TryParse(input, out int target))
            {
                Console.WriteLine("Gia tri nhap vao khong hop le.");
                return;
            }
            // Tìm chỉ số
            int index = -1;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == target)
                {
                    index = i;
                    break; // tìm thấy phần tử đầu tiên thì dừng
                }
            }

            // In kết quả
            if (index != -1)
            {
                Console.WriteLine($"Gia tri {target} nam tai vi tri {index} trong mang.");
            }
            else
            {
                Console.WriteLine($"Khong tim thay gia tri {target} trong mang.");
            }
        }
        /// <summary>
        /// 4.to remove a specific element from an array.
        /// </summary>
        static void Ex04()
        {
            Random random = new Random();
            int[] numbers = new int[10];
            // Tạo mảng ngẫu nhiên
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 21);
            }
            // In mảng
            Console.WriteLine("Mang so ngau nhien:");
            Console.WriteLine(string.Join(", ", numbers));
            // Nhập giá trị cần xóa
            Console.Write("Nhap gia tri can xoa: ");
            string? input = Console.ReadLine();
            if (!int.TryParse(input, out int target))
            {
                Console.WriteLine("Gia tri nhap vao khong hop le.");
                return;
            }
            // Xóa phần tử
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != target)
                {
                    numbers[count] = numbers[i];
                    count++;
                }
            }
            // Tạo mảng mới với kích thước mới
            int[] newArray = new int[count];
            Array.Copy(numbers, newArray, count);
            // In kết quả
            Console.WriteLine("Mang sau khi xoa:");
            Console.WriteLine(string.Join(", ", newArray));
        }
        /// <summary>
        /// 5.to find the maximum and minimum value of an array.
        /// </summary>
        static void Ex5()
        {
            Random random = new Random();
            int[] numbers = new int[10];
            // Tạo mảng ngẫu nhiên
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 101);
            }
            // In mảng
            Console.WriteLine("Mang so ngau nhien:");
            Console.WriteLine(string.Join(", ", numbers));
            // Tìm giá trị lớn nhất và nhỏ nhất
            int max = numbers[0];
            int min = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            // In kết quả
            Console.WriteLine($"Gia tri lon nhat: {max}");
            Console.WriteLine($"Gia tri nho nhat: {min}");
        }
        ///<summary>
        ///6.to reverse an array of integer values.
        ///</summary>
        static void Ex06()
        {
            Random random = new Random();
            int[] numbers = new int[10];
            // Tạo mảng ngẫu nhiên
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 101);
            }
            // In mảng
            Console.WriteLine("Mang so ngau nhien:");
            Console.WriteLine(string.Join(", ", numbers));
            // Đảo ngược mảng
            int left = 0;
            int right = numbers.Length - 1;
            while (left < right)
            {
                int temp = numbers[left];
                numbers[left] = numbers[right];
                numbers[right] = temp;
                left++;
                right--;
            }
            // In kết quả
            Console.WriteLine("Mang sau khi dao nguoc:");
            Console.WriteLine(string.Join(", ", numbers));
        }
        /// <summary>
        /// 7.to find duplicate values in an array of values.
        /// </summary>
        static void Ex07()
        {
            Random random = new Random();
            int[] numbers = new int[10];
            // Tạo mảng ngẫu nhiên
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 21);
            }
            // In mảng
            Console.WriteLine("Mang so ngau nhien:");
            Console.WriteLine(string.Join(", ", numbers));
            // Tìm giá trị trùng lặp
            HashSet<int> duplicates = new HashSet<int>();
            HashSet<int> seen = new HashSet<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (seen.Contains(numbers[i]))
                {
                    duplicates.Add(numbers[i]);
                }
                else
                {
                    seen.Add(numbers[i]);
                }
            }
            // In kết quả
            if (duplicates.Count > 0)
            {
                Console.WriteLine("Cac gia tri bi trung lap: " + string.Join(", ", duplicates));
            }
            else
            {
                Console.WriteLine("Khong co gia tri bi trung lap.");
            }
        }
        /// <summary>
        /// 8.to remove duplicate elements from an array.
        /// </summary>
        static void Ex08()
        {
            Random random = new Random();
            int[] numbers = new int[10];
            // Tạo mảng ngẫu nhiên
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 21);
            }
            // In mảng
            Console.WriteLine("Mang so ngau nhien:");
            Console.WriteLine(string.Join(", ", numbers));
            // Xóa phần tử trùng lặp
            HashSet<int> uniqueNumbers = new HashSet<int>(numbers);
            int[] newArray = uniqueNumbers.ToArray();
            // In kết quả
            Console.WriteLine("Mang sau khi xoa cac gia tri trung lap:");
            Console.WriteLine(string.Join(", ", newArray));
        }
        /// <summary>
        /// Create a C# program that
        ///9. requests 10 integers from the user and orders them by implementing the bubble sort algorithm.
        ///</summary>
        static void Ex09()
        {
            int[] numbers = new int[10];
            // Người dùng nhập mảng
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Nhap so nguyen thu {i + 1}: ");
                string? input = Console.ReadLine();
                if (!int.TryParse(input, out numbers[i]))
                {
                    Console.WriteLine("Gia tri nhap vao khong hop le. Vui long nhap lai.");
                    i--; // Giảm chỉ số để nhập lại
                }
            }
            // In mảng ban đầu
            Console.WriteLine("Mang ban dau:");
            Console.WriteLine(string.Join(", ", numbers));
            // Sắp xếp mảng bằng thuật toán bubble sort
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - 1 - i; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        // Đổi chỗ
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
            // In kết quả
            Console.WriteLine("Mang sau khi sap xep:");
            Console.WriteLine(string.Join(", ", numbers));
        }
        /// <summary>
        /// 10. Request a sentence from the user, then ask to enter a word. Search if the word appears in the phrase using the linear search algorithm.
        /// </summary>
        static void Ex10()
        {
            // Người dùng nhập câu
            Console.Write("Nhap mot cau: ");
            string? sentence = Console.ReadLine();
            if (string.IsNullOrEmpty(sentence))
            {
                Console.WriteLine("Cau nhap vao khong hop le.");
                return;
            }
            // Nhập từ cần tìm
            Console.Write("Nhap mot tu can tim: ");
            string? target = Console.ReadLine();
            if (string.IsNullOrEmpty(target))
            {
                Console.WriteLine("Tu nhap vao khong hop le.");
                return;
            }
            // Tách câu thành mảng từ
            string[] words = sentence.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            // Linear search
            bool found = false;
            for (int i = 0; i < words.Length; i++)
            {
                if (string.Equals(words[i], target, StringComparison.OrdinalIgnoreCase))
                {
                    found = true;
                    break;
                }
            }
            // In kết quả
            if (found)
            {
                Console.WriteLine($"Tu '{target}' xuat hien trong cau.");
            }
            else
            {
                Console.WriteLine($"Tu '{target}' khong xuat hien trong cau.");
            }
        }
    }
}
