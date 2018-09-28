﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEventsAsync
{
    public delegate void LinkToEventHandler1(int i); // here event generate so malestudent cath event 
   

    class MaleStudent // this is the class receiving and handling the events
    {
        string name;
        int Marks;

        public MaleStudent(string nameArg, int marks) // this is use for initalize the variable like (name and marks)
        {
            name = nameArg;
            Marks = marks;
        }
        // event handling function (every time this class receive event and call this method)
        //This is a simple function that accepts nothing and returns nothing
        public void MyActionItem(int i) // this class is event handling so i m making class has an event Handling function
        {
            if (i == 1)
                System.Console.WriteLine("{0} Got Admission. He must pay fees", name);
            else
                System.Console.WriteLine(
                  "{0} did not Get Admission. He must lookout for other college", name);
        }
        public int GetMarks()
        {
            return Marks;
        }
    }

    

    class EventGeneratorClass1  // generates events
    {
        //Now EventGeneratorClass1 has declared an event . 
        
        public static event LinkToEventHandler1 AdmissionDeniedEvt;
        public static event LinkToEventHandler1 AdmissionGrantedEvt;

        public static void Main()
        {
            Console.WriteLine("Enter number how many data u want to enter ");
            int n = Convert.ToInt32(Console.ReadLine());
            MaleStudent[] Tom = new MaleStudent[n]; // we r creating object bcz this clas send event to MaleStudent
            for (int i = 0; i < Tom.Length; i++)
            {
                Console.WriteLine("Enter student name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter marks ");
                int m = Convert.ToInt32(Console.ReadLine());
                Tom[i] = new MaleStudent(name, m);
            }
            
            for (int i = 0; i < Tom.Length; i++)
            {
                if (Tom[i].GetMarks() >= 90)
                    AdmissionGrantedEvt += new LinkToEventHandler1(Tom[i].MyActionItem);
                else
                    AdmissionDeniedEvt += new LinkToEventHandler1(Tom[i].MyActionItem);
            }
            
            SendEvent();//So let's have a function by the name SendEvent()
            Console.ReadLine();
        }

        public static void SendEvent()
        {
            if (AdmissionGrantedEvt != null) // if it is not null then send event to student through 
            {                                    //  AdmissionDeniedEvt += new LinkToEventHandler1(Tom[i].MyActionItem);
                AdmissionGrantedEvt(1);
            }

            if (AdmissionDeniedEvt != null)
            {
                AdmissionDeniedEvt(0);
            }
            
        }
    }
}
/*The EventGeneratorClass1 will throw events in the open space. 
 * The MaleStudent1 class will catch the events.
 * The link between the events generated by the EventGeneratorClass and 
 * the event handler belonging to the client class is established by the delegate that has the signature of the event handler*/