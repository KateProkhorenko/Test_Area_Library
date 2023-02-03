using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLibrary.Interfaces
{
    public interface ITriangle : IShape
    {
        double SideA { get; }
        double SideB { get; }
        double SideC { get; }

        bool IsRightTriangle { get; }
    }
}
