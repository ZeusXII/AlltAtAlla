using System;
using System.Collections.Generic;
using System.Text;

namespace AlltAtAlla
{
    class FalseBlock : Block
    {
        public FalseBlock()
        {
            fallThrough = true;
        }
    }
}
