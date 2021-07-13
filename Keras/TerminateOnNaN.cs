namespace Keras
{
    /// <summary>
    ///     Callback that terminates training when a NaN loss is encountered.
    /// </summary>
    /// <seealso cref="Keras.Callbacks.Callback" />
    public class TerminateOnNaN : Callback
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="TerminateOnNaN" /> class.
        /// </summary>
        public TerminateOnNaN()
        {
            PyInstance = Instance.keras.callbacks.TerminateOnNaN;
            Init();
        }
    }
}