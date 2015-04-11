using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;

namespace Utility
{

    public class WrapperResult<T> : ISingleResult<T>
    {
        #region IFunctionResult Properties

        public List<T> Results { get; set; }
        public object ReturnValue { get; set; }

        #endregion

        #region Constructor

        public WrapperResult(ISingleResult<T> inner)
        {
            Results = inner.ToList();
            ReturnValue = inner.ReturnValue;
        }

        #endregion

        #region IEnumerable<T> Members

        public IEnumerator<T> GetEnumerator()
        {
            return Results.GetEnumerator();
        }

        #endregion

        #region IEnumerable Members

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)Results).GetEnumerator();
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
        }

        #endregion
    }
}
