using System.IO;
using Python.Runtime;

namespace Keras
{
    /// <summary>
    ///     Abstract base class used to build new callbacks.
    ///     The logs dictionary that callback methods take as argument will contain keys for quantities relevant to the current
    ///     batch or epoch.
    ///     Currently, the.fit() method of the Sequential model class will include the following quantities in the logs that it
    ///     passes to its callbacks:
    ///     on_epoch_end: logs include acc and loss, and optionally include val_loss(if validation is enabled in fit), and
    ///     val_acc(if validation and accuracy monitoring are enabled). on_batch_begin: logs include size, the number of
    ///     samples in the current batch.on_batch_end: logs include loss, and optionally acc(if accuracy monitoring is
    ///     enabled).
    /// </summary>
    /// <seealso cref="Keras.Base" />
    public class Callback : Base
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Callback" /> class.
        /// </summary>
        public Callback()
        {
            PyInstance = Instance.keras.callbacks.Callback();
        }

        public Callback(PyObject py)
        {
            PyInstance = py;
        }

        public static Callback Custom(string name, string fileOrcode, bool isFile = true)
        {
            var code = "";
            if (isFile)
                code = File.ReadAllText(fileOrcode);
            else
                code = fileOrcode;

            var py = PythonEngine.ModuleFromString(name, code);
            py = py.InvokeMethod(name);
            return new Callback(py);
        }

        public T Get<T>(string property)
        {
            return ((PyObject) PyInstance).GetAttr(property).As<T>();
        }
    }
}