using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numofnum
{
    internal class Program
    {
      
          
            static void Main()
            {
                // تعريف مصفوفة الأعداد
                int[] numbers = { 25, 30, 30, 40, 50, 60, 70, 75, 75, 80 }; // مثال على الأعداد
                Dictionary<int, int> frequency = CalculateFrequency(numbers);

                // عرض النتائج
                foreach (var item in frequency)
                {
                    Console.WriteLine($"القيمة {item.Key} تكررت {item.Value} مرة.");
                }
            var occurrences = new Dictionary<int, int>();
            CountOccurrences(numbers, 0, occurrences);

            // عرض النتائج
            DisplayResults(occurrences);
        }
        static void CountOccurrences(int[] arr, int index, Dictionary<int, int> occurrences)
        {
            // التحقق من أن المصفوفة ليست فارغة
            if (arr == null || arr.Length == 0)
            {
                Console.WriteLine("المصفوفة فارغة أو غير موجودة.");
                return;
            }

            // إذا وصلنا إلى نهاية المصفوفة، نخرج من التابع
            if (index >= arr.Length)
            {
                return;
            }

            int number = arr[index];

            // التحقق من أن الرقم يقع ضمن النطاق المطلوب
            if (number < 25 || number > 75)
            {
                Console.WriteLine($"تحذير: القيمة {number} خارج النطاق المسموح به (25-75).");
            }
            else
            {
                // تحديث عدد التكرارات
                if (occurrences.ContainsKey(number))
                {
                    occurrences[number]++;
                }
                else
                {
                    occurrences[number] = 1; // إضافة الرقم إلى القاموس
                }
            }

            // استدعاء التابع بشكل عودي للعنصر التالي
            CountOccurrences(arr, index + 1, occurrences);
        }

        static void DisplayResults(Dictionary<int, int> occurrences)
        {
            Console.WriteLine("عدد مرات تكرار كل قيمة:");
            foreach (var pair in occurrences)
            {
                Console.WriteLine($"القيمة {pair.Key} تتكرر {pair.Value} مرة.");
            }
        }

        /// <summary>
        /// تابع لحساب عدد مرات تكرار القيم بين 25 و75 في مصفوفة.
        /// </summary>
        /// <param name="array">مصفوفة الأعداد.</param>
        /// <returns>قاموس يحتوي على القيم وعدد تكرارها.</returns>
        static Dictionary<int, int> CalculateFrequency(int[] array)
            {
                // قاموس لتخزين القيم وتكرارها
                Dictionary<int, int> frequency = new Dictionary<int, int>();

                // التحقق من أن المصفوفة ليست فارغة
                if (array == null || array.Length == 0)
                {
                    Console.WriteLine("المصفوفة فارغة أو غير موجودة.");
                    return frequency;
                }

                // تكرار العناصر في المصفوفة
                foreach (int number in array)
                {
                    // التحقق من أن القيمة بين 25 و75
                    if (number >= 25 && number <= 75)
                    {
                        // إذا كانت القيمة موجودة بالفعل في القاموس، نزيد التكرار
                        if (frequency.ContainsKey(number))
                        {
                            frequency[number]++;
                        }
                        else
                        {
                            // إذا لم تكن القيمة موجودة، نضيفها إلى القاموس مع تكرار 1
                            frequency[number] = 1;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"تحذير: القيمة {number} خارج النطاق المسموح به (25-75).");
                    }
                }

                return frequency;
            }
        }
    
}
