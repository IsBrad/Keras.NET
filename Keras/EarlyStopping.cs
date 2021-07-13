namespace Keras
{
    /// <summary>
    ///     Stop training when a monitored quantity has stopped improving.
    /// </summary>
    /// <seealso cref="Keras.Callbacks.Callback" />
    public class EarlyStopping : Callback
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="EarlyStopping" /> class.
        /// </summary>
        /// <param name="monitor">quantity to be monitored.</param>
        /// <param name="min_delta">
        ///     minimum change in the monitored quantity to qualify as an improvement, i.e. an absolute change
        ///     of less than min_delta, will count as no improvement.
        /// </param>
        /// <param name="patience">number of epochs with no improvement after which training will be stopped.</param>
        /// <param name="verbose">verbosity mode.</param>
        /// <param name="mode">
        ///     one of {auto, min, max}. In min mode, training will stop when the quantity monitored has stopped
        ///     decreasing; in max mode it will stop when the quantity monitored has stopped increasing; in auto mode, the
        ///     direction is automatically inferred from the name of the monitored quantity.
        /// </param>
        /// <param name="baseline">
        ///     Baseline value for the monitored quantity to reach. Training will stop if the model doesn't
        ///     show improvement over the baseline.
        /// </param>
        /// <param name="restore_best_weights">
        ///     whether to restore model weights from the epoch with the best value of the
        ///     monitored quantity. If False, the model weights obtained at the last step of training are used.
        /// </param>
        public EarlyStopping(string monitor = "val_loss", float min_delta = 0, int patience = 0, int verbose = 0,
            string mode = "auto", float? baseline = null, bool restore_best_weights = false)
        {
            Parameters["monitor"] = monitor;
            Parameters["min_delta"] = min_delta;
            Parameters["patience"] = patience;
            Parameters["verbose"] = verbose;
            Parameters["mode"] = mode;
            Parameters["baseline"] = baseline;
            Parameters["restore_best_weights"] = restore_best_weights;

            PyInstance = Instance.keras.callbacks.EarlyStopping;
            Init();
        }
    }
}