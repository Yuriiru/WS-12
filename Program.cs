using System;

    class EventDelegateClass
    {
        private string name; 

        public delegate void EventDelegate(string txt); 

        public EventDelegateClass(string name) 
        {
            this.name = name;
        }

        public event EventDelegate Event; 
        public void RaiseEvent() 
        {
            if (Event != null)
            {
                Event(name);
            }
        }
    }

class SeconClass
{
        private string text; 
        public SeconClass(string metodtext) 
        {
            text = metodtext;
        }
        public void show(string objname) 
        {
            Console.WriteLine("Объект, сгенерировавший событие: " + objname);
            Console.WriteLine("Сообщение: " + text);
        }
}

class Program
{
        static void Main()
        {
            EventDelegateClass odjectDC1 = new EventDelegateClass("OdjectDC1"); 
            EventDelegateClass odjectDC2 = new EventDelegateClass("OdjectDC2");

            SeconClass sCobject = new SeconClass("ObjectSC"); 

            odjectDC1.Event += sCobject.show;
            odjectDC2.Event += sCobject.show;

            odjectDC1.RaiseEvent();
            Console.WriteLine();

            odjectDC2.RaiseEvent();
            Console.WriteLine();
        }
}
 


