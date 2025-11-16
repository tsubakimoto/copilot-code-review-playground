using System;
using System.Collections.Generic;
using System.Text;

namespace NamingApp
{
    internal class vehicle
    {
        string name { get; set; }

        int capacity { get; set; }

        int passengers { get; set; }

        bool isRunning { get; set; }

        public vehicle()
        {
            passengers = 0;
            isRunning = false;
        }

        public vehicle(string name, int capacity) : this()
        {
            this.name = name;
            this.capacity = capacity;
        }

        void ride()
        {
            string Message = "Riding the vehicle";
            Console.WriteLine(Message);
            passengers++;
        }

        void start()
        {
            string Message = "Starting the vehicle";
            Console.WriteLine(Message);
            isRunning = true;
        }

        void stop()
        {
            string Message = "Stopping the vehicle";
            Console.WriteLine(Message);
            isRunning = false;
        }
    }
}
