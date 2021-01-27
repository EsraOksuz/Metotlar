using System;
using System.Collections.Generic;
using System.Text;

namespace HW
{
    class MyDictionary<K,V>
    {
        K[] ids;
        V[] students;
        K[] tempId;
        V[] tempStudents;

        public MyDictionary()
        {
            ids = new K[0];
            students = new V[0];
            tempId = new K[0];
            tempStudents = new V[0];
        }

        public void Add(K id, V student)
        {
            tempId = ids;
            tempStudents = students;

            ids = new K[ids.Length + 1];
            students = new V[students.Length + 1];

            for (int i = 0; i < tempStudents.Length; i++)
            {
                ids[i] = tempId[i];
                students[i] = tempStudents[i];
            }


            ids[ids.Length - 1] = id;
            students[students.Length - 1] = student;

        }

        public void ShowAll()
        {
            for (int i = 0; i < ids.Length; i++)
            {
                Console.WriteLine(ids[i] + " = " + students[i]);
            }
        }
    }
}
