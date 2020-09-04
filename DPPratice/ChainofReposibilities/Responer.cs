using ChainofReposibilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainofReposibilities
{
    public abstract class Responer : IResponer
    {
        public IResponer _nextHandle { get; set; }

        public virtual object Handle(object request)
        {
            throw new NotImplementedException();
        }

        public IResponer SetNext(IResponer responer)
        {
            _nextHandle = responer;
            return _nextHandle;
        }
    }
}
