using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class Student
    {
        public Dictionary<string, int> assessments = new Dictionary<string, int>(5);
        private static int MAX_Subject = 3;
        private string name;
        private string surname;
        private int group;
       
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }

            set
            {
                surname = value;
            }
        }
       
        public int Group
        {
            get
            {
                return group;
            }

            set
            {
                group = value;
            }
        }
        
               
        public void Set(string key, int value)
        {
            if (assessments.ContainsKey(key))
            {
                assessments[key] = value;
            }
            else
            {
                assessments.Add(key, value);
            }
        }

        public int Get(string key)
        {
            int result = 0;

            if (assessments.ContainsKey(key))
            {
                result = assessments[key];
            }

            return result;
        }
        public void GetStudent()
        {
            Console.WriteLine("Name: {0} \n Surname: {1}  \n Group: {2} \n",
                name, surname,  group);

            foreach (KeyValuePair<string, int> kvp in assessments)
            {
                Console.WriteLine("Subject: {0}, Evaluation: {1} \n", kvp.Key, kvp.Value);
            }

        }
        public float GetSubjectSum()
        {
            float SubjectSum = 0;
            foreach (KeyValuePair<string, int> kvp in assessments)
            {
                SubjectSum += kvp.Value;
            }
            return SubjectSum / MAX_Subject;
        }
        public float GetSubjectSum(string Subject)
        {
            float SubjectSum = 0;
            foreach (KeyValuePair<string, int> kvp in assessments)
            {
                if (kvp.Key.Equals(Subject))
                    SubjectSum = kvp.Value;
                break;
            }
            return SubjectSum;
        }
    }
}
