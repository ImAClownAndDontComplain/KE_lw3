using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lw3
{
    public partial class Form1 : Form
    {
        int tbq = 394;
        int tba = 41;

        int ca;

        int i = 0;
        int j = 0;

        List<Prop> DB = new List<Prop>();

        public Form1()
        {
            InitializeComponent();
            DB.Clear();
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
        const string enm = "Do you like full english music?";
        const string isn = "Should the group have a lot of iconic songs?";
        const string su = "Would you like the group to have multiple subunits?";

        static Question gender = new Question(gen, genm, genf);
        static Question numberm = new Question(num, nmg, nml);
        static Question numberf = new Question(num, nfg, nfl);

        static Question voc = new Question(vocals, want, dc);
        static Question dan = new Question(dancing, want, dc);
        static Question rap = new Question(rapping, want, dc);
        static Question concept = new Question(conc, cc, cd);
        static Question variety = new Question(var, want, dc);
        static Question stpr = new Question(sp, want, dc);
        static Question y2000 = new Question(y2k, like, dl);
        static Question exm = new Question(em, like, dl);
        static Question nom = new Question(nm, like, dl);
        static Question engm = new Question(enm, like, dl);
        static Question isngs = new Question(isn, want, dc);
        static Question sun = new Question(su, like, dl);

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
        static Prop nyk = new Prop(2, y2000);
        static Prop expm = new Prop(1, exm);
        static Prop noem = new Prop(2, exm);
        static Prop nomu = new Prop(1, nom);
        static Prop notnm = new Prop(2, nom);
        static Prop cuc = new Prop(1, concept);
        static Prop dac = new Prop(2, concept);
        static Prop yem = new Prop(1, engm);
        static Prop nem = new Prop(2, engm);
        static Prop yis = new Prop(1, isngs);
        static Prop nis = new Prop(2, isngs);
        static Prop ysu = new Prop(1, sun);
        static Prop nsu = new Prop(2, sun);


        static Result ou = new Result("ONEUS", "https://www.youtube.com/watch?v=XlqTPCEfiyA&ab_channel=ONEUS", "ONEUS.jpg");
        static Group OU = new Group(new List<Prop>() { bg, lmb, sv, sd, sr, vc }, ou);

        static Result jb = new Result("JUST B", "https://www.youtube.com/watch?v=gbCw_Jj6hDI&ab_channel=JUSTB", "JUST B.jpg");
        static Group JB = new Group(new List<Prop>() { bg, lmb, sv, sd, sr, nvc, nomu }, jb);

        static Result nd = new Result("NCT DREAM", "https://www.youtube.com/watch?v=oZP2h3WIzqk&ab_channel=SMTOWN", "NCT DREAM.jpg");
        static Group ND = new Group(new List<Prop>() { bg, lmb, sv, sd, sr, nvc, notnm }, nd);

        static Result gs = new Result("GOT7", "https://www.youtube.com/watch?v=IZ0oQ6nzKxo&ab_channel=GOT7", "GOT7.jpg");
        static Group GS = new Group(new List<Prop>() { bg, lmb, sv, sd, wr }, gs);

        static Result sn = new Result("SHINEE", "https://www.youtube.com/watch?v=p6OoY6xneI0&ab_channel=SMTOWN", "SHINEE.jpg");
        static Group SN = new Group(new List<Prop>() { bg, lmb, sv, wd }, sn);

        static Result bts = new Result("BTS", "https://www.youtube.com/watch?v=kXpOEzNZ8hQ&ab_channel=HYBELABELS", "BTS.jpeg");
        static Group BTS = new Group(new List<Prop>() { bg, lmb, wv, sd, yem, yis }, bts);

        static Result mx = new Result("MONSTA X", "https://www.youtube.com/watch?v=vaKVbKPQOqY&ab_channel=starshipTV", "MONSTA X.jpeg");
        static Group MX = new Group(new List<Prop>() { bg, lmb, wv, sd, yem, nis }, mx);

        static Result txt = new Result("TXT", "https://www.youtube.com/watch?v=Os_6c5j6YiQ&ab_channel=HYBELABELS", "TXT.jpg");
        static Group TXT = new Group(new List<Prop>() { bg, lmb, wv, sd, nem, vc }, txt);

        static Result enh = new Result("ENHYPEN", "https://www.youtube.com/watch?v=QMlNLo74mOw&ab_channel=HYBELABELS", "ENHYPEN.jpeg");
        static Group EN = new Group(new List<Prop>() { bg, lmb, wv, sd, nem, nvc }, enh);

        static Result blb = new Result("BLOCK B", "https://www.youtube.com/watch?v=NHglTopVlKQ&ab_channel=StoneMusicEntertainment", "BLOCK B.jpg");
        static Group BLB = new Group(new List<Prop>() { bg, lmb, wv, wd, vc }, blb);

        static Result bb = new Result("BIGBANG", "https://www.youtube.com/watch?v=eN5mG_yMDiM&ab_channel=BIGBANG", "BIGBANG.jpeg");
        static Group BB = new Group(new List<Prop>() { bg, lmb, wv, wd, nvc }, bb);

        static Result nct = new Result("NCT 127", "https://www.youtube.com/watch?v=FRilMXZqNhA&ab_channel=SMTOWN", "NCT 127.jpeg");
        static Group NCT = new Group(new List<Prop>() { bg, mmb, sv, nomu }, nct);
        
        static Result sj = new Result("SUPER JUNIOR", "https://www.youtube.com/watch?v=I02ULETFESI&ab_channel=SMTOWN", "SUPER JUNIOR.jpg");
        static Group SJ = new Group(new List<Prop>() { bg, mmb, sv, notnm, yis }, sj);
        
        static Result exo = new Result("EXO", "https://www.youtube.com/watch?v=2IkoKhr6Tss&ab_channel=SMTOWNl", "EXO.jpg");
        static Group EXO = new Group(new List<Prop>() { bg, mmb, sv, notnm, nis }, exo);
        
        static Result svt = new Result("SEVENTEEN", "https://www.youtube.com/watch?v=gRnuFC4Ualw&ab_channel=HYBELABELS", "SEVENTEEN.jpg");
        static Group SVT = new Group(new List<Prop>() { bg, mmb, wv, ysu }, svt);
        
        static Result az = new Result("ATEEZ", "https://www.youtube.com/watch?v=2HcVZm_4qAI&ab_channel=KQENTERTAINMENT", "ATEEZ.jpg");
        static Group AZ = new Group(new List<Prop>() { bg, mmb, wv, nsu, vc }, az);
        
        static Result sk = new Result("STRAY KIDS", "https://www.youtube.com/watch?v=jYSlpC6Ud2A&ab_channel=JYPEntertainment", "STRAY KIDS.jpg");
        static Group SK = new Group(new List<Prop>() { bg, mmb, wv, nsu, nvc }, sk);



        static Result pk = new Result("PURPLE KISS", "https://www.youtube.com/watch?v=jM_1dLjqtlo&ab_channel=PURPLEKISS", "PURPLE KISS.jpg");
        static Group PK = new Group(new List<Prop>() { gg, lmg, sv, sd, sr }, pk);

        static Result nj = new Result("NewJeans", "https://www.youtube.com/watch?v=js1CtxSY38I&ab_channel=HYBELABELS", "NewJeans.jpg");
        static Group NJ = new Group(new List<Prop>() { gg, lmg, sv, sd, wr, yk }, nj);

        static Result sc = new Result("STAYC", "https://www.youtube.com/watch?v=juQvizeZJFM&ab_channel=STAYC", "STAYC.jpg");
        static Group SC = new Group(new List<Prop>() { gg, lmg, sv, sd, wr, nyk }, sc);

        static Result ae = new Result("AESPA", "https://www.youtube.com/watch?v=dYRITmpFbJ4&ab_channel=SMTOWN", "AESPA.jpeg");
        static Group AE = new Group(new List<Prop>() { gg, lmg, sv, wd, expm }, ae);

        static Result rv = new Result("RED VELVET", "https://www.youtube.com/watch?v=Ut1OzEVUiM4&ab_channel=SMTOWN", "RED VELVET.jpg");
        static Group RV = new Group(new List<Prop>() { gg, lmg, sv, wd, noem, vc }, rv);

        static Result mm = new Result("MAMAMOO", "https://www.youtube.com/watch?v=Vz508O9NNTg&ab_channel=MAMAMOO", "MAMAMOO.jpg");
        static Group MM = new Group(new List<Prop>() { gg, lmg, sv, wd, noem, nvc }, mm);

        static Result eg = new Result("EVERGLOW", "https://www.youtube.com/watch?v=-2X-pL06628&ab_channel=StoneMusicEntertainment", "EVERGLOW.jpg");
        static Group EG = new Group(new List<Prop>() { gg, lmg, wv, sd, sr}, eg);

        static Result iz = new Result("ITZY", "https://www.youtube.com/watch?v=zugAhfd2r0g&ab_channel=JYPEntertainment", "ITZY.jpeg");
        static Group IZ = new Group(new List<Prop>() { gg, lmg, wv, sd, wr, nomu }, iz);

        static Result ls = new Result("LE SSERAFIM", "https://www.youtube.com/watch?v=pyf8cbqyfPs&ab_channel=HYBELABELS", "LE SSERAFIM.jpg");
        static Group LS = new Group(new List<Prop>() { gg, lmg, wv, sd, wr, notnm }, ls);
        
        static Result gi = new Result("(G)I-DLE", "https://www.youtube.com/watch?v=fCO7f0SmrDc&ab_channel=%28G%29I-DLE%28%EC%97%AC%EC%9E%90%29%EC%95%84%EC%9D%B4%EB%93%A4%28OfficialYouTubeChannel%29", "(G)I-DLE.jpg");
        static Group GI = new Group(new List<Prop>() { gg, lmg, wv, wd, sr, vc }, gi);

        static Result bp = new Result("BLACKPINK", "https://www.youtube.com/watch?v=POe9SOEKotk&ab_channel=BLACKPINK", "BLACKPINK.jpg");
        static Group BP = new Group(new List<Prop>() { gg, lmg, wv, wd, sr, nvc }, bp);

        static Result iv = new Result("IVE", "https://www.youtube.com/watch?v=F0B7HDiY-10&ab_channel=starshipTV", "IVE.jpg");
        static Group IV = new Group(new List<Prop>() { gg, lmg, wv, wd, wr}, iv);

        static Result bl = new Result("BILLLIE", "https://www.youtube.com/watch?v=z8Eu-HU0sWQ&ab_channel=Billlie", "BILLLIE.jpg");
        static Group BL = new Group(new List<Prop>() { gg, mmg, sv, sd, vc, spr }, bl);

        static Result ln = new Result("LOONA", "https://www.youtube.com/watch?v=SPYX2y4NzTU&ab_channel=loonatheworld", "LOONA.jpg");
        static Group LN = new Group(new List<Prop>() { gg, mmg, sv, sd, vc, wpr }, ln);

        static Result io = new Result("IZONE", "https://www.youtube.com/watch?v=G8GaQdW2wHc&ab_channel=StoneMusicEntertainment", "IZONE.jpg");
        static Group IO = new Group(new List<Prop>() { gg, mmg, sv, sd, nvc }, io);

        static Result sh = new Result("SNSD", "https://www.youtube.com/watch?v=Qpf26PtBXgo&ab_channel=SMTOWN", "SNSD.jpg");
        static Group GG = new Group(new List<Prop>() { gg, mmg, sv, wd}, sh);

        static Result tw = new Result("TWICE", "https://www.youtube.com/watch?v=k6jqx9kZgPM&ab_channel=JYPEntertainment", "TWICE.jpg");
        static Group TW = new Group(new List<Prop>() { gg, mmg, wv, cuc }, tw);

        static Result dct = new Result("DREAMCATCHER", "https://www.youtube.com/watch?v=jKrJBVLnRiM&ab_channel=Dreamcatcherofficial", "DREAMCATCHER.jpg");
        static Group DC = new Group(new List<Prop>() { gg, mmg, wv, dac }, dct);


        List<Group> groups = new List<Group>() { OU, JB, ND, GS, SN, BTS, MX, TXT, EN, BLB, BB, NCT, SJ, EXO, SVT, AZ, SK, PK, NJ, SC, AE, RV, MM, EG, IZ, LS, GI, BP, IV, BL, LN, IO, GG, TW, DC };

        private void checkans()
        {
            if (groups[i].props[j].ans == ca)
            {
                DB.Add(groups[i].props[j]);
                j++;
            }

            else
            {
                Prop p = new Prop(ca, groups[i].props[j].ques);
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
            tb.Left = tba;
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
            if (restart.Text == "RESTART")
            {
                i = 0;
                j = 0;
                tb.Hide();
                tb.Left = tbq;
                tb.Show();
                DB.Clear();
                bt1.Show();
                bt2.Show();
                pic.Hide();
                text.Hide();
                lb.Hide();
                update();
            }
            else
            {
                tb.Show();
                bt1.Show();
                bt2.Show();
                restart.Text = "RESTART";
                update();
            }
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