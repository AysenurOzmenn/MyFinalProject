using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    //interface'i interface'e implemente edince diğerinin içeriğine sahip olur.
    public interface IDataResult<T>:IResult //IResult içeriğine sahip ol
    {
        //IDataResult'ın ekstra sahip oldukları;
        T Data { get; }
    }
}
