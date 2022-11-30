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

    class Goto
    {
        public Goto(Question qc,Goto qp, Goto qn1, Goto gn2, Result r)
        {
            qn = qc;
            previous = qp;
            next1 = qn1;
            next2 = gn2;
            res = r;
        }
        //public void next()
        //{
        //    if (previous.qn.chosen == 1) this = next1;
        //    else this = next2;
        //}
        public Question qn;
        public Goto previous;
        public Goto next1;
        public Goto next2;
        public Result res;
    }

    class Result
    {
        public Result(string n, string l, string p)
        {
            name = n;
            string des = n + ".txt";
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
        public Prop(Prop p)
        {
            this.ans = p.ans;
            this.ques = p.ques;
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
