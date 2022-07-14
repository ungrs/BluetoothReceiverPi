using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSwash;
using System.Collections.ObjectModel;

namespace BluetoothReceiverPi
{
    class Program
    {
        /*
        private readonly IReceiverService _receiverService;
        private string _data;
        private bool _isStarEnabled;
        private string _status;
        */

        public static string Data = "..";
        private static ObservableCollection<string> mOC;
        private static StringBuilder mLog = new StringBuilder();
        static void Main(string[] args)
        {
            /*
            IReceiverService _receiverService = new ReceiverService();
            bool IsStarEnabled = true;
            string Status = "..";
            // _receiverService.Start(SetData);
            IsStarEnabled = false;
            Data = "Can receive data.";
            */

            mOC = new ObservableCollection<string>();

            var xObserved = new ObservedCollection<string>(mOC);
            xObserved.OnItemAdded += Observed_OnItemAdded;

            ChangeOC();

            Console.WriteLine(mLog);
        }

        static void Change1()
        {
            mOC.Add("One");
            mOC.Add("Two");
        }
        static void ChangeOC()
        {
            mOC.Add("One-11");
            mOC.Add("Two-22");
        }
        public static void SetData(string data)
        {
            Data = data;
        }
        static void Observed_OnItemAdded(ObservableCollection<string> aSender, int aIndex, string aItem)
        {
            /*
            mLog.AppendLine("  Added @ " + aIndex);
            mLog.AppendLine("  " + aItem);
            mLog.AppendLine();
            */
            mLog.AppendLine(aItem + ", ");
            Console.WriteLine("OC collection added triggered");
            // Console.WriteLine(mLog);
        }
    }
}
