using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public interface IResult
    {
        //voidler için dönüşleri burada yazacağız.
        bool Success { get; } //get sadece okumak için.. işle başarılı mı
        string Message { get; }//işlem mesajı
    }
}
