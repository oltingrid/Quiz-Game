using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Quiz_project
{
    class questions
    {
        string q;
        string a, b, c, d;
        string r;
        string dom;
        string poza;
        public questions() { }

        public questions(string v) {
            char[] delimitator = { '*' };
            String[] cuvant = v.Split(delimitator);
            q = cuvant[0];
            a = cuvant[1];
            b = cuvant[2];
            c = cuvant[3];
            d = cuvant[4];
            r = cuvant[5];
            dom = cuvant[6];
           poza = cuvant[7];

        }
        public string Q
        {
            get
            { return q; }


        }
        public string  A
        {
            get
            { return a; }


        }
        public string B
        {
            get
            { return b; }


        }
        public string C
        {
            get
            { return c; }


        }
        public string D
        {
            get
            { return d; }


        }
        public string R
        {
            get
            { return r; }


        }
        public string DOM
        {
            get
            { return dom; }


        }

        public string POZA
        {
            get
            { return poza; }


        }
    }
}
