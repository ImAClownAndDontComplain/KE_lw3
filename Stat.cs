using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Numerics;

namespace lw3
{
    class Question
    {
        public Question(string n, string a1, string a2)
        {
            name = n;
            ans1 = a1;
            ans2 = a2;
        }
        public string name;
        public string ans1;
        public string ans2;
        
    }

    class Result
    {
        public Result(string n, string l, string p)
        {
            name = n;
            string des = n + ".txt";
            if (name == "IZONE") name = "IZ*ONE";
            StreamReader sr = new StreamReader(des);
            descr = sr.ReadToEnd();
            sr.Close();
            link = l;
            path = p;
        }
        public string name;
        public string descr;
        public string link;
        public string path;
    }

    class Prop
    {
        public Prop(int a, Question q)
        {
            this.ans = a;
            this.ques = q;
        }
        public int ans;
        public Question ques;
    }
    class Group
    {
        public List<Prop> props;
        public Group(List<Prop> props, Result r)
        {
            this.props = props;
            res = r;

        }
        public Result res;
    }
}
