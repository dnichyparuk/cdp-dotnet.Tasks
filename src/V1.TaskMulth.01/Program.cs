﻿using System;
using System.Threading.Tasks;

namespace V1.TaskMulth._01
{
    /// <summary>
    /// Write a program, which creates an array of 100 Tasks, runs them and wait all of them are not finished. 
    /// Each Task should iterate from 1 to 1000 and print into the console the following string: “Task #0 – {iteration number}”.
    /// </summary>
    class Program
    {
        static void Main()
        {
            var tasksArray = new Task[100];

            for (var i = 0; i < tasksArray.Length; i++)
            {
                var taskId = i;
                tasksArray[i] = CreateTask(taskId);
            }

            Console.ReadLine();
        }

        private static Task CreateTask(int taskId)
        {
            throw new NotImplementedException();
        }
    }
}
