using System;
namespace Study_Queue
{
	public class MyQueue<T>
	{
		private T[] elements;
		private int front, rear;
		private const int DEFAULT_SIZE = 10;

		public MyQueue()
		{
			elements = new T[DEFAULT_SIZE];
            front = rear = -1;
		}

		public MyQueue(int size)
		{
			elements = new T[size];
            front = rear = -1;
        }

		public void EnQueue(T item)
		{
			if (rear == elements.Length - 1)
			{
				Console.WriteLine("Queue overflow");
				return;
			}
			if (front == -1)
				front = 0;

			elements[++rear] = item;
		}

		public T DeQueue()
		{
			if (front == -1 || front > rear)
			{
                Console.WriteLine("Queue underflow");
                // default는 각 타입의 기본값을 반환하게한다.
                return default(T);
            }

			T item = elements[front];

			for (int i = 0; i < rear; i++)
			{
				elements[i] = elements[i + 1];
			}
			rear--;

            return item;
		}

		public void Print()
		{
			if (front == -1 || front > rear)
			{
				Console.WriteLine("Queue is empty");
				return;
			}

			for (int i = 0; i <= rear; i++)
			{
				Console.Write($"{elements[i]} ");
			}
			Console.WriteLine("");
		}

    }
}

