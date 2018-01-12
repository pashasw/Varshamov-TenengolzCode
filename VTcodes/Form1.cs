using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTcodes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string[] CombinationCodes(int n, int l)
        {
            String[] Codes = new String[(int)Math.Pow(2, n)];
            for (int i = 0; i < Codes.Length; i++)
                Codes[i] = "";
            int step = (int)Math.Pow(2, n - 1);
            for (int i = 0; i < n; i++)
            {
                char current = '0';
                for (int j = 1; j <= Codes.Length; j++)
                {
                    Codes[j - 1] += current;
                    if (j % step == 0)
                    {
                        if (current == '0') current = '1';
                        else current = '0';
                    }
                }
                step = step / 2;
            }
            String[] VTCodes = new String[Codes.Length];
            int k = 0;
            for (int i = 0; i < Codes.Length; i++)
            {
                int s = 0;
                for (int j = 0; j < n; j++)
                    s += Codes[i][j] * (j + 1);
                if (s % l == 0)
                    VTCodes[k++] = Codes[i];
            }
            String[] output = new String[k];
            for (int i = 0; i < k; i++)
                output[i] = VTCodes[i];
            return output;
        }
        private void GenCode_Click(object sender, EventArgs e)
        {
            string[] codes = CombinationCodes(Convert.ToInt32(textBoxN.Text), Convert.ToInt32(textBoxN.Text) + 1);
            Random rand = new Random();
            textBoxCode.Text = codes[rand.Next(0,codes.Count() -1)];
        }
        public static string XOR(string R, string key)
        {
            string newkey = "";
            if (R.Length == key.Length)
            { newkey = key; }
            string answer = "";
            for (int i = 0; i < R.Length; i++)
            {
                if ((R[i] == '1' && newkey[i] == '1') || (R[i] == '0' && newkey[i] == '0'))
                    answer += '0';
                if ((R[i] == '0' && newkey[i] == '1') || (R[i] == '1' && newkey[i] == '0'))
                    answer += '1';
            }
            return answer;
        }
        public static string FixMyCode(string code, string[] codes, int n, int l, int typeerror)
        {
            string answer = "";
            if (typeerror == 0)//0->1
            {
                int s =0;
                for (int i = 0; i < code.Length; i++)
                {
                    s += (Convert.ToInt32(code[i]) - '0') * (i + 1);
                }
                int k = s % l;
                for (int i = 0; i < code.Length; i++)
                {
                    if (i == k - 1)
                    { answer += "0";}
                    else { answer += code[i]; }
                }
            }
            if (typeerror == 1)//1->0
            {
                int s = 0;
                for (int i = 0; i < code.Length; i++)
                {
                    s += (Convert.ToInt32(code[i]) - '0') * (i + 1);
                }
                int k = (s) % l;
                for (int i = 0; i < code.Length; i++)
                {
                    if (i == (-1 * k + n))
                    { answer += "1"; }
                    else { answer += code[i]; }
                }
            }
            if (typeerror == 2)
            {
                int w = 0;
                int s = 0;
                for (int i = 0; i < code.Length; i++)
                {
                    s += (Convert.ToInt32(code[i]) - '0') * (i + 1);
                    w += Convert.ToInt32(code[i]) - '0';
                }
                int k = s % l;

                if (k == 0)
                {
                    for (int i = 0; i < code.Length - 1; i++)
                        answer += code[i];
                }
                if (k == w)
                {
                    for (int i = 1; i < code.Length; i++)
                        answer += code[i];
                }

                if (k < w && k > 0)
                {
                    string temp = "";
                    temp += code[0];
                    answer += code[0];
                    int sumzero = 0;
                    for (int i = 1; i < code.Length - 1; i++)
                    {
                        int j = i + 1;
                        if (code[i] == '0')
                        {
                            while (j < code.Length && sumzero != k)
                            {
                                sumzero += (Convert.ToInt32(code[j]) - '0') % 2;
                                j++;
                            }
                            temp += code[i];

                            i++;
                            while (i < code.Length)
                            { answer += code[i]; i++; }
                            //break;
                        }
                        else { answer += code[i]; temp += code[i]; continue; }
                        int sum =0;
                        for (int p=0; p < answer.Length; p++)
                        {
                             sum += (Convert.ToInt32(answer[p]) - '0') * (p + 1);
                        }
                        if (sum % (n + 1) == 0)
                        { return answer; }
                        else { sumzero = 0; sum = 0; answer = ""; answer = temp + code[temp.Length]; temp= answer; ; i = temp.Length-1; }
                    }

                    }
                    
            
                if (k > w)
                {
                    string temp = "";
                    temp += code[0];
                    answer += code[0];
                    int sumzero = 0;
                    for (int i = 1; i < code.Length - 1; i++)
                    {
                        int j = i + 1;
                        if (code[i] == '1')
                        {
                            while (j < code.Length && sumzero != n + 1 - k)
                            {
                                sumzero += (Convert.ToInt32(code[j]) - '0' + 1) % 2;
                                j++;
                            }
                            temp += code[i];

                            i++;
                            while (i < code.Length)
                            { answer += code[i]; i++; }
                            //break;
                        }
                        else { answer += code[i]; temp += code[i]; continue; }
                        int sum =0;
                        for (int p=0; p < answer.Length; p++)
                        {
                             sum += (Convert.ToInt32(answer[p]) - '0') * (p + 1);
                        }
                        if (sum % (n + 1) == 0)
                        { return answer; }
                        else { sumzero = 0; sum = 0; answer = ""; answer = temp + code[temp.Length]; temp= answer; ; i = temp.Length-1; }
                    }

                }
            }
            return answer;
        }
        public static string FixMyCode2(string code, string[] codes, int n, int l, int typeerror)
        {
            string answer = "";
            if (typeerror == 0)//0->1
            {
                int s = 0;
                for (int i = 0; i < code.Length; i++)
                {
                    s += (Convert.ToInt32(code[i]) - '0') * (i + 1);
                }
                int k = s % l;
                for (int i = 0; i < code.Length; i++)
                {
                    if (i == k - 1)
                    { answer += "0"; }
                    else { answer += code[i]; }
                }
            }
            if (typeerror == 1)//1->0
            {
                int s = 0;
                for (int i = 0; i < code.Length; i++)
                {
                    s += (Convert.ToInt32(code[i]) - '0') * (i + 1);
                }
                int k = (s) % l;
                for (int i = 0; i < code.Length; i++)
                {
                    if (i == (-1 * k + n))
                    { answer += "1"; }
                    else { answer += code[i]; }
                }
            }
            if (typeerror == 2)
            {
                int w = 0;
                int s = 0;
                for (int i = 0; i < code.Length; i++)
                {
                    s += (Convert.ToInt32(code[i]) - '0') * (i + 1);
                    w += Convert.ToInt32(code[i]) - '0';
                }
                int k = s % l;

                if (k == 0)
                {
                    for (int i = 0; i < code.Length - 1; i++)
                        answer += code[i];
                }
                if (k == w)
                {
                    for (int i = 1; i < code.Length; i++)
                        answer += code[i];
                }

                if (k < w && k > 0)
                {
                    string temp = "";
                    temp += code[0];
                    answer += code[0];
                    int sumzero = 0;
                    for (int i = 1; i < code.Length - 1; i++)
                    {
                        int j = i + 1;
                        if (code[i] == '0')
                        {
                            while (j < code.Length)
                            {
                                sumzero += (Convert.ToInt32(code[j]) - '0') % 2;
                                j++;
                            }
                            if (sumzero == k)
                            { i++; while (i < code.Length) { answer += code[i]; i++; } }
                            else { answer += code[i]; sumzero = 0; }
                        }
                        else { answer += code[i]; }

                    }

                }


                if (k > w)
                {
                    string temp = "";
                    temp += code[0];
                    answer += code[0];
                    int sumzero = 0;
                    for (int i = 1; i < code.Length - 1; i++)
                    {
                        int j = i + 1;
                        if (code[i] == '1')
                        {
                            while (j < code.Length)
                            {
                                sumzero += (Convert.ToInt32(code[j]) - '0'+1) % 2;
                                j++;
                            }
                            if (sumzero == n+1-k)
                            { i++; while (i < code.Length) { answer += code[i]; i++; } }
                            else { answer += code[i]; sumzero =0; }
                        }
                        else { answer += code[i]; }

                    }

                }
                    

                
            }
            return answer;
        }
        private void Fix_Click(object sender, EventArgs e)
        {
            string[] codes = CombinationCodes(Convert.ToInt32(textBoxN.Text), Convert.ToInt32(textBoxN.Text) + 1);
            string mycode = textBoxCode.Text;
            int n = Convert.ToInt32(textBoxN.Text);
            int typeerror = -1 ;
            if (mycode.Length == n && textBoxTypeError.Text == "0->1") typeerror = 0;
            if (mycode.Length == n && textBoxTypeError.Text == "1->0") typeerror = 1;
            if (mycode.Length == n + 1) typeerror = 2;
            textBoxFixed.Text = FixMyCode2(mycode, codes, n, n + 1, typeerror);
        }
    }
}
