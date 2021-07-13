namespace Keras
{
    /// <summary>
    ///     Reduce learning rate when a metric has stopped improving.
    ///     Models often benefit from reducing the learning rate by a factor of 2-10 once learning stagnates.
    ///     This callback monitors a quantity and if no improvement is seen for a 'patience' number of epochs, the learning
    ///     rate is reduced.
    /// </summary>
    /// <seealso cref="Keras.Callbacks.Callback" />
    public class ReduceLROnPlateau : Callback
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="LearningRateScheduler" /> class.
        /// </summary>
        /// <param name="monitor"> quantity to be monitored.</param>
        /// <param name="factor"> factor by which the learning rate will be reduced. new_lr = lr * factor</param>
        /// <param name="patience"> number of epochs with no improvement after which learning rate will be reduced.</param>
        /// <param name="verbose"> int. 0: quiet, 1: update messages.</param>
        /// <param name="mode">
        ///     one of {auto, min, max}. In min mode, lr will be reduced when the quantity monitored has stopped
        ///     decreasing; in max mode it will be reduced when the quantity monitored has stopped increasing; in auto mode, the
        ///     direction is automatically inferred from the name of the monitored quantity.
        /// </param>
        /// <param name="min_delta"> threshold for measuring the new optimum, to only focus on significant changes.</param>
        /// <param name="cooldown"> number of epochs to wait before resuming normal operation after lr has been reduced.</param>
        /// <param name="min_lr"> lower bound on the learning rate.</param>
        public ReduceLROnPlateau(string monitor = "val_loss", float factor = 0.1f, int patience = 10, int verbose = 0,
            string mode = "auto", float min_delta = 0.0001f, int cooldown = 0, float min_lr = 0)
        {
            Parameters["monitor"] = monitor;
            Parameters["factor"] = factor;
            Parameters["patience"] = patience;
            Parameters["verbose"] = verbose;
            Parameters["mode"] = mode;
            Parameters["min_delta"] = min_delta;
            Parameters["cooldown"] = cooldown;
            Parameters["min_lr"] = min_lr;

            PyInstance = Instance.keras.callbacks.ReduceLROnPlateau;
            Init();
        }
    }
}