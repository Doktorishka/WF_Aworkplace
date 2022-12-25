using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Aworkplace.Model
{
    public interface IValidation
    {
        bool IsValid();
        bool IsValid(params int[] ints);
        bool IsValid(params string[] strings);
    }
}
