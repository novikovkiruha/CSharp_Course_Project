using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp_Course_Project
{
    public delegate void SomeDelegate();

    public class EventClass
    {
        public event SomeDelegate SomeEvent;

        public void OnSomeEvent()
        {
            SomeEvent();
        }
    }

    public class Handler1
    {
        public static void PrintText()
        {
            Console.WriteLine("Handler1");
        }
    }

    public class Handler2
    {
        public static void PrintText()
        {
            Console.WriteLine("Handler2");
        }
    }

    public class MailMessagesEventArgs : EventArgs
    {
        public string From { get; }

        public string To { get; }

        public string Text { get; }

        public MailMessagesEventArgs(string from, string to, string text)
        {
            this.From = from;
            this.To = to;
            this.Text = text;
        }
    }

    public class Messanger
    {
        public delegate void MailDelegate(object sender, MailMessagesEventArgs args);

        public event MailDelegate NewMailSend;

        protected virtual void OnNewMailSend(MailMessagesEventArgs args)
        {
            NewMailSend(this, args);
        }

        public void SendNewMail(string from, string to, string text)
        {
            MailMessagesEventArgs args = new MailMessagesEventArgs(from, to, text);
            OnNewMailSend(args);
        }
    }

    public class Fax
    {
        private readonly Messanger messanger;

        public Fax(Messanger messanger)
        {
            this.messanger = messanger;
            this.messanger.NewMailSend += FaxMessage;
        }

        public void FaxMessage(object sender, MailMessagesEventArgs args)
        {
            Console.WriteLine($"From: {args.From}{Environment.NewLine}" +
                $"To: {args.To}{Environment.NewLine}" +
                $"Text: {args.Text}");
        }
    }

    public class Executer
    {
        public void Execute()
        {
            var someEvent = new EventClass();
            someEvent.SomeEvent += new SomeDelegate(Handler1.PrintText);
            someEvent.SomeEvent += Handler2.PrintText;
            someEvent.SomeEvent += () => Console.WriteLine("Lambda");

            for (int i = 0; i < 100; i++)
            {
                if (i % 5 == 0)
                {
                    someEvent.OnSomeEvent();
                }

                if (i == 10)
                {
                    someEvent.SomeEvent -= Handler2.PrintText;
                }

                Thread.Sleep(1000);
            }
        }

        public void SendMailMessage()
        {
            var messanger = new Messanger();
            var fax = new Fax(messanger);
            messanger.SendNewMail("from", "to", "some text");
        }
    }
}
