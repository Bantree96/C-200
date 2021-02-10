using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A096_LinkedList
{
    class Node
    {
        // internal은 같은 어셈블리 내부에서는 public 외부에서는 private와 같은 역할을 한다.
        // 어셈블리란 exe나 dll처럼 배포, 버전 관리 및 보안에 사용하기 위해 부분적으로 컴파일 된 코드 라이브러리
        internal int data;
        internal Node next; // Node형 필드인 next는 리스트에서 다음 번 노드의 레퍼런스
        public Node(int data) // 생성자
        {
            this.data = data;
            next = null;
        }
    }

    class LinkedList
    {
        Node head;

        // 리스트의 맨앞에 노드를 추가
        internal void InsertFront(int data)
        {
            Node node = new Node(data);
            node.next = head;
            head = node;
        }

        // 리스트의 맨뒤에 노드를 추가
        internal void InsertLast(int data)
        {
            Node node = new Node(data);
            if(head == null)
            {
                head = node;
                return;
            }
            Node lastNode = GetLastNode();
            lastNode.next = node;
        }

        // 리스트의 맨뒤에 있는 노드의 레퍼런스를 리턴
        internal Node GetLastNode()
        {
            Node temp = head;
            while(temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        // prev 뒤에 data를 갖는 노드 삽입하기
        internal void InsertAfter(int prev, int data)
        {
            Node prevNode = null;

            // find prev
            for (Node temp = head; temp != null; temp = temp.next)
                if (temp.data == prev)
                    prevNode = temp;

            if(prevNode == null)
            {
                Console.WriteLine("{0} data is not in the list");
                return;
            }
            Node node = new Node(data);
            node.next = prevNode.next;
            prevNode.next = node;
        }

        // key값을 저장하고 있는 노드 삭제하기
        internal void DeleteNode(int key)
        {
            Node temp = head;
            Node prev = null;
            
            // head가 찾는 값이면
            if (temp != null && temp.data == key)
            {
                head = temp.next;
                return;
            }
            
            while(temp != null && temp.data != key)
            {
                prev = temp;
                temp = temp.next;
            }
            // 끝까지 찾는 값이 없으면
            if(temp == null)
            {
                return;
            }
            prev.next = temp.next;
        }

        // 리스트를 거꾸로 만든다.
        internal void Reverse()
        {
            Node prev = null;
            Node current = head;
            Node temp = null;
            while(current != null)
            {
                temp = current.next;
                current.next = prev;
                prev = current;
                current = temp;
            }
            head = prev;
        }

        // 리스트를 처음부터 끝까지 출력
        internal void Print()
        {
            for (Node node = head; node != null; node = node.next)
                Console.Write(node.data + " -> ");
            Console.WriteLine();
        }
    }
}
