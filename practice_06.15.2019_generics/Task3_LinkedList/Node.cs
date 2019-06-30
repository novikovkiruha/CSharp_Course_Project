namespace practice_06._15._2019_generics.Task3_LinkedList
{
    public class Node<T>
    {
        public T Data { get; set; }

        public Node<T> Next { get; set; }

        public Node(T data)
        {
            this.Data = data;
        }
    }
}
