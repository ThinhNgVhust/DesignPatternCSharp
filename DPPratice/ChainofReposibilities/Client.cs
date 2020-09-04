using ChainofReposibilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainofReposibilities
{
    public class Client
    {
        public Client(int type) { TypeRequest = type; }
        public int TypeRequest { get; set; }
        public string CreateRequest(IResponer responer)
        {
            return responer.Handle(TypeRequest) as String;
        }
    }
}
