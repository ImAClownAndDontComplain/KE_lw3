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

        static Prop bg = new Prop("boygroups", 1, gender);
        static Prop gg = new Prop("girlgroups", 2, gender);
        static Prop mmb = new Prop("many members boys", 1, numberm);
        static Prop lmb = new Prop("less members boys", 2, numberm);
        static Prop mmg = new Prop("many members girls", 1, numberf);
        static Prop lmg = new Prop("less members girls", 2, numberf);
        static Prop sv = new Prop("strong vocals", 1, voc);
        static Prop wv = new Prop("mediocre vocals", 2, voc);
        static Prop sd = new Prop("strong dancing", 1, dan);
        static Prop wd = new Prop("mediocre dancing", 2, dan);
        static Prop sr = new Prop("strong rapping", 1, rap);
        static Prop wr = new Prop("mediocre rapping", 2, rap);
        static Prop spr = new Prop("strong sp", 1, stpr);
        static Prop wpr = new Prop("mediocre weak sp", 2, stpr);
        static Prop vc = new Prop("var of conc", 1, variety);
        static Prop nvc = new Prop("no var of conc", 2, variety);

        static string s = "I highly recommend you checking out PURPLE KISS";
        static Group PK = new Group(new List<Prop>() { gg, lmg, sv, sd, sr},s);

        List<Group> groups = new List<Group>() { PK };

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
                i++;
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
            else while (true)
                {
                    while (j < DB.Count && groups[i].props[j] == DB[j]) j++;
                    if (j < DB.Count)
                    {
                        j = 0;
                        i++;
                    }
                    else if (j == DB.Count && j< groups[i].props.Count)
                    {
                        tb.Text = groups[i].props[j].ques.name;
                        bt1.Text = groups[i].props[j].ques.ans1;
                        bt2.Text = groups[i].props[j].ques.ans2;
                        break;
                    }
                    else
                    {
                        tb.Text = groups[i].res.name;
                        break;
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
    }
}