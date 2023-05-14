using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoProdutos.Domain.Core
{
    public class DomainException : Exception
    {
        public int ErrorCode { get; set; }
        public List<string> Errors { get; set; }

        public DomainException(string mensagem, int errorCode, List<string> errors) : base(mensagem)
        {
            ErrorCode = errorCode;
            Errors = errors;
        }
    }
}
