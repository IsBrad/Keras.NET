namespace Keras
{
    /// <summary>
    ///     Learning rate scheduler.
    /// </summary>
    /// <seealso cref="Keras.Callbacks.Callback" />
    public class LearningRateScheduler : Callback
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="LearningRateScheduler" /> class.
        /// </summary>
        /// <param name="schedule">
        ///     a function that takes an epoch index as input (integer, indexed from 0) and current learning
        ///     rate and returns a new learning rate as output (float).
        /// </param>
        /// <param name="verbose">int. 0: quiet, 1: update messages.</param>
        public LearningRateScheduler(object schedule, int verbose = 0)
        {
            Parameters["schedule"] = schedule;
            Parameters["verbose"] = verbose;

            PyInstance = Instance.keras.callbacks.LearningRateScheduler;
            Init();
        }
    }
}