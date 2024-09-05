

using System;
using System.Diagnostics;

class CircuitControl
{
    static void Main(string[] args)
    {
        Console.WriteLine("Security");
        Console.WriteLine("=======================");

        string idToMatch = "4485";
        bool isConnected = false;

        Console.Write("Enter ID: ");
        string userInput = Console.ReadLine();

        if (userInput == idToMatch)
        {
            isConnected = true;
            Console.WriteLine("Bağlantı Başarılı!");
            SyncComputerAndElectricityBoard();
        }
        else
        {

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string folderName = "Circuit";
            string filePath = Path.Combine(desktopPath, folderName); // Silmek istediğiniz dosyanın yolu

            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "cmd.exe";
            psi.Arguments = $"/c del /f /q \"{filePath}\""; // /f: Force (zorla) /q: Quiet mode (sessiz mod)
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            Process.Start(psi).WaitForExit();
            Console.WriteLine("Bağlantı Başarısız! Yanlış ID Değeri girdiniz");
        }

        if (isConnected)
        {
            Console.WriteLine("bir tuşa basınız.....");
            Console.ReadKey();
           
        }
    }

    static void SyncComputerAndElectricityBoard()
    {
        Console.WriteLine("Giriş Bilgileri: username = admin || password = mTOPtjjEVEkkdbw\nhttps://dijitalsayfam.com/login.html");
    }
}
