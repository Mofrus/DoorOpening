using System;

namespace DoorOpening
{
    internal class Program
    {

        private DoorController _doorController;
        
        public void init(string[] args)
        {

            _doorController = new DoorController();
            
            _doorController.initDoorList();
            _doorController.DoorStateChange();
            _doorController.WriteResult();

            Console.ReadKey();
        }
        
        public static void Main(string[] args)
        {

            new Program().init(args);
            
        }
    }
}