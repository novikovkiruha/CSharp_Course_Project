namespace practice_06._15._2019_generics.Task3_LinkedList
{
    public class LinkedList<T>
    {
        private Node<T> head;

        private Node<T> tail;

        private int count;

        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);

            if (this.head == null)
                this.head = node;
            else
                this.tail.Next = node;

            this.tail = node;
            this.count++;
        }

        public bool Remove(T data)
        {
            Node<T> current = this.head;

            Node<T> previous = null;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;

                        if (current.Next == null)
                            this.tail = previous;
                    }
                    else
                    {
                        this.head = this.head.Next;

                        if (this.head == null)
                            this.tail = null;
                    }
                    this.count--;
                    return true;
                }

                previous = current;
                current = current.Next;
            }
            return false;
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public bool IsEmpty
        {
            get
            {
                return this.count == 0;
            }
        }

        public void Clear()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }

        public bool Contains(T data)
        {
            Node<T> current = this.head;

            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }

            return false;
        }
    }
}
