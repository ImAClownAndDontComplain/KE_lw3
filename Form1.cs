using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lw3
{
    public partial class Form1 : Form
    {
        Question cq = null;
        int ca = 0;
        Group cg = null;
        Prop cp = null;

        int i=0;
        int j=0;

        List<Prop> DB = new List<Prop>();

        public Form1()
        {
            InitializeComponent();
            DB.Clear();
            update();
            lb.LinkClicked += lb_LinkClicked;
        }

        const string genm = "Boy Groups";
        const string genf = "Girl Groups";

        const string nmg = "8 and more";
        const string nml = "7 and less";

        const string nfg = "7 and more";
        const string nfl = "6 and less";

        const string like = "I like it";
        const string dl = "I don't like it";

        const string want = "I want it";
        const string dc = "I don't care";

        const string cd = "Dark and mysterious";
        const string cc = "Cute and girly";

        const string gen = "Which groups do you prefer?";
        const string num = "How many members do you want to be in the group?";
        const string vocals = "Should the group have strong vocals?";
        const string dancing = "Should the group have strong dancing?";
        const string rapping = "Should the group have strong rapping?";
        const string conc = "Which concept do you like more?";
        const string var = "Do you want the group to have various concepts?";
        const string sp = "Do you want the group to have amazing stage presence?";
        const string nm = "Do you like noise music?";
        const string em = "Do you like experimental music?";
        const string y2k = "Do you like Y2K style?";

        static Question gender = new Question(gen, genm, genf);
        static Question numberm = new Question(num, nmg, nml);
        static Question numberf = new Question(num, nfg, nfl);

        static Question voc = new Question(vocals, want, dc);
        static Question dan = new Question(dancing, want, dc);
        static Question rap = new Question(rapping, want, dc);
        static Question concept = new Question(conc, cd, cc);
        static Question variety = new Question(var, want, dc);
        static Question stpr = new Question(sp, want, dc);
        static Question y2000 = new Question(y2k, like, dl);

        static Prop bg = new Prop(1, gender);
        static Prop gg = new Prop(2, gender);
        static Prop mmb = new Prop(1, numberm);
        static Prop lmb = new Prop(2, numberm);
        static Prop mmg = new Prop(1, numberf);
        static Prop lmg = new Prop(2, numberf);
        static Prop sv = new Prop(1, voc);
        static Prop wv = new Prop(2, voc);
        static Prop sd = new Prop(1, dan);
        static Prop wd = new Prop(2, dan);
        static Prop sr = new Prop(1, rap);
        static Prop wr = new Prop(2, rap);
        static Prop spr = new Prop(1, stpr);
        static Prop wpr = new Prop(2, stpr);
        static Prop vc = new Prop(1, variety);
        static Prop nvc = new Prop(2, variety);
        static Prop yk = new Prop(1, y2000);

        //private static Prop findanother(Prop p)
        //{
        //    switch (p.)
        //    {
        //        case sv: return wv;
        //        case 
        //    }
        //}

        static Result pk = new Result("PURPLE KISS", "https://www.youtube.com/watch?v=jM_1dLjqtlo&ab_channel=PURPLEKISS", "PURPLE KISS.jpg");
        static Group PK = new Group(new List<Prop>() { gg, lmg, sv, sd, sr},pk);

        static Result nj = new Result("NewJeans", "https://www.youtube.com/watch?v=js1CtxSY38I&ab_channel=HYBELABELS", "NewJeans.jpg");
        static Group NJ = new Group(new List<Prop>() { gg, lmg, sv, sd, wr, yk }, nj);


        List<Group> groups = new List<Group>() { PK, NJ };

        private void checkans()
        {
            if (groups[i].props[j].ans == ca)
            {
                DB.Add(groups[i].props[j]);
                j++;
            }

            else
            {
                Prop p = new Prop(groups[i].props[j]);
                p.ans = ca;
                DB.Add(p);
                j = 0;
            }
            update();
        }
        private void update()
        {
            if (DB.Count == 0)
            {
                tb.Text = groups[i].props[j].ques.name;
                bt1.Text = groups[i].props[j].ques.ans1;
                bt2.Text = groups[i].props[j].ques.ans2;
            }
            else
            {
                while (true)
                {
                    while (j < DB.Count && groups[i].props[j].ques.name == DB[j].ques.name && groups[i].props[j].ans == DB[j].ans) j++;
                    if (j < DB.Count)
                    {
                        j = 0;
                        i++;
                    }
                    else if (j == DB.Count && j < groups[i].props.Count)
                    {
                        tb.Text = groups[i].props[j].ques.name;
                        bt1.Text = groups[i].props[j].ques.ans1;
                        bt2.Text = groups[i].props[j].ques.ans2;
                        break;
                    }
                    else
                    {
                        showres();
                        break;
                    }
                }
            }
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            ca = 1;
            checkans();
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            ca = 2;
            checkans();
        }

        public void showres()
        {
            tb.Text = groups[i].res.name;
            text.Text = groups[i].res.descr;
            lb.Text = groups[i].res.link;
            pic.Image = Image.FromFile(groups[i].res.path);
            bt1.Hide();
            bt2.Hide();
            text.Show();
            lb.Show();
            pic.Show();
            lb.Enabled = true;
        }

        private void restart_Click(object sender, EventArgs e)
        {
            i = 0;
            j = 0;
            DB.Clear();
            bt1.Show();
            bt2.Show();
            lb.Hide();
            text.Hide();
            pic.Hide();
            update();
        }

        private void lb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open the link that was clicked.");
            }
        }

        private void VisitLink()
        {
            lb.LinkVisited = true;
            string link = "/c start " + lb.Text;
            System.Diagnostics.Process.Start("cmd",link);
        }

        
    }
}