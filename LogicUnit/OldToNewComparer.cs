using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace LogicUnit
{
    internal class OldToNewComparer : IPostComparer
    {
        public bool ShouldSwap(Post i_Post1, Post i_Post2)
        {

            return i_Post1.CreatedTime.Value.Date > i_Post2.CreatedTime.Value.Date;
        }
    }
}
