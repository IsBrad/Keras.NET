namespace Keras
{
    /// <summary>
    ///     Save the model after every epoch.
    ///     filepath can contain named formatting options, which will be filled with the values of epoch and keys in
    ///     logs(passed in on_epoch_end).
    ///     For example: if filepath is weights.{epoch:02d}-{val_loss:.2f}.hdf5, then the model checkpoints will be saved with
    ///     the epoch number and the validation loss in the filename.
    /// </summary>
    /// <seealso cref="Keras.Callbacks.Callback" />
    public class ModelCheckpoint : Callback
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ModelCheckpoint" /> class.
        /// </summary>
        /// <param name="filepath">string, path to save the model file.</param>
        /// <param name="monitor">quantity to monitor.</param>
        /// <param name="verbose">verbosity mode, 0 or 1.</param>
        /// <param name="save_best_only">
        ///     if save_best_only=True, the latest best model according to the quantity monitored will not
        ///     be overwritten.
        /// </param>
        /// <param name="save_weights_only">
        ///     if True, then only the model's weights will be saved (model.save_weights(filepath)),
        ///     else the full model is saved (model.save(filepath)).
        /// </param>
        /// <param name="mode">
        ///     one of {auto, min, max}. If save_best_only=True, the decision to overwrite the current save file is
        ///     made based on either the maximization or the minimization of the monitored quantity. For  val_acc, this should be
        ///     max, for val_loss this should be min, etc. In auto mode, the direction is automatically inferred from the name of
        ///     the monitored quantity.
        /// </param>
        /// <param name="period">Interval (number of epochs) between checkpoints.</param>
        public ModelCheckpoint(string filepath, string monitor = "val_loss", int verbose = 0, bool save_best_only = true
            , bool save_weights_only = false, string mode = "auto", int period = 1)
        {
            Parameters["filepath"] = filepath;
            Parameters["monitor"] = monitor;
            Parameters["verbose"] = verbose;
            Parameters["save_best_only"] = save_best_only;
            Parameters["save_weights_only"] = save_weights_only;
            Parameters["mode"] = mode;
            Parameters["period"] = period;

            PyInstance = Instance.keras.callbacks.ModelCheckpoint;
            Init();
        }
    }
}