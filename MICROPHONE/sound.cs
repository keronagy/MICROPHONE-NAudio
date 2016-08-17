using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MICROPHONE
{
    class sound
    {

        private string name;
        private string path;

        public sound(string path, string name)
        {
            this.name = name;
            this.path = path;
        }


        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Path
        {
            get { return this.path; }
            set { this.path = value; }
        }

        
    }


    
}
    

