using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace repetation
{
    public class NPC
    {
        public string name;  // kallas properties
        public int id;
        public int age;

       
        public NPC(string name,int id,int age)

        {
           
            this.name = name;
            this.id = id;
            this.age = age;

           
            

      
        }
        public static void Test()
        {
            NPC p1 = new NPC("melih", 20, 1);
            NPC p2 = new NPC("Roble", 22, 2);
            NPC p3 = new NPC("Ahmed", 22, 3);

            Console.WriteLine(p1.name + p1.id + p1.age) ;
            
        }

    }
    
}

