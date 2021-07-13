using Python.Runtime;

namespace Keras
{
    public class KerasIterator : object
    {
        /// <summary>
        ///     The py object which is the base variable
        /// </summary>
        public PyObject PyObject;

        /// <summary>
        ///     Initializes a new instance of the <see cref="StringOrInstance" /> class.
        /// </summary>
        /// <param name="obj">The object.</param>
        public KerasIterator(PyObject obj)
        {
            PyObject = obj;
        }
    }
}