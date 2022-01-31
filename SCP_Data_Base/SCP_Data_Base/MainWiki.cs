using System;
using System.Collections.Generic;
using System.Text;

namespace SCP_Data_Base
{
    internal abstract class MainWiki
    {
        public string Name { get; private set; }
        public string designation { get; private set; }
        public string CT { get; private set; }
        public string aDS { get; private set; }
        public string DS { get; private set; }
        public string AD { get; private set; }

        protected MainWiki(string aName, string aDesignation, string aCT, string aADS, string aDS, string aAD)
        {
            this.Name = aName;
            this.designation = aDesignation;
            this.CT = aCT;
            this.aDS = aADS;
            this.DS = aDS;
            this.AD = aAD;
        }

        public abstract void CallSCP();
    }
}
