using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
    public class MasterMindParam
    {
        private int numberofdigits ;
        private int rangestarts;
        private int rangeends;
        private int attemps;
        private string correctwrongposition;
        private string correctposition;
        private Boolean duplicatedigits;
        public MasterMindParam(int Number,int rangeS,int rangeE,int Att,string CoWrPo,string CoPo,Boolean Dup)
        {
            this.numberofdigits = Number;
            this.rangestarts = rangeS;
            this.rangeends = rangeE;
            this.attemps = Att;
            this.correctwrongposition = CoWrPo;
            this.correctposition = CoPo;
            this.duplicatedigits = Dup;
        }
        public int NumberOfDigits
        {
            get
            {
                return this.numberofdigits;
            }
            set
            {
                this.numberofdigits = value;
            }
        }
        public int RangeStarts
        {
            get
            {
                return this.rangestarts;
            }
            set
            {
                this.rangestarts = value;
            }
        }
        public int RangeEnds
        {
            get
            {
                return this.rangeends;
            }
            set
            {
                this.rangeends = value;
            }
        }
        public int Attemps
        {
            get
            {
                return this.attemps;
            }
            set
            {
                this.attemps = value;
            }
        }
        public String CorrectWrongPosition
        {
            get
            {
                return this.correctwrongposition;
            }
            set
            {
                this.correctwrongposition = value;
            }
        }
        public String CorrectPosition
        {
            get
            {
                return this.correctposition;
            }
            set
            {
                this.correctposition = value;
            }
        }
        public Boolean DuplicateDigits
        {
            get
            {
                return this.duplicatedigits;
            }
            set
            {
                this.duplicatedigits = value;
            }
        }


    }
}
