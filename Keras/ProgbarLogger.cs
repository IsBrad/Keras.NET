using System.Linq;

namespace Keras
{
    /// <summary>
    ///     Callback that prints metrics to stdout.
    /// </summary>
    /// <seealso cref="Keras.Callbacks.Callback" />
    public class ProgbarLogger : Callback
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ProgbarLogger" /> class.
        /// </summary>
        /// <param name="count_mode">
        ///     One of "steps" or "samples". Whether the progress bar should count samples seen or steps
        ///     (batches) seen.
        /// </param>
        /// <param name="stateful_metrics">
        ///     Iterable of string names of metrics that should not be averaged over an epoch. Metrics
        ///     in this list will be logged as-is. All others will be averaged over time (e.g. loss, etc).
        /// </param>
        public ProgbarLogger(string count_mode = "samples", params string[] stateful_metrics)
        {
            Parameters["count_mode"] = count_mode;
            Parameters["stateful_metrics"] = stateful_metrics != null ? stateful_metrics.ToList() : null;
            PyInstance = Instance.keras.callbacks.ProgbarLogger;
            Init();
        }
    }
}