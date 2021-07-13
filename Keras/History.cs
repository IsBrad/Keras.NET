using System.Collections.Generic;
using Python.Runtime;

namespace Keras
{
    /// <summary>
    ///     Callback that records events into a History object.    This callback is automatically applied to every Keras
    ///     model.The History object gets returned by the fit method of models.
    /// </summary>
    /// <seealso cref="Keras.Callbacks.Callback" />
    public class History : Callback
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="History" /> class.
        /// </summary>
        public History()
        {
            PyInstance = keras.callbacks.History;
            Init();
        }

        public History(PyObject py)
        {
            PyInstance = py;
        }

        /// <summary>
        ///     Gets the epoch.
        /// </summary>
        /// <value>
        ///     The epoch.
        /// </value>
        public int[] Epoch => ((PyObject) PyInstance.epoch).As<int[]>();

        /// <summary>
        ///     Gets the history logs.
        /// </summary>
        /// <value>
        ///     The history logs.
        /// </value>
        public Dictionary<string, double[]> HistoryLogs
        {
            get
            {
                var dict = new PyDict(PyInstance.history);
                var result = new Dictionary<string, double[]>();
                var keys = dict.Keys().As<string[]>();
                foreach (var item in keys) result.Add(item, dict[item].As<double[]>());

                return result;
            }
        }
    }
}