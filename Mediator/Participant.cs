using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeWithDP.Mediator
{
    public class Participant
    {
        private Chatroom _chatroom;
        private string _name;

        public Participant(string name)
        {
            _name = name;
        }

        public string Name
        {
            get { return _name; }
        }

        public Chatroom Chatroom
        {
            get { return _chatroom; }
            set { _chatroom = value; }
        }

        public void Send(string to, string message)
        {
            _chatroom.Send(_name, to, message);
        }

        // Receives message from given participant

        public virtual void Receive(
          string from, string message)
        {
            Console.WriteLine("{0} to {1}: '{2}'",
              from, Name, message);
        }
    }
}
