using System;

namespace arc
{
    public struct Message
    {
        int time; int code; int from; int to; int tok; int pay;
    }
    public class Node
    {
        public Node(int self, int[] neigh) {

        }
        public Message[] Process(Message[] msgs)
        {
            //receive inbound messages
            //process
            //returns outbound messages
        }
    }
    public class Arcs
    {
        string node_file = Console.ReadLine();

        // logical time clock
        //.priority queue for organising messages
        public static void Main()
        {
            Console.Write("Eeeey");
            // read and store configuration from stdin
            // initialise nodes
            // sends and receives messages on behalf of nodes,
            // adding required delays, and tracing
            //stop
        }
    }

}

