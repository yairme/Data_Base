using System;
using System.Collections.Generic;
using System.Text;

namespace SCP_Data_Base
{
    internal class SCP : MainWiki
    {
        public SCP(string aName, string aDesignation, string CT, string aDS, string DS, string AD) : base(aName, aDesignation, CT, aDS, DS, AD)
        {

        }

        public override void CallSCP()
        {
            Console.WriteLine($"This is {Name}, it's designation is {designation}.\n\n {CT} \n\n {aDS} \n\n {DS} \n\n {AD}" );
        }
    }
}