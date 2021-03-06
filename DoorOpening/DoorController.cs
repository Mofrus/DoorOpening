using System;
using System.Collections.Generic;
using System.Linq;

namespace DoorOpening
{
    public class DoorController
    {
        private List<Door> DoorList;

        public void initDoorList() //Adds objects to a list
        {
            DoorList = new List<Door>();
            for (int i = 0; i < 100; i++) DoorList.Add(new Door());
        }

        public void DoorStateChange() //Changes the state of specific doors
        {
            for (int loopN = 1; loopN <= 100; loopN++)
            {
                for (int doorN = 1; doorN <= DoorList.Count; doorN++)
                {
                    if (doorN % loopN == 0) DoorList[doorN - 1].Opened = !DoorList[doorN - 1].Opened;
                }
            }
        }

        public void WriteResult() //Writes out all indexes of opened doors
        {
            string output = "";
            for (int i = 0; i < DoorList.Count; i++)
            {
                if (DoorList[i].Opened) output += i + ",";
            }
            Console.WriteLine(output);
        }
    }
}