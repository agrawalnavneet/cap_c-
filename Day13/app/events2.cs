using System;
using System.Threading;

namespace CallbackDemo
{

    public delegate void DownloadFinishedHandler(string fileName);

    class FileDownloader
    {

        public void DownloadFile(string name, DownloadFinishedHandler callback)
        {
            Console.WriteLine($"Starting download: {name}...");
            Thread.Sleep(2000); 
            
            Console.WriteLine($"{name} download complete.");

      
            if (callback != null)
            {
                callback(name); 
            }
        }
    }

    class Program
    {

        static void DisplayNotification(string file)
        {
            Console.WriteLine($"NOTIFICATION: You can now open {file}.");
        }

        static void Main()
        {
            FileDownloader downloader = new FileDownloader();
            downloader.DownloadFile("Presentation.pdf", DisplayNotification);
        }
    }
}