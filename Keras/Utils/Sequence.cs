using Numpy;
using Python.Runtime;

namespace Keras.Utils
{
    /// <summary>
    ///     Base object for fitting to a sequence of data, such as a dataset.
    ///     Sequence are a safer way to do multiprocessing. This structure guarantees that the network will only train once on
    ///     each sample per epoch which is not the case with generators.
    /// </summary>
    /// <seealso cref="Keras.Base" />
    public class Sequence : Base
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Sequence" /> class.
        /// </summary>
        public Sequence()
        {
            PyInstance = Instance.keras.utils.Sequence;
            //Init();
        }

        internal Sequence(PyObject py)
        {
            PyInstance = py;
        }

        /// <summary>
        ///     Performs an implicit conversion from <see cref="PyObject" /> to <see cref="CustomObjectScope" />.
        /// </summary>
        /// <param name="py">The py.</param>
        /// <returns>
        ///     The result of the conversion.
        /// </returns>
        public static implicit operator Sequence(PyObject py)
        {
            var obj = new Sequence();
            obj.PyInstance = py;

            return obj;
        }

        public static implicit operator Sequence(NDarray x)
        {
            return new Sequence(x.PyObject);
        }

        public static implicit operator Sequence(KerasIterator py)
        {
            var obj = new Sequence();
            obj.PyInstance = py.PyObject;

            return obj;
        }
    }
}