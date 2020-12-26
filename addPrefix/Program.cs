using System;
using System.Windows.Forms;

namespace addPrefix
{
    static class Program
    {
        //This program add prefix to all files in a current directory.
        //This can be useful for storing media files on a mobile device.
        //You can have several different sets of media context like: 
        //set1 = 01.mp3, 02.mp3... ; set2= 01.mp3, 02.mp3... .
        //Before copying files from you desktop to mobile device input 
        //prefix(for example, author) for files and press "Add prefix" button.
        //So you will have set = author01.mp3, author02.mp3... .
        //In this case media player on your gadget will 
        //play the list of media files in desired consequence.


  [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
