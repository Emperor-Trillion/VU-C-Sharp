using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace taskTwoCs
{
    public partial class Form1 : Form
    {
        string value;
        string WholeInputString = "";
        string WholeInputStringLeft = "";
        string WholeInputStringRight = "";
        int WholeInputInt;
        float NewResult = 0;
        
        List<string> EntityLeft = [];
        List<string> EntityRight = [];
        int num;
        List<int> TableOfInputs = [];
        private void HandleBtnClick(object sender, EventArgs e)
        {
            Button clicked = (Button)sender;
            _DisplayHolder.Text = WholeInputString;
            _ResultDisplay.Text = NewResult;
            WholeInputString = "";
            LeftNum = NewResult;
        }
        private HandleInputOfNums(object sender, EventArgs e)
        {
            Button clicked = (Button)sender;
            value = clicked.Text;
            if (WholeInputStringLeft == "" && value == Table[1] || value == Table[4] || value == Table[5] || value == Table[6] || value == Table[8]
            || value == Table[9] || value == Table[10] || value == Table[12] || value == Table[13] || value == Table[14])
            {
                EntityLeft.Add(value);
                for(int i = 0; i < EntityLeft.Count; i++)
                {
                    WholeInputStringLeft = WholeInputStringLeft + EntityLeft[i];
                }
            }
            if (WholeInputStringLeft != "" && value == Table[1] || value == Table[4] || value == Table[5] || value == Table[6] || value == Table[8]
            || value == Table[9] || value == Table[10] || value == Table[12] || value == Table[13] || value == Table[14])
            EntityRight.Add(value);
                for(int i = 0; i < EntityRight.Count; i++)
                {
                    WholeInputStringRight = WholeInputStringRight + EntityRight[i];
                }
        }
        private void HandleArithOps(object sender, EventArgs e)
        {
            Button clicked = (Button)sender;
            value = clicked.Text;
            if(WholeInputStringLeft = "")
            {
                WholeInputStringLeft = "0";
            }
            if(WholeInputStringRight = "")
            {
                WholeInputStringRight = "0";
            }
            WholeInputString = WholeInputStringLeft + value + WholeInputStringRight;
            LeftNum = ConvInputToInt.WholeInputStringLeft;
            RightNum = ConvInputToInt.WholeInputStringRight;
            if (value == Table[0])
            {
                NewResult = LeftNum * (-1);
            }
            else if (value == Table[7])
            {
                NewResult = LeftNum + RightNum;
            }
            else if (value == Table[11])
            {
                NewResult = LeftNum - RightNum;
            }
            else if (value == Table[15])
            {
                NewResult = LeftNum * RightNum;
            }
            else if (value == Table[17])
            {
                WholeInputString = LeftNum + value
                NewResult = LeftNum * (1 / 100);
            }
            else if (value == Table[18])
            {
                //NewResult = LeftNum + RightNum;
            }
            else if (value == Table[19])
            {
                NewResult = LeftNum / RightNum;
            }
            else if (value == Table[3])
            {
                _ResultDisplay.Text = NewResult;
            }

        }
        private static ConvInputToInt(string JustNumString)
        {
            float JustNum = Convert.ToSingle(JustNumString);
            return JustNum;
        }

        public Form1()
        {
            InitializeComponent();
        }

    }

}
