using ChainofReposibilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainofReposibilities
{
    class CEO : Responer
    {
        public override object Handle(object request)
        {
            if ((Int32)request < 100)
            {
                return "CEO handle it";
            }
            if (_nextHandle != null)
            {
               return  _nextHandle.Handle(request);
            }
            return "We cannot handle it! Sorry";
        }
    }
}
