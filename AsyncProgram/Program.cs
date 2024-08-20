// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

// Process.Start("notepad.exe", "C:\\Users\\srr00\\Documents\\Utvikling\\Backend\\Udemy\\Multithreading_and_Asynchronous_programming\\helloworld.txt");

internal class Program
{
    private static void Main(string[] args)
    {
        Thread t1 = new (() => Print(false));
        t1.Start();

        Print(true);

        Console.Read();
    }

    private static void Print(bool isEven) {
        Console.WriteLine($"Current Thread ID: {Thread.CurrentThread.ManagedThreadId}"); 
        if (isEven) {
            for (int i = 0; i < 100; i++) {
                if (i % 2 == 0) {
                    Console.WriteLine(i);
                }
            }
        } else {
            for (int i = 0; i < 100; i++) {
                if (i % 2 != 0) {
                    Console.WriteLine(i);
                }
            }
        }
        
    }

     private static void PrintOdd() {
        for (int i = 0; i < 100; i++) {
            if (i % 2 != 0) {
                Console.WriteLine(i);
            }
        }
    }

    private static void AllProcesses() {
        var processes = Process.GetProcesses();
        foreach (var process in processes) {
            if (process.ProcessName == " notepad") {
                process.Kill();
            }
        }
    }
}