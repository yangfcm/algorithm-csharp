using System;

namespace Algo.Sorting
{
    /// <summary>
    /// Assume a bank has a simple policy for warning clients about possible fradulate account activity. 
    /// If the amount spent by a client on a particular day is greater than or equal to the client's median spending for a trailing number of days,
    /// they send the client a notification about potential fraud.
    /// The bank doesn't send the client any notifications until they have at least that trailing number of prior days' transaction data.
    /// Given the number of trailing days *d* and a client's total daily expenditures for a period of *n* days,
    /// determine the number of times the client will receive a notification over all *n* days.
    /// </summary>
    /// <example>
    /// expenditure = [10, 20, 30, 40, 50] d = 3, fradulentActivityNotice(expenditure, d) -> 1.
    /// As d = 3, on the first 3 days, it just collects data. On day 4, trailing 3 days expenditures are [10, 20, 30].
    /// The median is 20 and D4's expenditure is 40. Because 40 >= 20 * 2, client will get a notification.
    /// Then on day 5, trailing 3 days expenditures are [20, 30, 40]. The median is 30 and D5's expenditure is 50.
    /// Because 50 < 30 * 2, client will not get a notification on that day.
    /// So, there will be 1 notification sent.
    /// </example>
    public class FradulentActivityNotice
    {
        public static int Solution(int[] expenditure, int d) {
            int notificationCount = 0;
            int max = expenditure[0];
            foreach (int i in expenditure) {
                if(i > max) max = i;
            }
            int[] countArr = new int[max + 1];
            Array.Fill(countArr, 0); // Initialize count array.

            for(int i = 0; i < d; i++ ) {
            // Fill a partial count array from the first day to the d-th day.
            countArr[expenditure[i]]++;
            }

            // With the time moving on, you just need to care about the expenditure in previous d days.
            for(int i = d; i < expenditure.Length; i++) {
            int median = GetMedian(d, countArr);
            if(expenditure[i] >= median) notificationCount++;

            // Update count array
            countArr[expenditure[i-d]]--;
            countArr[expenditure[i]]++;
            }

            return notificationCount;
        }

        private static int GetMedian(int d, int[] count) {
            int median = 0;
            int[] countArr = (int[]) count.Clone();
            for(int i = 1; i < countArr.Length; i++) {
            countArr[i] += countArr[i-1];
            }

            if(d % 2 == 0) {
            int m1 = d / 2;
            int m2 = d / 2 + 1;
            for(int i = 0; i < countArr.Length; i++) {
                if(m1 <= countArr[i]) {
                median += i;
                break;
                }
            }
            for(int i = 0; i < countArr.Length; i++) {
                if(m2 <= countArr[i]) {
                median += i;
                break;
                }
            }
            } else {
            int m = (d + 1) / 2;
            for(int i = 0; i < countArr.Length; i++) {
                if(m <= countArr[i]) {
                median = i * 2;
                break;
                }
            }
            }

            return median;
        }
    }
}