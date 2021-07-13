using Python.Runtime;

namespace Keras.Utils
{
    /// <summary>
    ///     Provides a scope that changes to _GLOBAL_CUSTOM_OBJECTS cannot escape.
    ///     Code within a with statement will be able to access custom objects by name.Changes to global custom objects persist
    ///     within the enclosing with statement.
    ///     At end of the with statement, global custom objects are reverted to state at beginning of the with statement.
    /// </summary>
    /// <seealso cref="Keras.Base" />
    public class CustomObjectScope : Base
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="CustomObjectScope" /> class.
        /// </summary>
        public CustomObjectScope()
        {
            PyInstance = Instance.keras.utils.CustomObjectScope;
        }

        /// <summary>
        ///     Performs an implicit conversion from <see cref="PyObject" /> to <see cref="CustomObjectScope" />.
        /// </summary>
        /// <param name="py">The py.</param>
        /// <returns>
        ///     The result of the conversion.
        /// </returns>
        public static implicit operator CustomObjectScope(PyObject py)
        {
            var obj = new CustomObjectScope();
            obj.PyInstance = py;

            return obj;
        }
    }
}