using System;
using System.Collections.Generic;

namespace C_Review
{
    class Program
    {
        static void Main(string[] args) {
            int[] myArray = new int[5]{3, 4, 5, 6, 7};
            myArray[0] = 2; //Update value by index
            Console.WriteLine( myArray[0]);

            for ( int i = 0; i < 5; i++){
                Console.WriteLine("Array Index :"+i+"| Array Value: "+ myArray[i]);
            }

            // Let's try a while loop
            int n = 0;// We need to set up an iterator in most cases.
            while ( n < 5 ){
                Console.WriteLine("Array Index :"+n+"| Array Value: "+ myArray[n]);
                //n = n + 2;
                n += 2;// Don't forget to iterate or this might be endless!
            }

            //Let's try a foreach They stop themselves at the end of the collection.
            foreach(var i in myArray){
                Console.WriteLine("Current foreach value of the Array is: "+ i);
            }

            // Let's collect some user input

            Console.WriteLine ( "Please enter your name: " ); // It is a food idea to ask a user so they know what you want
            string userinput = Console.ReadLine (); // Store their input, or it will be lost forever
            Console.WriteLine( "Thank you, {0}! ", userinput );

            myMethod();

        }

        //let's try making a method
        static void myMethod(){
            int x = 35;
            Console.WriteLine("Hello World! " +x);

            if (x < 30){
                Console.WriteLine("X is less than thirty");
            } else if (x == 30){
                Console.WriteLine("X is thirty");
            } else {
            Console.WriteLine("X is greater than thirty");
         }

         int a = 3;
         Console.WriteLine("In Case Statement");
         switch (a) {
            
             case 1 :
                 Console.WriteLine("Value is 1!");
                 break;
             case 2 : 
                 Console.WriteLine("Value is 2!");
                 break;
             case 3 :
                 Console.WriteLine("Value is 3!");
                 break;
             default :
                 Console.WriteLine("Wetin you enter!!???");
                 break;

         }

         string b = "Yes";
         Console.WriteLine("In Case Statement with String");
             switch (b) {
            
             case "Yes" :
                 Console.WriteLine("Value is 1!");
                 break;
             case "No" : 
                 Console.WriteLine("Value is 2!");
                 break;
             case "Maybe" :
                 Console.WriteLine("Value is 3!");
                 break;
             default :
                 Console.WriteLine("Wetin you enter!!???");
                 break;
         }
       }

    
    }
}

        
  
