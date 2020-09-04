using System;
using System.Collections.Generic;
using System.Text;

namespace ChainofReposibilities.Interfaces
{
    public interface IResponer
    {
        object Handle(object request);
        IResponer SetNext(IResponer responer);
    }
}
