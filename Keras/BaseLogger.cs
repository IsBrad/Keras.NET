using System.Linq;

namespace Keras
{
    /// <summary>
    ///     Callback that accumulates epoch averages of metrics.    This callback is automatically applied to every Keras
    ///     model.
    /// </summary>
    /// <seealso cref="Keras.Callbacks.Callback" />
    public class BaseLogger : Callback
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="BaseLogger" /> class.
        /// </summary>
        /// <param name="stateful_metrics">
        ///     Iterable of string names of metrics that should not be averaged over an epoch. Metrics
        ///     in this list will be logged as-is in on_epoch_end. All others will be averaged in on_epoch_end.
        /// </param>
        public BaseLogger(params string[] stateful_metrics)
        {
            Parameters["stateful_metrics"] = stateful_metrics != null ? stateful_metrics.ToList() : null;
            PyInstance = Instance.keras.callbacks.BaseLogger;
            Init();
        }
    }
}