


using System.Media;
using System.Threading;

namespace BlueBooter
{
    class Program
    {
        static void Main(string[] args)
        {
           
            SoundPlayer player1 = new
            SoundPlayer(@"C:\Windows\Media\Windows Logon.wav");
            player1.Play();
         
            Thread.Sleep(3000);
       
            
        }
    }
}