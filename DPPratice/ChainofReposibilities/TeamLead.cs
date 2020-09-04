using ChainofReposibilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainofReposibilities
{
    class TeamLead : Responer
    {
        public override object Handle(object request)
        {
            if ((Int32)request < 20)
            {
                return "TeamLead handle it";
            }
            if (_nextHandle != null)
            {
                return _nextHandle.Handle(request);
            }
            return "We cannot handle it! Sorry";
        }
    }
}
