using System;
using net_stack.model.exceptions;

namespace net_stack
{
    public class Node
    {
        public Object data;
        public Node nextNode;

        public Node()
        {
            data = null;
            nextNode = null;
        }
    }

    public class Stack
    {
        // Implement code
        Node head;
        Object _obj;

        public Stack()
        {
            head = null;
            _obj = null;
        }

        public bool IsEmpty()
        {
            // 1.) returns is empty equal to true
            // return true

            // 2.) returns is empty equal to false after push
            // return _obj == null;

            // 9.) Implement Linked list
            return head == null;
        }

        public void Push(Object obj)
        {
            // 2.) returns is empty equal to false after push
            // _obj = obj;

            var newNode = new Node();
            newNode.data = obj;
            newNode.nextNode = head;
            head = newNode;
        }

        public Object Peek()
        {
            // 3.) & 4.) returns null or most recently pushed value
            // return _obj;

            if (head == null)
            {
                return null;
            }

            return head.data;
        }

        public Object Pop()
        {
            if (IsEmpty())
            {
                // 5.) Pop throws exception is stack is empty
                throw new EmptyStackException("The stack is empty.");
            }

            // 6.) Returns the most recently pushed value
            // return _obj;

            // 7.) Peek returns null after pop is called

            // 9.) Implement linked list
            var popped = head.data;
            head = head.nextNode;
            return popped;
        }

        public bool Contains(Object obj)
        {
            if (IsEmpty())
            {
                throw new EmptyStackException("The stack is empty.");
            }

            Node temp = head;

            while (temp != null)
            {
                if (temp.data.Equals(obj))
                {
                    return true;
                }
                
                temp = temp.nextNode;
            }

            return false;
        }
    }
}
