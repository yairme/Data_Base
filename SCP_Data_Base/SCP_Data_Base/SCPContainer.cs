using System;
using System.Collections.Generic;
using System.Text;

namespace SCP_Data_Base
{
    class SCPContainer
    {
        private List<MainWiki> _SCPs;
        public SCPContainer()
        {
            _SCPs = new List<MainWiki>();
        }

        public void AddID(MainWiki ID)
        {
            _SCPs.Add(ID);
        }

        public List<MainWiki> GetID()
        {
            return _SCPs;
        }

        public void Use(int index)
        {
            _SCPs[index - 1].CallSCP();
        }
    }
}
