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
        public Result(string n)
        {
            name = n;
        }
        public string name;
        public string descr;
        public string link1;
        public string link2;
        public string path;
    }

    class Prop
    {
        public Prop(string n, int a, Question q)
        {
            this.name = n;
            this.ans = a;
            this.ques = q;
        }
        public Prop(Prop p)
        {
            this.name = p.name;
            this.ans = p.ans;
            this.ques = p.ques;
        }
        public string name;
        public int ans;
        public Question ques;
    }
    class Group
    {
        public List<Prop> props;
        public Group(List<Prop> props, string s)
        {
            this.props = props;
            setres(s);

        }
        public Result res;

        public void setres(string s)
        {
            res = new Result(s);
        }
    }
}
