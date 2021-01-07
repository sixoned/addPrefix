using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addPrefix
{
    public class myFile
    {
       public string fileName {  get; private set; }
       public string creationDate { get; private set; }
       public string fileSize { get; private set; }
       

      public  myFile(string fileNameS, string creationDateS, string fileSizeS) {
            this.fileName = fileNameS;
            this.creationDate = creationDateS;
            this.fileSize = fileSizeS;
        }
    }
}
