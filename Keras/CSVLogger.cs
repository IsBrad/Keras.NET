namespace Keras
{
    /// <summary>
    ///     Callback that streams epoch results to a csv file.
    ///     Supports all values that can be represented as a string, including 1D iterables such as np.ndarray.
    /// </summary>
    /// <seealso cref="Keras.Callbacks.Callback" />
    public class CSVLogger : Callback
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="LearningRateScheduler" /> class.
        /// </summary>
        /// <param name="filename">filename of the csv file, e.g. 'run/log.csv'.</param>
        /// <param name="separator">string used to separate elements in the csv file.</param>
        /// <param name="append">True: append if file exists (useful for continuing training). False: overwrite existing file,</param>
        public CSVLogger(string filename, string separator = ",", bool append = false)
        {
            Parameters["filename"] = filename;
            Parameters["separator"] = separator;
            Parameters["append"] = append;

            PyInstance = Instance.keras.callbacks.CSVLogger;
            Init();
        }
    }
}