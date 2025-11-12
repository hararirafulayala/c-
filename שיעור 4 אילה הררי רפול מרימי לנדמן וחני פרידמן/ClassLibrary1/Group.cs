using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Group<T, T2> : IList<T>
    {
       /// <summary>
       /// אנחנו לא יודעים מה זה עושה
       /// </summary>
        private T? n;
        private int maxOfMembers=1;

        public T2 Teacher {  get; set; }
        public List<T> Members { get; set; } = new();
        /// <summary>
        /// 
        /// </summary>
        public int MaxOfMembers
        {
            get => maxOfMembers;
            set { if (value > 0) maxOfMembers = value; }
        }
        public int MinOfMembers { get; set; }
        public DateTime date { get; set; }
       //1
        public int Count { get => Members.Count;}
        //2
        public T this[int index]
        {
            get => Members[index];
           }
        //3
        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"> הערך שרוצים להוסיף</param>
        /// <exception cref="Exception">זורק שגיאה כשאין מקום בקבוצה</exception>
        public void Add(T item)
        {
            if (Members.Count < MaxOfMembers)
                Members.Add(item);
            else
                throw new Exception("אין מקום בקבוצה");
        }
        //4
        public void Clear()
        {
            Members.Clear();
        }
        //5

        public void RemoveAt(int index)
        {
            Members[index] = n;//?


        }
        public bool IsReadOnly => throw new NotImplementedException();

        T IList<T>.this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
