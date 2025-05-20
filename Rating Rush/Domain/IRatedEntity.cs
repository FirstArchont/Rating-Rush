using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rating_Rush.Domain
{
    public interface IRatedEntity
    {
        string Name { get; }
        int Stars { get; }
    }
}