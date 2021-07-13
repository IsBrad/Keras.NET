using Python.Runtime;

namespace Keras
{
    public class KerasFunction
    {
        /// <summary>
        ///     The py object which is the base variable
        /// </summary>
        public PyObject PyObject;

        /// <summary>
        ///     Initializes a new instance of the <see cref="StringOrInstance" /> class.
        /// </summary>
        /// <param name="obj">The object.</param>
        public KerasFunction(PyObject obj)
        {
            PyObject = obj;
        }
    }
}