using System;
using SIR_ARCANA.Forms;
using SIR_ARCANA.Models;

namespace SIR_ARCANA
{
    /// <summary>
    /// Simple test class to verify Money Manager calculations
    /// </summary>
    public static class TestMoneyManager
    {
        public static void RunTests()
        {
            Console.WriteLine("Testing Money Manager Calculations...");
            
            // Create a test user
            var testUser = new User
            {
                UserId = 1,
                Username = "test",
                Role = "Employee"
            };
            
            var moneyManager = new MoneyManager(testUser);
            
            // Test case 1: Basic calculation
            moneyManager.SetDenominationCount(1000, 2);  // 2 x ₱1,000 = ₱2,000
            moneyManager.SetDenominationCount(500, 3);    // 3 x ₱500 = ₱1,500
            moneyManager.SetDenominationCount(100, 5);    // 5 x ₱100 = ₱500
            moneyManager.SetDenominationCount(50, 10);    // 10 x ₱50 = ₱500
            moneyManager.SetDenominationCount(20, 20);    // 20 x ₱20 = ₱400
            moneyManager.SetDenominationCount(10, 30);    // 30 x ₱10 = ₱300
            moneyManager.SetDenominationCount(5, 40);     // 40 x ₱5 = ₱200
            moneyManager.SetDenominationCount(1, 100);    // 100 x ₱1 = ₱100
            
            decimal expectedTotal = 2000 + 1500 + 500 + 500 + 400 + 300 + 200 + 100; // ₱5,500
            decimal actualTotal = moneyManager.GetTotalAmount();
            
            Console.WriteLine($"Test 1 - Expected: ₱{expectedTotal:N2}, Actual: ₱{actualTotal:N2}");
            Console.WriteLine($"Test 1 Result: {(expectedTotal == actualTotal ? "PASS" : "FAIL")}");
            
            // Test case 2: Zero amounts
            moneyManager.SetDenominationCount(1000, 0);
            moneyManager.SetDenominationCount(500, 0);
            moneyManager.SetDenominationCount(200, 0);
            moneyManager.SetDenominationCount(100, 0);
            moneyManager.SetDenominationCount(50, 0);
            moneyManager.SetDenominationCount(20, 0);
            moneyManager.SetDenominationCount(10, 0);
            moneyManager.SetDenominationCount(5, 0);
            moneyManager.SetDenominationCount(1, 0);
            actualTotal = moneyManager.GetTotalAmount();
            Console.WriteLine($"Test 2 - Zero amounts: ₱{actualTotal:N2}");
            Console.WriteLine($"Test 2 Result: {(actualTotal == 0 ? "PASS" : "FAIL")}");
            
            // Test case 3: Single denomination
            moneyManager.SetDenominationCount(1000, 1);
            actualTotal = moneyManager.GetTotalAmount();
            Console.WriteLine($"Test 3 - Single ₱1,000 bill: ₱{actualTotal:N2}");
            Console.WriteLine($"Test 3 Result: {(actualTotal == 1000 ? "PASS" : "FAIL")}");
            
            Console.WriteLine("Money Manager tests completed!");
        }
    }
}
