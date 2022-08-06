using System;
using System.Collections.Generic;
using System.Text;

namespace Manager.Abstract
{
    public interface IElementWithId
    {
        Guid Id
        {
            get;
        }
        public int IDmovie { get; set; }
    }
}
